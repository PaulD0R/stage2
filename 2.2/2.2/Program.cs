using _2._2;

PercentageDiscount percentageDiscount = new PercentageDiscount(20);
FixedAmountDiscount fixedAmountDiscount = new FixedAmountDiscount(100);

Console.WriteLine(percentageDiscount.Calculate(300));
Console.WriteLine(fixedAmountDiscount.Calculate(120));