using Data.Interfaces;
using Entities;

namespace Data.Repositories;
public class LoanRepository : BaseRepository<Loan>, ILoanInterface
{
    public LoanRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}