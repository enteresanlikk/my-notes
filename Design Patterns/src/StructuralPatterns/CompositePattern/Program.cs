using CompositePattern.Models;

ProductCatalog items = new("All Products");
    ProductCatalog phones = new("Phones");
        ProductCatalog apple = new("Apple");
            ProductCatalog iphone = new("iPhone");
                Product iphoneItem = new("iPhone 14 Pro Max");
        ProductCatalog samsung = new("Samsung");
            ProductCatalog galaxy = new("Samsung Galaxy");
                Product samsungItem = new("Samsung Galaxy S23 Ultra");
    ProductCatalog tablets = new("Tablets");

items.Add(phones);
    phones.Add(apple);
        apple.Add(iphone);
            iphone.Add(iphoneItem);
    phones.Add(samsung);
        samsung.Add(galaxy);
            galaxy.Add(samsungItem);
items.Add(tablets);

items.DrawHierarchy();

Console.ReadLine();