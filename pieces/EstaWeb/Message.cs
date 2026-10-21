using System;

namespace EstaWebSeAutodestruira
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public long Likes { get; set; }
    }

    public class MessageDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
