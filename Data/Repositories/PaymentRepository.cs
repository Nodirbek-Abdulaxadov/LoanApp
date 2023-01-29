using Data.Interfaces;
using Entities;

namespace Data.Repositories;
public class PaymentRepository : BaseRepository<Payment>, IPaymentInterface
{
    public PaymentRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}