using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class EmailDelivery : ISendingChannel
    {
        public void Send(string content)
        {
            Console.WriteLine($"[Email] Dispatching email with text: {content}");
        }
    }
}
