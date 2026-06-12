using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class NotificationFactory
    {
        public INotification CreateNotification(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email:
                    return new EmailNotification();

                case NotificationType.Sms:
                    return new SmsNotification();

                case NotificationType.WhatsApp:
                    return new WhatsAppNotification();

                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
