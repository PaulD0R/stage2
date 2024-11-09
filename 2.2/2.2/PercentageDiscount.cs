namespace _2._2;

public class PercentageDiscount(int percent) : Discount
{
    private int _percent = percent;

    public override double Calculate(double price)
    {
        return price * (100 - _percent) / 100;
    }
}