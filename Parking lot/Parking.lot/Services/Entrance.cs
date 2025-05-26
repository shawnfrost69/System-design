using DefaultNamespace;

public class Entrance
{
    public ParkingTicket IssueTicket(Vehicle vehicle)
    {
        string ticketNumber = Guid.NewGuid().ToString();
        return new ParkingTicket(ticketNumber, vehicle, DateTime.Now);
    }
}