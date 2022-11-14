#nullable disable

using FirstPokerTry.Logics.CardFactory.Classes;
using FirstPokerTry.Logics.CardFactory.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstPokerTry.Logics.Gameplay.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly GameRecordContext _context;

        public PlayerController(GameRecordContext context)
        {
            _context = context;
        }

        // GET: api/Player
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> Get()
        {
            var players = await _context.Players.ToListAsync();
            return players != null ? Ok(players) : NotFound();
        }

        // GET: api/Player/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> Get(int id)
        {
            var player = await _context.Players.FindAsync(id);
            return player != null ? Ok(player) : NotFound();
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Player player)
        {
            if (id != player.Id)
            {
                return BadRequest($"Player with id {id} not found");
            }

            var playerToUpdate = await _context.Players.FindAsync(id);
            if (playerToUpdate == null)
            {
                return NotFound();
            }

            playerToUpdate.Name = player.Name;

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = player.Id }, player);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
                {
                    return NotFound($"Player with id {id} not found");
                }
                else
                {
                    return StatusCode(500, "Internal server error");
                }
            }
        }

        // POST: api/Player
        [HttpPost]
        public async Task<ActionResult<Player>> Post([FromBody]Player player)
        {
            if (player == null)
            {
                return BadRequest("Player object is null");
            }

            var playerToCreate = new Player
            {
                Name = player.Name
            };

            try
            {
                await _context.Players.AddAsync(playerToCreate);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = playerToCreate.Id }, playerToCreate);
            }
            catch (DbUpdateException)
            {
                if (PlayerExists(playerToCreate.Id))
                {
                    return Conflict($"Player with id {playerToCreate.Id} already exists");
                }
                else
                {
                    return StatusCode(500, "Internal server error");
                }
            }
        }

        // DELETE: api/Player/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Player>> Delete(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound($"Player with id {id} not found");
            }

            try
            {
                _context.Players.Remove(player);
                await _context.SaveChangesAsync();
                return Ok($"Player with id {id} was deleted");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        private bool PlayerExists(int id) => _context.Players.Any(e => e.Id == id);
}
