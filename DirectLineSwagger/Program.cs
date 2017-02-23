using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Models;
using Microsoft.Rest;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            BotConnectorDirectLineAPIV30 client = new BotConnectorDirectLineAPIV30(new TokenCredentials("<your direct line key here>"));
            var conversationClient = new Conversations(client);

            var result = conversationClient.StartConversationWithOperationResponseAsync().Result;
            var waterMark = "";
            while (true)
            {
                var textToSend = Console.ReadLine();
                var r = conversationClient.PostActivityWithOperationResponseAsync(result.Body.ConversationId,
                    new Activity() { Type = "message", From = new ChannelAccount() { ID = "James" }, Text = textToSend }).Result;

                var activities = conversationClient.GetActivitiesWithOperationResponseAsync(result.Body.ConversationId, waterMark).Result;
                waterMark = activities.Body.Watermark;

                foreach (var activity in activities.Body.Activities)
                {
                    Console.WriteLine($"{activity.From.ID}:{activity.Text}");
                }
            }
        }
    }
}
