using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public static class NotificationFactory
    {
        public static INotification Create(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
