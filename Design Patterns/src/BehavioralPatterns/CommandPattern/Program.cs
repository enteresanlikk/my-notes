using CommandPattern.CommandControllers;
using CommandPattern.Models;
using CommandPattern.StockCommands;

StockManager stockManager = new("Samsung Galaxy S23 Ultra", 200);

BuyStockCommand buyStock = new(stockManager);
SellStockCommand sellStockCommand = new(stockManager);

StockController stockController = new();

stockController.TakeOrder(buyStock);
stockController.TakeOrder(sellStockCommand);
stockController.TakeOrder(sellStockCommand);

stockController.PlaceOrders();

Console.ReadLine();