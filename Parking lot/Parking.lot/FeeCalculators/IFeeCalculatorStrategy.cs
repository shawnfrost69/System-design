namespace Parking.lot.FeeCalculators;

public interface IFeeCalculatorStrategy
{
    decimal CalculateFee(TimeSpan duration);
}