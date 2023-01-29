namespace Data.Interfaces;
public interface IUnitOfWork : IDisposable
{
    ILoanInterface Loans { get; }
    IPaymentInterface Payments { get; }
    IUserInterface Users { get; }

    Task SaveAsync();
}