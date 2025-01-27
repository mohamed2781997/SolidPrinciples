namespace SolidPrinciples.OpenClosedPrinciples;

public class ElectronicsDiscount : DiscountStrategy
{
    public override double CalculateDiscount(Product product)
    {
        return product.Price * 0.10;  // 10% discount for Electronics
    }
}