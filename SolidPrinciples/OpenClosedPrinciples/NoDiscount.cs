namespace SolidPrinciples.OpenClosedPrinciples;

public class NoDiscount : DiscountStrategy
{
    public override double CalculateDiscount(Product product)
    {
        return 0;  // No discount for other products
    }
}
