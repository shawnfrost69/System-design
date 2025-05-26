namespace DefaultNamespace;

public class ParkingSpot
{
    public int SpotNumber { get; set; }
    public SpotType SpotType { get; set; }
    public bool IsFree { get; set; }
    public Vehicle Vehicle { get; set; }
    public int FloorNumber { get; set; }

    public ParkingSpot(int spotNumber, SpotType spotType, int floorNumber)
    {
        SpotNumber = spotNumber;
        SpotType = spotType;
        FloorNumber = floorNumber;  
    }
}