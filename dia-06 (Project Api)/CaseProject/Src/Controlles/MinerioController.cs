using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTOs;
using Models;
using MinhaApi;
using MinhaApi.Data;
using Microsoft.AspNetCore.SignalR;
using DTOs.Response;

namespace CaseProject.Controlles
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

            List<LotMinerio> returnAll = await Db_.LotesMinerio.ToListAsync();
            return Ok(returnAll);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            
            
                // SELECT * FROM WHERE id={id_variable}
                LotMinerio? loteById = await Db_.LotesMinerio.FindAsync(id);
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
                
                    var ResponseObjet = new DtoResponse
                    {
                        IdLote = lote.IdLote,
                        Teor = lote.Teor,
                        PesoQuantidade = lote.PesoQuantidade,
                        TipoMinerio = lote.TipoMinerio,
                        Status = lote.Status,
                        IdMineradora = lote.IdMineradora
                    };    
                    return Ok(ResponseObjet);

                }
                catch (Exception err)
                {
                    return StatusCode(500);
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
                
                return StatusCode(500);
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