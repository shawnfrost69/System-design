namespace Parking.lot.FeeCalculators;

public class FlatFeeCalculator : IFeeCalculatorStrategy
{
    private decimal flateRate;

    public FlatFeeCalculator(decimal rate)
    {
        flateRate = rate;
    }

    public decimal CalculateFee(TimeSpan duration)
    {
        return flateRate;
    }
}