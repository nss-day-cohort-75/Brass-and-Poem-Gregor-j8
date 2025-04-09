
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>() {
      new Product() 
    { 
        Name = "The Raven",
        Price = 15.00M,
        ProductTypeId = 2
    },
      new Product() 
    { 
        Name = "The Road Not Taken",
        Price = 10.00M,
        ProductTypeId = 1
    },
      new Product() 
    { 
        Name = "Ode to a Nightingale",
        Price = 1.00M,
        ProductTypeId = 2
    },
      new Product() 
    { 
        Name = "Still I Rise",
        Price = 7.00M,
        ProductTypeId = 1
    },
      new Product() 
    { 
        Name = "Daffodils",
        Price = 2.00M,
        ProductTypeId = 1
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>(){
        new ProductType() 
    { 
        Title = "brass",
        Id = 1,
    },
        new ProductType() 
    { 
        Title = "Peom",
        Id = 2,
    },
};


//put your greeting here
Console.WriteLine("Welcome to the Brass and Poem!");
bool loop = true;
//implement your loop here
while (loop == true)
{
Console.WriteLine("Please select an option from the menu below:");
Console.WriteLine(@"
1. Display Menu
2. Display all products
3. Delete a product
4. Add a product
5. Update a product
6. Exit");

    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            DisplayMenu();
            break;
        case "2":
            DisplayAllProducts(products, productTypes);
            break;
        case "3":
            DeleteProduct(products, productTypes);
            break;
        case "4":
            AddProduct(products, productTypes);
            break;
        case "5":
            UpdateProduct(products, productTypes);
            break;
        case "6":
            loop = false;
            break;
        default:
            Console.WriteLine("Please select a valid option.");
            break;
    }
}

void DisplayMenu()
{
Console.WriteLine("Please select an option from the menu below:");
Console.WriteLine(@"
1. Display all products
2. Delete a product
3. Add a product
4. Update a product
5. Exit");

    string userChoice = Console.ReadLine();
    switch (userChoice)
    {

        case "1":
            DisplayAllProducts(products, productTypes);
            break;
        case "2":
            DeleteProduct(products, productTypes);
            break;
        case "3":
            AddProduct(products, productTypes);
            break;
        case "4":
            UpdateProduct(products, productTypes);
            break;
        case "5":
            loop = false;
            break;
        default:
            Console.WriteLine("Please select a valid option.");
            break;
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
        foreach(Product product in products) {
        Console.WriteLine($"{product.Name} {product.Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    foreach(Product product in products) {
    Console.WriteLine($"{product.Name}");
    }
    string ChoosenDelete = Console.ReadLine().Trim();
    Product productToDelete = null;

    productToDelete = products.FirstOrDefault(product => product.Name == ChoosenDelete);
    
    if (productToDelete != null) {
        products.Remove(productToDelete);
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }