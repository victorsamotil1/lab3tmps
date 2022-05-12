using Mediator.Mediators;
using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();

            SimpleUser user1 = new SimpleUser(chat, "Ivan1");
            SimpleUser user2 = new SimpleUser(chat, "Valera2");
            SimpleUser user3 = new SimpleUser(chat, "Basil3");


            chat.AddSimpleUserToChat(user1);
            chat.AddSimpleUserToChat(user2);
            chat.AddSimpleUserToChat(user3);


            user1.SendMessageAll("Salutare la toti");
            user2.SendMessageTo("Salut Vasea, cum lab5 la testare?", "Basil3");
            user3.SendMessageTo("Salutare Valera, totul bine", "Valera2");
            user3.SendMessageTo("Salut Victor, cum lab5 la testare?", "Victor4");
        }
    }
}
