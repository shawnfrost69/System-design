namespace DefaultNamespace;

public class ParkingFloor
{
    public int FloorNumber { get; set; }
    public List<ParkingSpot> Spots { get; set; }

    public ParkingFloor(int floorNumber)
    {
        FloorNumber = floorNumber;
        Spots = new List<ParkingSpot>();
    }
}