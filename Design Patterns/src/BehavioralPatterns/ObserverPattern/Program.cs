using ObserverPattern.Models;
using ObserverPattern.Observers;
using ObserverPattern.Sellers;

Product iphonePhone = new("iPhone 14 Pro Max", 50_000);
Product samsungPhone = new("Samsung Galaxy S23 Ultra", 43_000);

UserObserver bilalUser = new("Bilal");
UserObserver ahmetUser = new("Ahmet");

PeopleObserver peopleObserver = new("Demir");

Amazon amazon = new();

amazon.Register(bilalUser, iphonePhone);
amazon.Register(ahmetUser, samsungPhone);

amazon.Register(peopleObserver, iphonePhone);

//amazon.NotifyAllForProductName("iPhone 14 Pro Max");
amazon.NotifyAll();

Console.ReadLine();