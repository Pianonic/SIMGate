using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMGate.Infrastructure.Commands
{
    public class SendMessageCommand : IRequest
    {
    }

    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand>
    {
        public Task Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
