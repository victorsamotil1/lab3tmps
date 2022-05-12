using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Users
{
    class SimpleUser : UserBase
    {

        public SimpleUser(IChatMediator mediator, string id) : base(mediator, id)
        { }
        public override void ReceiveMessage(string message, string fromId)
        {
            Console.WriteLine($"User {this.Id} received {message} grom {fromId}");
        }

        public override void SendMessageAll(string message)
        {
            _mediator.SendMessageToAll(message, this);
        }

        public override void SendMessageTo(string message, string toId)
        {
            _mediator.SendMessageToUser(message, this, toId);   
        }
    }
}
