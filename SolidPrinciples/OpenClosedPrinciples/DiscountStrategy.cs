using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciples;
public abstract class DiscountStrategy
{
    public abstract double CalculateDiscount(Product product);

}
