using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.ChatMessageCleanupSystem
{
    //message class
    public class Message
    {
        public string data { get; set; }
        public DateTime date { get; set; }
        public bool isRead { get; set; }
        public bool isStarred { get; set; }

        public Message(string data, DateTime sentDate, bool isRead, bool isStarred)
        {
            this.data = data;
            this.date = sentDate;
            this.isRead = isRead;
            this.isStarred = isStarred;
        }
    }
}