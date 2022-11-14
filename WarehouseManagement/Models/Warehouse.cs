namespace WarehouseManagement.Models;

public class Warehouse
{
    public List<Product> Products {get;  set;}

    public Warehouse()
    {
        Products = new List<Product>();
    }

    
    // productis registracia
    // scvadsxva validaciebi
    public void add(
        string name, 
        string category,
        decimal price,
        double quantity)
    {
        ValidateName(name);
        
        var product = new Product(
            name,
            category,
            price,
            quantity);
        Products.Add(product);

    }

    private void ValidateName(string name)
    {
        var exist = Products.Any(p => p.Name == name);
        if (exist)
        {
            throw new ArgumentException();
        }
    }

    public void Update(
        string name,
        string category,
        decimal price,
        double quantity 
    )
    {
        var product = FindByName(name);
        if (product == null)
        {
            return;
        }

        product.Price = price;
        product.Quantity = quantity;
    }
    
    //washla 
    public void Delete(string name)
    {
        var product = FindByName(name);
        if (product == null)
        {
            return;
        }

        Products.Remove(product);
    }

    public void showAll()
    {
        foreach (var product in Products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    private Product? FindByName( string name)
    {
        var product =  Products.FirstOrDefault(product => product.Name.ToLower() == name.ToLower());
        return product;
    }
}