using DefaultNamespace;
using Parking.lot.FeeCalculators;

public class Exit
{
    private ParkingRateCalculator calculator;

    public Exit(ParkingRateCalculator calc)
    {
        calculator = calc;
    }

    public decimal ProcessExit(ParkingTicket ticket, PaymentMode paymentMode)
    {
        ticket.ExitTime = DateTime.Now;
        TimeSpan duration = ticket.ExitTime.Value - ticket.EntryTime;

        decimal fee = calculator.CalculateParkingFee(duration);

        Payment payment = new Payment(fee, paymentMode);
        if (payment.ProcessPayment())
        {
            ticket.Paid = true;
            return fee;
        }

        return 0;
    }
}