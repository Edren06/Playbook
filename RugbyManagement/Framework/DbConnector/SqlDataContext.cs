namespace RugbyManagement.Framework.DbConnector
{
    public class SqlDataContext
    {
        //This class is used to populate the database objects kind of in an ORM way and connect to the DB.
        public class SqlDataContext
        {
            public DbObjects DatabaseObjects = new DbObjects("");

            public SqlDataContext()
            {
                DatabaseObjects = new DbObjects(ConfigurationHelper.GetSqlConnection());
            }
        }
    }
}
