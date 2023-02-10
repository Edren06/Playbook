using RugbyManagement.Framework.DbConnector;
using RugbyManagement.Framework.Models;

namespace RugbyManagement.Framework.ViewModels
{
    public class PlayerVm : _BaseVm
    {
        public List<ListPlayersResult> GetPlayerList(int? teamId, int? stadiumId)
        {
            return DataContext.DatabaseObjects.ListPlayers(teamId, stadiumId).ToList();
        }

        public GetPlayerResult GetPlayer(int playerId)
        {
            return DataContext.DatabaseObjects.GetPlayer(playerId).SingleOrDefault();
        }

        public void UpsertPlayer(PlayerPostModel player)
        {
            DataContext.DatabaseObjects.UpsertPlayer(player);
        }
    }
}
