using Domain;
using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Persons
{
    public class DeletePersonUseCase
    {
        private readonly IRepository<PersonEntity, Guid> _repository;

        public DeletePersonUseCase(IRepository<PersonEntity, Guid> repository)
        {
            _repository = repository;
        }

        public async Task Execute(Guid id)
        {
            var foundPerson = await _repository.GetByIdAsync(id);
            if (foundPerson == null)
            {
                throw new InvalidOperationException($"No se encontró persona con el id: {id}");
            }
            else
            {
                await _repository.DeleteAsync(foundPerson);
                await _repository.SaveChangesAsync();
            }
        }
    }
}
