
namespace Online_Marketplace;

public static class DiscountService
{
    public static void ApplyDiscount<TCategory> (Product<TCategory> product, double percentage) where TCategory : Category
    {
        double discountedPrice = product.Price -
            (product.Price * percentage / 100);

        product.UpdatePrice(discountedPrice);
    }
}
