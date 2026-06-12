using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SMSDelivery : ISendingChannel
    {
        public void Send(string content)
        {
            Console.WriteLine($"[SMS] Dispaching text message: {content}");
        }
    }
}
