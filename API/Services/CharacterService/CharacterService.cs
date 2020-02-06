using System;
using System.Collections.Generic;
using System.Linq;

namespace API.services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character { Id = Guid.NewGuid()},
            new Character { Id = Guid.NewGuid(), Name = "Sam"}
        };

        public List<Character> AddCharacter(Character character)
        {
            characters.Add(character);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(Guid id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
