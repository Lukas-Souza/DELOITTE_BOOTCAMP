using DTOs.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;
using Models;
using Services;
using DTOs;
namespace CaseProject.Controlles
{
    [ApiController]
    [Route("/lot-minerio/classes/")]
    public class ExtraControllers: ControllerBase
    {
    ServicesLotMinerio servicesLotMinerio = new ServicesLotMinerio();

    private readonly AppDbContext Db_;
    public ExtraControllers(AppDbContext db) => Db_ = db;
    [HttpGet("{id}")]
    public async Task<IActionResult> classiscElementId(int id)
        {
            
            LotMinerio? LotMinerio_ = await Db_.LotesMinerio.FindAsync(id);
            if (LotMinerio_ == null)
            {
                return NotFound(new {Menssagen= "VALOR NÂO ENCONTRADO"});
            }
            List<LotMinerio> ListLot = new List<LotMinerio>{LotMinerio_};
            
            return Ok(servicesLotMinerio.ClassificarPorQualidade(ListLot));
        }


    [HttpGet]
    public async Task<IActionResult> GetAllClassification()
    {
        var ReturnAllClassification = await Db_.LotesMinerio.ToListAsync();

        return Ok(servicesLotMinerio.ClassificarPorQualidade(ReturnAllClassification));    
    }
    
    [HttpGet("history-transaction")]
    public async Task<IActionResult> GetHistoryTransction()
    {
    List<LotMinerio> DatResult = await Db_.LotesMinerio.ToListAsync();
    return Ok(servicesLotMinerio.ReturOutTransaciton(DatResult));
    }

    [HttpPut("transaction")]
    // http://localhost:5167/lot-minerio/classes/transaction
    public async Task<IActionResult> UpdateStatus( [FromBody] UpdateTransaction updateTransaction)
    {
        var ResultPost = await Db_.LotesMinerio.FindAsync( updateTransaction.LotMinerio);
         ResultPost.Atualizar(
                    ResultPost.Teor,
                    ResultPost.PesoQuantidade,
                    ResultPost.ValorPKilo,
                    ResultPost.UnidadeDeMedidaPeso.ToUpper(),
                    ResultPost.TipoMinerio.ToUpper(),
                    updateTransaction.NewStatus,
                    ResultPost.IdMineradora.ToUpper()
        ); 
        await Db_.SaveChangesAsync();
     return StatusCode(201); 
     
    
    } 
    }
}