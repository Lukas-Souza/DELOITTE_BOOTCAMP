using Microsoft.AspNetCore.Mvc;
using Dtos;
using Microsoft.AspNetCore.Http.Timeouts;
using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Runtime.Intrinsics.Arm;
namespace Controller
{
    [ApiController]
    [Route("equipamentos")]
    public class Controller:ControllerBase
    {
        private readonly AppDbContext Db_;
        public Controller(AppDbContext db) => Db_ = db;
        [HttpGet]
        public async Task<IActionResult> returnAllEquipamnets()
        {
            List<Equipaments> returnAll = await Db_.Equipaments.ToListAsync();
            return Ok(returnAll);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> returnEquipamentsById(int id)
        {
            Equipaments equipaments = await Db_.Equipaments.FindAsync(id);
            if ( equipaments == null) return NotFound();
            return Ok(equipaments);
        }
        [HttpPost]
        public async Task<IActionResult> createEquipaments([FromBody] EquipamentsDto _equipaments)
        {
            try
            {
                Equipaments equipaments = new Equipaments(_equipaments);
                Db_.Equipaments.Add(equipaments);
                await Db_.SaveChangesAsync();
                return StatusCode(201);
            }
            catch (ArgumentException err)
            {

                Console.WriteLine(err);

                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateEquipaments(int id, [FromBody] UpdateEquipamentos _updateEquipamentos)
        {
            var equipament = Db_.Equipaments.Find(id);
            if (equipament == null)
            {
                return NotFound();
            }
            try
            {
                equipament.Update(_updateEquipamentos);
                Db_.SaveChanges();
                return StatusCode(204);
            }
            catch (System.Exception)
            {
                
                return BadRequest();
            }
        }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> removeEquipaments( int id)
        {
             var Elemenet = Db_.Equipaments.Find(id);
            if (Elemenet == null) return NotFound();
            try
            {
                Db_.Remove(Elemenet);
                await Db_.SaveChangesAsync();
                return StatusCode(204);
            }
            catch (ArgumentException err)
            {
                return BadRequest();

            }
        }

}}