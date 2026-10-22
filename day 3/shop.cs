public class Shop : Product
{
    List<Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void DeleteProduct(string a)
    {
        products.RemoveAll(x=>x.name==a);
    }
    public void PrintProductList()
    {
        foreach (var item in products)
        {
            System.Console.WriteLine("Tovar: "+item.name+" Price: "+item.price);
        }
    }

    }