using Domain;
using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Persons
{
    public class GetPersonByCodeUseCase
    {
        private readonly ICodeRepository<PersonEntity> _codeRepository;

        public GetPersonByCodeUseCase(ICodeRepository<PersonEntity> codeRepository)
        {
            _codeRepository = codeRepository;
        }

        public async Task<PersonEntity> ExecuteAsync(string code)
        {
            var foundPerson = await _codeRepository.GetByCodeAsync(code);
            if (foundPerson == null)
            {
                throw new InvalidOperationException($"No se encontró una persona cuyo codigo sea: {code}");
            }
            return foundPerson;
        }
    }
}
