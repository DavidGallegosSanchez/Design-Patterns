using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class UrgentMessage : Message
    {
        public UrgentMessage(ISendingChannel sendingChannel) : base(sendingChannel) { }

        public override void ProcessAndSend(string text)
        {
            // Specific logic for an urgent message
            string formattedText = $"[URGENT ALERT!] >>> {text.ToUpper()} <<<";
            _sendingChannel.Send(formattedText);
        }
    }
}
