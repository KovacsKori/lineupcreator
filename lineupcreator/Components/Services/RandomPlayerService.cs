using lineupcreator.Components.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lineupcreator.Components.Services
{
    public class RandomPlayerService
    {
        private readonly FootballDbContext _context;

        public RandomPlayerService(FootballDbContext context)
        {
            _context = context;
        }

        public Player GetRandomPlayer()
        {
            var randomPlayer = _context.Players
                .Where(p => p.overall > 78 && (p.league_name.Contains("Premier League") || p.league_name.Contains("Ligue 1") || p.league_name.Contains("Bundesliga") || p.league_name.Contains("Serie A") || p.league_name.Contains("Primera Division")))
                .OrderBy(p => Guid.NewGuid()) // Shuffle the players
                .FirstOrDefault();

            return randomPlayer!;
        }

        public List<Player> SearchPlayers(string searchText)
        {
            return _context.Players
                .Where(p => p.long_name.ToLower().Contains(searchText.ToLower())).OrderByDescending(p=>p.overall)
                .Take(10) // Limit the number of search results
                .ToList();
        }
    }
}
