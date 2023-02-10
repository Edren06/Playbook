using RugbyManagement.Framework.DbConnector;

namespace RugbyManagement.Framework.ViewModels
{
    public class _BaseVm
    {
        public SqlDataContext DataContext = new SqlDataContext();
    }
}
