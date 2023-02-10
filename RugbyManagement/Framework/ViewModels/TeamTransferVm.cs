namespace RugbyManagement.Framework.ViewModels
{
    public class TeamTransferVm : _BaseVm
    {
        public List<ListTransferHistoryResult> GetTeamTransferList(int? playerId, int? teamId, int? stadiumId)
        {
            return DataContext.DatabaseObjects.ListTransferHistory(playerId, teamId, stadiumId).ToList();
        }
    }
}
