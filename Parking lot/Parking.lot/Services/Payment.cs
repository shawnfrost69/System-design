using DefaultNamespace;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; }
    public PaymentMode Mode { get; set; }
    public DateTime Time { get; set; }

    public Payment(decimal amount, PaymentMode mode)
    {
        Amount = amount;
        Mode = mode;
        Time = DateTime.Now;
        Status = PaymentStatus.Pending;
    }

    public bool ProcessPayment()
    {
        // Simulate payment success
        Status = PaymentStatus.Completed;
        return true;
    }
}