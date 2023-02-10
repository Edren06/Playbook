namespace RugbyManagement.Framework.ViewModels
{
    public class TeamVm : _BaseVm
    {
        public List<ListTeamsResult> GetTeamList(int? stadiumId)
        {
            return DataContext.DatabaseObjects.ListTeams(stadiumId).ToList();
        }

        public GetTeamResult GetTeam(int teamId)
        {
            return DataContext.DatabaseObjects.GetTeam(teamId).SingleOrDefault();
        }

        public void UpsertTeam(GetTeamResult team)
        {
            DataContext.DatabaseObjects.UpsertTeam(team);
        }
    }
}
