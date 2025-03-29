
using BrinquedosApi.Data;
using BrinquedosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrinquedosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BrinquedosController : ControllerBase
{
    private readonly AppDbContext _context;
    public BrinquedosController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Brinquedos.ToListAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var brinquedo = await _context.Brinquedos.FindAsync(id);
        if (brinquedo == null) return NotFound();
        return Ok(brinquedo);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Brinquedo b)
    {
        _context.Brinquedos.Add(b);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = b.Id_brinquedo }, b);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Brinquedo b)
    {
        if (id != b.Id_brinquedo) return BadRequest();
        _context.Entry(b).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var b = await _context.Brinquedos.FindAsync(id);
        if (b == null) return NotFound();
        _context.Brinquedos.Remove(b);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
