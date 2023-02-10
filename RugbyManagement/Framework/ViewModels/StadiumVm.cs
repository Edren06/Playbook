namespace RugbyManagement.Framework.ViewModels
{
    public class StadiumVm : _BaseVm
    {
        public List<ListStadiumsResult> GetStadiumList()
        {
            return DataContext.DatabaseObjects.ListStadiums().ToList();
        }

        public GetStadiumResult GetStadium(int stadiumId)
        {
            return DataContext.DatabaseObjects.GetStadium(stadiumId).SingleOrDefault();
        }

        public void UpsertStadium(GetStadiumResult stadium)
        {
            DataContext.DatabaseObjects.UpsertStadium(stadium);
        }
    }
}
