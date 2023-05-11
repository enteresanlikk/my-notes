using StrategyPattern.Models;
using StrategyPattern.CombatStrategies;
using StrategyPattern.Abstractions;
using StrategyPattern.PaymentServices;

//Ex 1
Character character = new(new DefensiveCombatStrategy());
character.ApplyStrategy();

Task.Delay(2000).GetAwaiter().GetResult();

character.SetCombatStrategy(new AggressiveCombatStrategy());
character.ApplyStrategy();

Task.Delay(2000).GetAwaiter().GetResult();

character.SetCombatStrategy(new DefensiveCombatStrategy());
character.ApplyStrategy();

Console.WriteLine("--------------------------------------------------");

//Ex 2
Payment payment = new("1234567891011213", "Bilal Demir", 24, 12, "111", 150);

var paymentService = new PaymentService();

do
{
    Console.Write("Ödeme yapılacak bankayı seçiniz (1: Halkbank, 2: Yapı Kredi, 3: Vakıfbank): ");
    var bank = Console.ReadLine();

    IPaymentServiceStrategy paymentServiceStrategy = null;

    switch (bank)
    {
        case "1":
            paymentServiceStrategy = new HalkbankPaymentService();
            break;
        case "2":
            paymentServiceStrategy = new YapikrediPaymentService();
            break;
        case "3":
            paymentServiceStrategy = new VakifbankPaymentService();
            break;
        default:
            Console.WriteLine("Geçersiz banka seçimi.");
            break;
    }
    
    if(paymentServiceStrategy is not null)
    {
        paymentService.SetPaymentService(paymentServiceStrategy);
        paymentService.Pay(payment);
    }

} while (Console.ReadKey().Key != ConsoleKey.Escape);

Console.ReadLine();