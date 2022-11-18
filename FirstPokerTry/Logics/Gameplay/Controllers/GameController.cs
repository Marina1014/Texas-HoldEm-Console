#nullable disable
/*
using FirstPokerTry.Logics.CardFactory.Classes;
using FirstPokerTry.Logics.CardFactory.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstPokerTry.Logics.Gameplay.Controllers;

[ApiController]
[Route("api/[controller]")]

public class GameController : ControllerBase
{
    private readonly GameRecordContext _context;

    public GameController(GameRecordContext context)
    {
        _context = context;
    }

    // GET: api/Game
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Game>>> Get()
    {
        var games = await _context.Games.ToListAsync();
        return games != null ? Ok(games) : NotFound();
    }

    // GET: api/Game/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> Get(int id)
    {
        var game = await _context.Games.FindAsync(id);
        return game != null ? Ok(game) : NotFound();
    }

    // PUT: api/Game/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Game game)
    {
        if (id != game.Id)
        {
            return BadRequest($"Game with id {id} not found");
        }

        var gameToUpdate = await _context.Games.FindAsync(id);
        if (gameToUpdate == null)
        {
            return NotFound();
        }

        gameToUpdate.Pot = game.Pot;
        gameToUpdate.Winner = game.Winner;

        _context.Entry(game).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = game.Id }, game);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GameExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
    }

    // POST: api/Game
    [HttpPost]
    public async Task<ActionResult<Game>> Post(Game game)
    {
        if (game == null)
        {
            return BadRequest();
        }

        var gameToCreate = new Game
        {
            Pot = game.Pot,
            Winner = game.Winner
        };

        try
        {
            _context.Games.Add(gameToCreate);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = gameToCreate.Id }, gameToCreate);
        }
        catch (DbUpdateException)
        {
            if (GameExists(gameToCreate.Id))
            {
                return Conflict($"Game with id {gameToCreate.Id} already exists");
            }
            else
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }

    // DELETE: api/Game/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Game>> Delete(int id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game == null)
        {
            return NotFound($"Game with id {id} not found");
        }

        _context.Games.Remove(game);
        await _context.SaveChangesAsync();

        return game;
    }

    private bool GameExists(int id) => _context.Games.Any(e => e.Id == id);

}*/