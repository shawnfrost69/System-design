namespace DefaultNamespace;

public class ParkingLot
{
    public List<ParkingFloor> Floors { get; set; }

    public ParkingLot()
    {
        Floors = new List<ParkingFloor>();
    }

    public void AddFloor(ParkingFloor floor)
    {
        Floors.Add(floor);
    }
}