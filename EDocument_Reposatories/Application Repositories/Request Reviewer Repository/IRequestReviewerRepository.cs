﻿using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_Reposatories.Generic_Reposatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository
{
    public interface IRequestReviewerRepository: IGenericRepository<RequestReviewer>
    {

        Task<IEnumerable<DefinedRequestReviewer>> GetDefinedRequestReviewersAsync(long definedRequestId);

        Task<IEnumerable<RequestReviewer>> GetRequestReviewersAsync(long requestId);
    }

}
