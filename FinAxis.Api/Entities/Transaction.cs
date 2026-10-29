using FinAxis.Api.Enums;

namespace FinAxis.Api.Entities;

public class Transaction
{
    public int FromId { get; set; }
    public int ToId { get; set; }
    public double Amount { get; set; }
    public Currency Currency { get; set; }
    public TransactionStatus TransactionStatus { get; } = TransactionStatus.Pending;
    public DateTime AppliedAt { get; } = DateTime.UtcNow;
}