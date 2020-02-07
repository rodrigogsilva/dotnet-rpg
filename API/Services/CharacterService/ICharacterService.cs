using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Character;
using API.Models;

namespace API.services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(Guid id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);
    }
}
