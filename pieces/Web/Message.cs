using System;

namespace EstaWebSeAutodestruira
{
    public class Message
    {
        public int SecondsUntilDestruction { get; set; }
        public DateTime Date { get; set; }

        public string Text { get; set; }
    }
}
