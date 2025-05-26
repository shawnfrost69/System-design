namespace Parking.lot.FeeCalculators;

public class ParkingRateCalculator
{
    private IFeeCalculatorStrategy strategy;

    public ParkingRateCalculator(IFeeCalculatorStrategy strategy)
    {
        this.strategy = strategy;
    }

    public decimal CalculateParkingFee(TimeSpan duration)
    {
        return strategy.CalculateFee(duration);
    }
}