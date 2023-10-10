using ShopApp.Models;

namespace ShopApp.Extensions;

internal static class ShopExtensions
{
    /// <summary>
    /// Clear and fill list of products in Shop
    /// </summary>
    /// <param name="shop">object Shop</param>
    /// <param name="count">Count of products</param>
    public static void FillShop(this Shop shop, int count)
    {
        shop.Products.Clear();
        shop.Products = Enumerable
            .Range(1, count)
            .Select(index => new Product()
            {
                Name = $"Product_{index}",
                Price = Random.Shared.Next(500, 1000)
            })
            .ToList();
    }

    public static int? GetMaxPrice(this Shop shop) 
    {
       if (shop.Products.Count == 0) 
            return null;
       return shop.Products.Select(product=>product.Price).Max();
    }
}

