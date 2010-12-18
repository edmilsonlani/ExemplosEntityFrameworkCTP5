using System.Data.Entity.Database;
using TutorialEntityFrameworkCTP.Infra;

namespace TutorialEntityFrameworkCTP.Console
{
    public class NeverChangeDatabase : IDatabaseInitializer<ContextoEF>
    {
        public void InitializeDatabase(ContextoEF context)
        {

        }
    }
}