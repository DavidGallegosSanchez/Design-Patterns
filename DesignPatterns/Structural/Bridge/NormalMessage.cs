using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class NormalMessage : Message
    {
        public NormalMessage(ISendingChannel sendingChannel) : base(sendingChannel)
        {
           
        }

        public override void ProcessAndSend(string text)
        {
            // Specific logic for a normal message
            string formattedText = $"[NOTIFICATION] {text}";
            _sendingChannel.Send(formattedText);
        }
    }
}
