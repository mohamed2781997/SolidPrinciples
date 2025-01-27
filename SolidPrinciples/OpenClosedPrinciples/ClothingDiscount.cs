namespace SolidPrinciples.OpenClosedPrinciples;

public class ClothingDiscount : DiscountStrategy
{
    public override double CalculateDiscount(Product product)
    {
        return product.Price * 0.15;  // 15% discount for Clothing
    }
}
