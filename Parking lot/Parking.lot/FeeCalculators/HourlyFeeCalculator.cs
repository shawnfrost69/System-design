namespace Parking.lot.FeeCalculators;

public class HourlyFeeCalculator : IFeeCalculatorStrategy
{
    private decimal hourlyRate;
    public HourlyFeeCalculator(decimal rate)
    {
        hourlyRate = rate;
    }

    public decimal CalculateFee(TimeSpan duration)
    {
        return (decimal)duration.TotalHours * hourlyRate;
    }
}