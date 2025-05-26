using DefaultNamespace;
using Parking.lot.FeeCalculators;

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car("CAR-123");
        Vehicle bike = new Bike("BIKE-456");

        Entrance entrance = new Entrance();
        ParkingTicket ticket = entrance.IssueTicket(car);

        // Example fee calculation strategy
        IFeeCalculatorStrategy strategy = new HourlyFeeCalculator(10);
        ParkingRateCalculator calculator = new ParkingRateCalculator(strategy);

        Exit exit = new Exit(calculator);
        decimal fee = exit.ProcessExit(ticket, PaymentMode.Cash);

        Console.WriteLine($"Ticket: {ticket.TicketNumber}, Fee: {fee}, Paid: {ticket.Paid}");
    }
}