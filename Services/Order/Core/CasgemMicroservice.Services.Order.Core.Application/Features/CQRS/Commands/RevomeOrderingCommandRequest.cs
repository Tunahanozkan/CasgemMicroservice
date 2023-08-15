using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RevomeOrderingCommandRequest:IRequest
    {
        public int Id { set; get; }

        public RevomeOrderingCommandRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
