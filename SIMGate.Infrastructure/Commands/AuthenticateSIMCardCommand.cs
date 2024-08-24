using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SIMGate.Infrastructure.Commands
{
    public class AuthenticateSIMCardCommand : IRequest
    {
        public AuthenticateSIMCardCommand()
        {
        }
    }

    public class AuthenticateSIMCardCommandHandler : IRequestHandler<AuthenticateSIMCardCommand>
    {
        public Task Handle(AuthenticateSIMCardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
