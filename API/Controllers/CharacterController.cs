using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character character = new Character();

        public IActionResult Get()
        {
            return Ok(character);
        }
    }
}