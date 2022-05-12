using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    class ChatMediator : IChatMediator
    {
        private List<SimpleUser> _simpleUsers;

        public ChatMediator()
        {
            _simpleUsers = new List<SimpleUser>();
        }

        public void AddSimpleUserToChat(SimpleUser user)
        {
            _simpleUsers.Add(user);
        }

        public void SendMessageToAll(string message, UserBase from)
        {
            foreach (var user in _simpleUsers)
                if (user != from)
                user.ReceiveMessage(message, from.Id);
        }

        public void SendMessageToUser(string message, UserBase from, string toId)
        {
            var to = _simpleUsers.FirstOrDefault(x => x.Id == toId);

            if (to == null)
                Console.WriteLine($"User {toId} doesn't exist.");
            else
                to.ReceiveMessage(message, from.Id);
        }
    }
}
