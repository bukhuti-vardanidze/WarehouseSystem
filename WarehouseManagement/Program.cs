using WarehouseManagement.Models;

Console.WriteLine("hello");
var warehouse= new Warehouse();
warehouse.add("product1", "category 1", 12.35M,5);
Console.WriteLine(warehouse.Products);