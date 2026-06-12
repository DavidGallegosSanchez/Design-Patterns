using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class SmsNotification : INotification
    {    

        void INotification.Send(string message, string recipient)
        {
            Console.WriteLine($"Sending Sms to [{recipient}]: {message}");
        }
    }
}
