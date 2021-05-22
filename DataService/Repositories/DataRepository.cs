using DataService.Entities;
using DataService.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataService.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly FootballExampleContext _context;
        public DataRepository(FootballExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        public async Task<object> GetPasserComparisonStatsAsync(int[] playerIDs)
        {
            var players = await _context.Passers.Where(p => playerIDs.Contains(p.PlayerId)).ToListAsync();
            return players;
        }

        public async Task<object> GetPlayerListAsync()
        {
            var players = await _context.Passers.ToListAsync();
            return players;
        }

        public async Task<Passer> GetPlayerPassingStatsAsync(int playerID)
        {
            var passer = await _context.Passers.FirstOrDefaultAsync(p => p.PlayerId == playerID);
            return passer;
        }

        public async Task<Receiver> GetPlayerReceivingStatsAsync(int playerID)
        {
            var receiver = await _context.Receivers.FirstOrDefaultAsync(p => p.PlayerId == playerID);
            return receiver;
        }

        public async Task<Rusher> GetPlayerRushingStatsAsync(int playerID)
        {
            var rusher = await _context.Rushers.FirstOrDefaultAsync(p => p.PlayerId == playerID);
            return rusher;
        }

        public async Task<PlayerInfo> GetLionInfoAsync(int playerId)
        {
            var lionsPlayerInfo = await _context.PlayerInfos.FirstOrDefaultAsync(p => p.PlayerId == playerId);
            return lionsPlayerInfo;
        }
    }
}
