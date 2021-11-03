using System.Linq;
using System.Threading.Tasks;
using Recipes.Repository.Context;
using Recipes.Repository.Domain;

namespace Recipes.Logic.Services
{
    public class AppService : IAppService
    {
        private readonly AppContext _context;
        public AppService(AppContext context)
        {
            _context = context;
        }

        public RecipeDomain GetSingle(long id)
        {
            return _context.Recipes.Where(x => x.id == id).FirstOrDefault();
        }

        public bool CheckTables()
        {
            _context.Database.EnsureCreated();
            return true;
        }
    }
}