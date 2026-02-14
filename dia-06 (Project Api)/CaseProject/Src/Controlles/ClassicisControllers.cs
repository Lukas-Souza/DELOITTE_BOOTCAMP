using DTOs;
using DTOs.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;
using Models;
using Services;
namespace CaseProject.Controlles
{
    [ApiController]
    [Route("/lot-minerio/classification/")]
    public class ExtraControllers: ControllerBase
    {
    ServicesLotMinerio servicesLotMinerio = new ServicesLotMinerio();
    
    private readonly AppDbContext Db_;
    public ExtraControllers(AppDbContext db) => Db_ = db;

    [HttpGet]
    // http://localhost:5167/lot-minerio/transaction/history
    public async Task<IActionResult> GetHistoryTransction()
    {
    List<LotMinerio> DatResult = await Db_.LotesMinerio.ToListAsync();
    return Ok(servicesLotMinerio.ClassificarPorQualidade(DatResult));
    }


    [HttpGet("{id}")]
    // http://localhost:5167/lot-minerio/transaction/history/{id}
    public async Task<IActionResult> GetHistoryTransctionById(int id)
    {
    LotMinerio DatResult = await Db_.LotesMinerio.FindAsync(id);
    List<LotMinerio> lotMinerios = new List<LotMinerio>{DatResult};
    return Ok(servicesLotMinerio.ClassificarPorQualidade(lotMinerios));
    }
  }
}