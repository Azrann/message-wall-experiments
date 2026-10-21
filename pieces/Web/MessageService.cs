using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstaWebSeAutodestruira
{
    public class MessageService
    {
        public DateTime LastUpdate = DateTime.UtcNow;
        public static List<Message> data = new List<Message>() { new Message()
        {
            Date = DateTime.UtcNow,
            Text = "Hola web."
        }};

        public Message GetRandom()
        {
            Random rnd = new Random();
            return data[rnd.Next(data.Count)];
        }

        public void Add(string encodedMessage)
        {
            data.Add(new Message()
            {
                Date = DateTime.UtcNow,
                Text = encodedMessage
            });
            LastUpdate = DateTime.UtcNow;
        }
    }
}
