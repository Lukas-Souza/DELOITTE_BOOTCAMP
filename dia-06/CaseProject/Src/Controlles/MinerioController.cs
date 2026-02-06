using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTOs;
using Models;
using MinhaApi;
using MinhaApi.Data;

namespace Controllers
{
    [ApiController]
    [Route("/minerio")]
    public class MinerioController : ControllerBase
    {
        private readonly AppDbContext Db_;
        public MinerioController(AppDbContext db) => Db_ = db;


        [HttpGet]
        public IActionResult TestGet()
        {

            return Ok("REQUESIÇÂO REALIZADA COM SUCESSO");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMinerio([FromBody] MinerioDto dto)
        {
            if (dto == null) return BadRequest("A requesição esta vindo invalida!!");
            else
            {
                var lote = new Minerio
                {
                    Kilograma = dto.kilograma
                };
                try
                {
                    Db_.LotesMinerio.Add(lote);
                    await Db_.SaveChangesAsync();
                
                    return Ok("CRAETEEE: "+ dto.kilograma);

                }
                catch (Exception err)
                {

                    Console.WriteLine("Ocorreu um erro: " + err);
                    return BadRequest("ERRO");
                }


            }


        }
    }
}