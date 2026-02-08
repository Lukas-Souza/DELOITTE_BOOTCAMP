using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTOs;
using Models;
using MinhaApi;
using MinhaApi.Data;

namespace Controllers
{
    [ApiController]
    [Route("/lot-minerio")]
    public class MinerioController : ControllerBase
    {
        private readonly AppDbContext Db_;
        public MinerioController(AppDbContext db) => Db_ = db;


        [HttpGet]
        public async Task<IActionResult> TestGet()
        {

            var returnAll = await Db_.LotesMinerio.ToListAsync();
            return Ok(returnAll);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if(id != null)
            {
                // SELECT * FROM WHERE id={id_variable}
                var loteById = await Db_.LotesMinerio.FindAsync(id);
                if (loteById == null)
                {
                    return NotFound();
                }
                return Ok(loteById);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateMinerio([FromBody] RequireLotMinerioDto dto)
        {
            if (dto == null) return BadRequest("A requesição esta vindo invalida!!");
            else
            {
                LotMinerio lote = new LotMinerio(
                    dto.Teor,
                    dto.PesoQuantidade,
                    dto.ValorPKilo,
                    dto.UnidadeDeMedidaPeso.ToUpper(),
                    dto.TipoMinerio.ToUpper(),
                    dto.Status.ToUpper(),
                    dto.IdMineradora.ToUpper()
                );
                try
                {
                     Db_.LotesMinerio.Add(lote);
                     await Db_.SaveChangesAsync();
                
                    return Ok("Registro realizado com sucesso: ");

                }
                catch (Exception err)
                {
                    return BadRequest("Ocorreu algum erro ao cadastrar: "+ err);
                }
            }
        }

    }
}