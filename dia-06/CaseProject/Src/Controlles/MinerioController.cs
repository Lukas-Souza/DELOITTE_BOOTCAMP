using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTOs;
using Models;
using MinhaApi;
using MinhaApi.Data;
using Microsoft.AspNetCore.SignalR;

namespace Controllers
{
    [ApiController]
    [Route("/lot-minerio")]
    public class MinerioController : ControllerBase
    {
        private readonly AppDbContext Db_;
        public MinerioController(AppDbContext db) => Db_ = db;


        [HttpGet]
    public async Task<IActionResult> GetElement()
        {

            var returnAll = await Db_.LotesMinerio.ToListAsync();
            return Ok(returnAll);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            
            
                // SELECT * FROM WHERE id={id_variable}
                var loteById = await Db_.LotesMinerio.FindAsync(id);
                if (loteById == null)
                {
                    return NotFound(new {menssagen= "Registro não encontrado."});
                }
                return Ok(loteById);        
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
                    return StatusCode(500, new {erro = "Ocorreu algum erro interno..", mensssagen = err});
                }
            }
        }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutElementById(int id, [FromBody] RequireLotMinerioDto dto)
        {
            // Id == id
            var loteResult = await Db_.LotesMinerio.FindAsync(id);
            if (loteResult == null)
            {
                return NotFound();
            }
            loteResult.Atualizar(
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
             
            await Db_.SaveChangesAsync();
            return NoContent();   
            }
            catch (Exception err)
            {
                return StatusCode(500, new {
                erro = "Ocorreu um erro ao atualizar o elemento.", menssagen = err
                });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveElementById(int id)
        {
            var elementById = await Db_.LotesMinerio.FindAsync(id);
            if (elementById == null)
            {
                return NotFound(new {menssagen= "Registro não encontrado ou não existe."});               
            }
            else
            {

            try
            {
             
            Db_.Remove(elementById);

            return NoContent();   
            }
            catch (Exception err)
            {
                
                return StatusCode(500, new {erro= "Ocorreu um erro ao remover o elemento.", menssagen= err});
            }

            }
            
        }
        // GETs
        [HttpGet("status")]
        public async Task<IActionResult> GetElementByStatus([FromQuery] string status_query)
        {
        try
        {
            var GetElementByStatus_ = Db_.LotesMinerio.Where(x => x.Status == status_query.ToUpper());
            return Ok(GetElementByStatus_);
                    
        
                
        }
        catch (System.Exception)
        {
            
            return StatusCode(500, new {menssagen="Ocorreu algum erro interno."});
        }
        
        }
    }
}


