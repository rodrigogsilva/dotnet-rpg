using System;
using System.Collections.Generic;

namespace API.services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(Guid id);
        List<Character> AddCharacter(Character character);
    }
}
