using DesignPatterns.Creational;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Builder
            Console.WriteLine("*** Builder pattern ***");

            // 1. Build a large vegetarian pizza with thin crust
            Pizza pizzaVeggie = new PizzaBuilder()
                .WithSize("Grande")
                .WithDough("Fina")
                .AddCheese()
                .AddMushtooms()
                .Build();

            // 2. Build a standard meat lovers pizza (uses default values)
            Pizza pizzaCarnivora = new PizzaBuilder()
                .AddCheese()
                .AddPepperoni()
                .Build();

            Console.WriteLine(pizzaVeggie.Describe());

            Console.WriteLine(pizzaCarnivora.Describe());

            
            // Factory
            Console.WriteLine("\n*** Factory pattern ***");
            NotificationFactory factory = new NotificationFactory();
            INotification emailNotifier = factory.CreateNotification(NotificationType.Email);
            emailNotifier.Send("Welcome to the platform!", "user@mail.com");

            INotification smsNotifier = factory.CreateNotification(NotificationType.Sms);
            smsNotifier.Send("Verification Code is 4418", "+34654987123");

            
            // Prototype
            Console.WriteLine("\n*** Prototype pattern ***");
            Monster prototype = new Monster("Goblin", "Green", new MonsterStats(100, 25));
            Console.WriteLine("--- Original State ---");
            prototype.DisplayInfo();

            Monster clonSuperficial = prototype.Clone();
            clonSuperficial.Name = "Clon Goblin superficial";
            clonSuperficial.Stats.Health = 50;
            Console.WriteLine("\n--- After modify Clon Superficial ---");
            prototype.DisplayInfo();      // ¡Health changed to 50! 
            clonSuperficial.DisplayInfo();

            // Back to the original health
            prototype.Stats.Health = 100;

            // 3. Deep Copy
            Monster deepClone = prototype.DeepClone();
            deepClone.Name = "Goblin Deep Clon";
            deepClone.Color = "Red";

            // Do not change original prototype.
            deepClone.Stats.Health = 999;

            Console.WriteLine("\n--- After modifying Deep Clone ---");
            prototype.DisplayInfo();      // keep 100 original Health
            deepClone.DisplayInfo();     // Have the new 999 Health

            
            // Singleton
            Console.WriteLine("\n*** Singleton pattern ***");
            Console.WriteLine("--- Init application ---");

            // Request the service for the first time (the internal constructor is executed)
            LogManager logger1 = LogManager.Instance;
            logger1.WriteLog("The user has logged in.");

            // Request the service elsewhere in the code for the second time
            LogManager logger2 = LogManager.Instance;
            logger2.WriteLog("The home screen has loaded.");

            // Verify if they actually point to the same object in memory
            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("\n logger1 and logger2 are exactly the same instance.");
            }

            // Adapter
            Console.WriteLine("\n*** Adapter pattern ***");
            // 1. Create an instance of the external service
            PayPalService legacyPaypal = new PayPalService();

            // 2. Wrap it in our adapter
            IOrderProcessor proccesor = new PayPalAdapter(legacyPaypal);

            // 3. The application can use it transparently
            Console.WriteLine("Init process of order...");
            proccesor.ProcessPayment("ORD-2026-99", 150.50m);
        }
    }
}
