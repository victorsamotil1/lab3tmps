using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Users
{
    abstract class UserBase
    {
        protected IChatMediator _mediator;

        public readonly string Id;

        public UserBase(IChatMediator mediator, string id)
        {
            _mediator = mediator;
            Id = id;
        }

        public abstract void SendMessageAll(string message);
        public abstract void SendMessageTo(string message, string toId);
        public abstract void ReceiveMessage(string message, string fromId);
    }
}
