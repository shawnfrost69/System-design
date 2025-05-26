using DefaultNamespace;

public class ParkingTicket
{
    public string TicketNumber { get; set; }
    public Vehicle Vehicle { get; set; }
    public DateTime EntryTime { get; set; }
    public DateTime? ExitTime { get; set; }
    public bool Paid { get; set; }

    public ParkingTicket(string number, Vehicle vehicle, DateTime entryTime)
    {
        TicketNumber = number;
        Vehicle = vehicle;
        EntryTime = entryTime;
    }
}