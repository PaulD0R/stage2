namespace _2._2;

public class FixedAmountDiscount : Discount
{
    private double _fixedDiscount;

    public FixedAmountDiscount(double fixedDiscount)
    {
        _fixedDiscount = fixedDiscount;
    }

    public override double Calculate(double price)
    {
        return price - _fixedDiscount;
    }
}