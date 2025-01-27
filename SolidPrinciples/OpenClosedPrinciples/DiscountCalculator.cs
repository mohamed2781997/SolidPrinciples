namespace SolidPrinciples.OpenClosedPrinciples;

public class DiscountCalculator
{
    private readonly DiscountStrategy _discountStrategy;

    public DiscountCalculator(DiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    // حساب الخصم للمنتج بناءً على الاستراتيجية
    public double GetDiscount(Product product)
    {
        return _discountStrategy.CalculateDiscount(product);
    }
}