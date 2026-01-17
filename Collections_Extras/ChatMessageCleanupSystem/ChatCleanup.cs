    /*
    Chat Message Cleanup System
Problem Statement
Implement message cleanup logic.
Use:
● Dictionary<string, LinkedList<Message>>
Tasks
1. Delete messages:
○ Older than 30 days
○ Read and not starred
2. Fetch last N valid messages efficiently.
Edge Cases
● Deleting while traversing LinkedList
● Message exactly 30 days old
● All messages deleted
● Maintaining message order
● Null message references
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.ChatMessageCleanupSystem
{
    public class ChatCleanup
    {
        private Dictionary<string, LinkedList<Message>> messages;

        public ChatCleanup(Dictionary<string, LinkedList<Message>> msgs)
        {
            messages = msgs;
        }
        // Delete messages older than 30 days AND read and not starred
        public void Delete()
        {
            DateTime today = DateTime.Now;
            foreach (var user in messages)
            {
                LinkedList<Message> msgs = user.Value;
                var curr = msgs.First;
                while (curr != null)
                {
                    var next = curr.Next;
                    Message msg = curr.Value;
                    if (msg != null)
                    {
                        if ((today - msg.date).Days > 30 && msg.isRead && !msg.isStarred)
                        {
                            msgs.Remove(curr);
                        }
                    }
                    curr = next;
                }
            }
        }

        // Fetch last N valid messages
        public List<Message> GetLastMessages(string user, int n)
        {
            List<Message> ans = new List<Message>();
            LinkedList<Message> ll = messages[user];
            var curr = ll.Last;
            while(curr!=null && ans.Count < n)
            {
                if (curr.Value != null)
                {
                    ans.Add(curr.Value);
                }
                curr = curr.Previous;
            }
            return ans;
        }

    }
}