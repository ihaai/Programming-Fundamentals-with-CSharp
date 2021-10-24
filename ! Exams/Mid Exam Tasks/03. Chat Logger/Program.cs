using System;
using System.Linq;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatList = new List<string>();

            while (true)
            {
                var cmd = Console.ReadLine().Split().ToList();
                if (cmd[0] == "end")
                {
                    break;
                }

                else if (cmd[0] == "Chat")
                {
                    string message = cmd[1];

                    chatList.Add(message);
                }

                else if (cmd[0] == "Delete")
                {
                    string message = cmd[1];

                    if (chatList.Contains(message))
                    {
                        chatList.Remove(message);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (cmd[0] == "Edit")
                {
                    string message = cmd[1];
                    string editedMessage = cmd[2];

                    if (chatList.Contains(message))
                    {
                        chatList[chatList.IndexOf(message)] = editedMessage;
                    }
                }

                else if (cmd[0] == "Pin")
                {
                    string message = cmd[1];

                    if (chatList.Contains(message))
                    {
                        chatList.RemoveAt(chatList.IndexOf(message));
                        chatList.Add(message);
                    }
                }

                else if (cmd[0] == "Spam")
                {
                    for (int i = 1; i < cmd.Count; i++)
                    {
                        chatList.Add(cmd[i]);
                    }
                }
            }

            foreach(var messageElement in chatList)
            {
                Console.WriteLine(messageElement);
            }
        }
    }
}
