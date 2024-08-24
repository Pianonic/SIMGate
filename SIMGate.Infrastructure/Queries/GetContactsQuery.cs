using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMGate.Infrastructure.Queries
{
    public class GetContactsQuery : IRequest
    {
    }

    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery>
    {
        public Task Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
