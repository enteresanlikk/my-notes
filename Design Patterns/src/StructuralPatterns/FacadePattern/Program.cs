using FacadePattern.Facades;
using FacadePattern.Models;

Customer customer1 = new(1, "Bilal", "Demir");
Customer customer2 = new(2, "Ayşe", "Telli");

CreditCardFacade creditCardFacade = new();
creditCardFacade.CreateCreditCart(customer1);
creditCardFacade.CreateCreditCart(customer2);

Console.ReadLine();