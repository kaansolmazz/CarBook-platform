﻿using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQuerResult>
    {
        public int Id { get; set; }

        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}
