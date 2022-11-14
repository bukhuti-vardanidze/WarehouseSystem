namespace WarehouseManagement.Models;

public class Product
{
        
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }

        public Product( 
                        string name, 
                        string category,
                        decimal price,
                        double quantity )
        {
            //Shezgudvebis gaketeba shegvidzlia aq!

            ValidateName(name);
            ValidateCategory(category);
            ValidatePrice(price);
            ValidateQuantity(quantity);
            
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        private void ValidateQuantity(double quantity)
        {
            //...
        }

        private void ValidatePrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException(nameof(price));
            }
        }

        public void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }
        }

        public void ValidateCategory(string category)
        {
          //....
        }

        
        //pasisa da raodneobis cvlileba
        public void Update(decimal price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"name: {Name} category {Category} price : {Price} quantity : {Quantity}";
        }
}