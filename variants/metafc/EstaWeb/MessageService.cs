using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace EstaWebSeAutodestruira
{
    public class MessageService
    {
        public DateTime LastUpdate = DateTime.UtcNow;
        public static Dictionary<Guid,Message> data = new Dictionary<Guid, Message>() {};

        public MessageService()
        {
            Initialize(data);
        }

        private void Initialize(Dictionary<Guid, Message> dictionary)
        {
            if (File.Exists("InitialConfig.txt"))
            {
                string intialText = File.ReadAllText("InitialConfig.txt");
                if (!string.IsNullOrEmpty(intialText))
                {
                    var dataFromFile = JsonConvert.DeserializeObject<List<Message>>(Regex.Unescape(intialText));
                    data = dataFromFile.ToDictionary(x => x.Id, x => x);
                }
            }

            if (data.Count == 0)
            {
                var id = Guid.NewGuid();
                data.Add(id, new Message()
                {
                    Id = id,
                    Text = "Pole",
                    Date = DateTime.Now,
                });
                id = Guid.NewGuid();
                data.Add(id, new Message()
                {
                    Id = id,
                    Text = "Hay alguien por aqui?",
                    Date = DateTime.Now,
                });
            }
        }

        public MessageDto GetRandomDto()
        {
            Random rnd = new Random();
            var position = rnd.Next(data.Count);
            var message = data.ElementAt(position).Value;
            var seconds = (long) (LastUpdate.AddDays(1) - DateTime.UtcNow).TotalSeconds;
            return new MessageDto()
            {
                Id = message.Id,
                Text = message.Text,
                SecondsUntilDestruction = seconds > 0 ? seconds : 0
            };
        }

        public List<Message> GetAllMessages()
        {
            return data.Values.OrderByDescending(x => x.Date).ToList();
        }

        public void Delete(Guid id)
        {
            data.Remove(id);
        }

        public long GetTtl()
        {
            var seconds = (long)(LastUpdate.AddDays(1) - DateTime.UtcNow).TotalSeconds;
            return seconds > 0 ? seconds : 0;
        }

        public void Add(string encodedMessage)
        {
            if (encodedMessage != "Querida web, \n")
            {
                Guid id = Guid.NewGuid();
                data.Add(id, new Message()
                {
                    Id = id,
                    Date = DateTime.UtcNow,
                    Text = encodedMessage,
                    Likes = 0
                });
            }
            LastUpdate = DateTime.UtcNow;
        }

        public void Like(string id)
        {
            Guid myId = new Guid(id);
            if (data.ContainsKey(myId))
            {
                var newMessage = data[myId];
                newMessage.Likes++;
                data[myId] = newMessage;
            }
        }

        public string GetAll()
        {
            return JsonConvert.SerializeObject(data.Select(x => x.Value));
        }

        public MessageDto GetMessage(string id)
        {
            Guid myId = new Guid(id);
            var message = data[myId];
            var seconds = (long)(LastUpdate.AddDays(1) - DateTime.UtcNow).TotalSeconds;
            return new MessageDto()
            {
                Id = message.Id,
                Text = message.Text,
                SecondsUntilDestruction = seconds > 0 ? seconds : 0
            };
        }
    }
}
