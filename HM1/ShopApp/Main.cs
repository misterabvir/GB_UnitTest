/*
  1. Напишите тесты, чтобы проверить, что магазин хранит верный список продуктов 
    (правильное количество продуктов, верное содержимое корзины).
  2. Напишите тесты для проверки корректности работы метода getMostExpensiveProduct.
  3. Напишите тесты для проверки корректности работы метода sortProductsByPrice (проверьте правильность сортировки).
  */

using ShopApp.Extensions;
using ShopApp.Models;
using System.Diagnostics;

int count = 100;

Shop shop = new Shop();
Debug.Assert(shop != null, "ERROR: object shop was not created");
Debug.Assert(shop.Count == 0, "ERROR: Count of products is not zero");
Debug.Assert(shop.GetMostExpenciveProduct() == null, "ERROR: Impossible return, shop must be empty");
Debug.Assert(shop.GetMaxPrice() == null, "ERROR: Impossible return, shop must be empty");


shop.FillShop(count);
Debug.Assert(count == shop.Count, "ERROR: Count of products in shop not equal input parameter");
Debug.Assert(shop.GetMostExpenciveProduct() != null, "ERROR: Impossible return, shop can't be empty");
Debug.Assert(shop.GetMaxPrice() != null, "ERROR: Impossible return, price can't be null");

int maxPrice = shop.GetMaxPrice()!.Value;
Debug.Assert(maxPrice == shop.GetMostExpenciveProduct()!.Price, "ERROR: actual price must be equal maxPrice");

List<Product> products = shop.GetSortedListByPrice();
Debug.Assert(count == products.Count, "ERROR: Count of products in sorted products not equal input parameter");
Debug.Assert(shop.Count == products.Count, "ERROR: Count of products in shop not equal sorted list of products");
for (int i = 0; i < shop.Count - 1; i++)
{
    Debug.Assert(products[i].Price <= products[i+1].Price, "ERROR: products not sorted by price");
}

Console.WriteLine("All asserts are true");

/*
    OUTPUT if allright
    All asserts are true
    ...\ShopApp\bin\Debug\net7.0\ShopApp.exe exited with code 0.

    OUTPUT if something fail, 
    for example in 16 line: Debug.Assert(shop.Count == 6, "ERROR: Count of products is not zero");    
    
    Process terminated. Assertion failed.
    ERROR: Count of products is not zero
        at Program.<Main>$(String[] args) in ...\ShopApp\Main.cs:line 16
    ...\ShopApp\bin\Debug\net7.0\ShopApp.exe exited with code -2146232797.
 */