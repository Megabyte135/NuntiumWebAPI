using Domain.Common;

namespace Infrastructure.Repositories
{
    public class ArticleRepository : IRepository
    {
        private readonly NuntiumDbContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public ArticleRepository(NuntiumDbContext context)
        {
            _context = context;
        }
    }
}
