using DataService.Entities;
using System.Threading.Tasks;

namespace DataService.Repositories
{
    public interface IDataRepository
    {
        public Task<object> GetPlayerListAsync();
        public Task<Player> GetPlayerAsync(int playerId);
        public Task<Rusher> GetPlayerRushingStatsAsync(int playerId);
        public Task<Passer> GetPlayerPassingStatsAsync(int playerId);
        public Task<Receiver> GetPlayerReceivingStatsAsync(int playerId);
        public Task<object> GetPasserComparisonStatsAsync(int[] playerIds);
        public Task<PlayerInfo> GetLionInfoAsync(int playerId);
    }
}
