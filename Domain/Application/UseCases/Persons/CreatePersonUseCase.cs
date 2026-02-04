using Application.DTOs.Persons;
using Domain;
using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Persons
{
    public class CreatePersonUseCase
    {
        private readonly IRepository<PersonEntity, Guid> _repository;
        private readonly ICodeRepository<PersonEntity> _codeRepository;
        public CreatePersonUseCase(
            IRepository<PersonEntity, Guid> repository,
            ICodeRepository<PersonEntity> codeRepository
            )
        {
            _repository = repository;
            _codeRepository = codeRepository;
        }

        public async Task<PersonEntity> Execute(CreatePersonDTO dto)
        {
            if(await _codeRepository.ExistsWithCodeAsync(dto.Code))
            {
                throw new InvalidOperationException($"Ya existe una persona con codigo {dto.Code}");
            }
            else
            {
                var newPerson = new PersonEntity(
                    dto.Code,
                    dto.FirstName,
                    dto.LasttName,
                    dto.Email,
                    dto.PhoneNumber
                    );

                await _repository.AddAsync(newPerson);
                await _repository.SaveChangesAsync();
                return newPerson;
            }
        }
    }
}
