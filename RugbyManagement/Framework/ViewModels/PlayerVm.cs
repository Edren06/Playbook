using RugbyManagement.Framework.DbConnector;

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

        public void UpsertPlayer(GetPlayerResult player)
        {
            DataContext.DatabaseObjects.UpsertPlayer(player);
        }
    }
}
