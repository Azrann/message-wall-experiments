using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace EstaWebSeAutodestruira
{
    public class MessageService
    {
        public static ConcurrentDictionary<Guid,Message> data = new ConcurrentDictionary<Guid, Message>() {};

        public MessageService()
        {
            Initialize(data);
        }

        private void Initialize(ConcurrentDictionary<Guid, Message> dictionary)
        {
            if (data.Count == 0)
            {
                var id = Guid.NewGuid();
                var message1 = new Message()
                {
                    Id = id,
                    Text = "No puede ser verdad",
                    Date = DateTime.Now,
                };
                data.TryAdd(id, message1);
                id = Guid.NewGuid();
                data.TryAdd(id, new Message()
                {
                    Id = id,
                    Text = "Suma y sigue, sigue y suma",
                    Date = DateTime.Now,
                });
                id = Guid.NewGuid();
                data.TryAdd(id, new Message()
                {
                    Id = id,
                    Text = "Experimento 98, 60% COMPLETADO ",
                    Date = DateTime.Now,
                });
            }
        }

        public MessageDto GetRandomDto()
        {
            if (data.Count == 0)
            {
                return new MessageDto()
                {
                    Id = Guid.Empty,
                    Text = Guid.NewGuid().ToString(),
                };
            }

            Random rnd = new Random();
            var position = rnd.Next(data.Count);
            var message = data.ElementAt(position).Value;
            data.Remove(message.Id, out message);
            return new MessageDto()
            {
                Id = message.Id,
                Text = rnd.Next(2,49)+" para bingo",
            };
        }

        public List<Message> GetAllMessages()
        {
            return data.Values.OrderByDescending(x => x.Date).ToList();
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

        public void Delete(Guid guid)
        {
            data.TryRemove(guid, out _);
        }
    }
}
