using Data.Interfaces;

namespace Data.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;

    public UnitOfWork( ILoanInterface loanInterface,
                       IPaymentInterface paymentInterface,
                       IUserInterface userInterface,
                       AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        Loans = loanInterface;
        Payments = paymentInterface;
        Users = userInterface;
    }
    public ILoanInterface Loans { get; }

    public IPaymentInterface Payments { get; }

    public IUserInterface Users { get; }

    public void Dispose()
            => GC.SuppressFinalize(this);
    public async Task SaveAsync()
        => await dbContext.SaveChangesAsync();
}