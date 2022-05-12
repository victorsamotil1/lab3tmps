using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    interface IChatMediator
    {
        void SendMessageToAll(string message, UserBase from);

        void SendMessageToUser(string message, UserBase from, string toId);
    }
}
