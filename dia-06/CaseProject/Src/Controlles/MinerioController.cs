using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTOs;
namespace Controllers
{
    [ApiController]
    [Route("/minerio")]
    public class MinerioController: ControllerBase
    {
        private readonly DbContext? Db_;


        
        [HttpGet]
        public IActionResult TestGet()
        {
            return Ok("REQUESIÇÂO REALIZADA COM SUCESSO");
        }     
            
        [HttpPost]
        public async Task<IActionResult> CreateMinerio([FromBody] MinerioDto RequireDTO ) 
        {
            if (RequireDTO == null) return BadRequest("A requesição esta vindo invalida!!");
            else return Ok("DTO RECEBIDO");


        }

    }
}