namespace RugbyManagement.Framework.ViewModels
{
    public class PlayerTransferVm : _BaseVm
    {
        public List<ListTransferHistoryResult> GetTeamTransferList(int? playerId, int? teamId, int? stadiumId)
        {
            return DataContext.DatabaseObjects.ListTransferHistory(playerId, teamId, stadiumId).ToList();
        }
    }
}
