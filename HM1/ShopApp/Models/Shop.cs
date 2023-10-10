namespace ShopApp.Models;

/// <summary>Class Shop</summary>
internal class Shop
{
    /// <summary>List of products</summary>
    public List<Product> Products { get; set; } = new();

    /// <summary>Count of products</summary>
    public int Count => Products.Count;

    /// <summary>Sorted list of products by price</summary>
    public List<Product> GetSortedListByPrice() 
        => Products.OrderBy(product => product.Price).ToList();

    /// <summary>
    /// Most expensive product
    /// if the list is empty, returns 'null'
    /// </summary>
    public Product? GetMostExpenciveProduct()
        => GetSortedListByPrice().LastOrDefault();
}
