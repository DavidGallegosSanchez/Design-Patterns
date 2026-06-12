using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    // The "Abstraction" (This is where the "Bridge" happens)
    public abstract class Message
    {
        protected ISendingChannel _sendingChannel;

        protected Message(ISendingChannel sendingChannel)
        {
            _sendingChannel = sendingChannel;
        }

        public abstract void ProcessAndSend(string text);
    }

}
