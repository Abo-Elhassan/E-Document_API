using EDocument_Data.Consts.Enums;
using EDocument_Data.DTOs.Requests.RequestReviewer;
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

        Task<IEnumerable<DefinedRequestReviewer>> GetAllDefinedRequestReviewersAsync(long definedRequestId);

        Task<List<ReviewersDetails>> GetAllRequestReviewersAsync(long requestId);

        Task<string> GetAllRequestReviewersEmailsByStageNumberAsync(long requestId, int stageNumber);
        Task NominateReviewer(long requestId, string reviewerId, string naminatedBy);
        Task NominateReviewer(long requestId, string creatorId);
        Task BeginRequestCycle( long definedRequestId, long requestId,string requesterId,bool isNew);
        Task<(bool IsSucceded, string? Message)> ApproveRequestAsync(ApproveRequestReviewerDto reviewingInfo,User reviewer);
        Task<(bool IsSucceded, string? Message)> DeclineRequestAsync(DeclineRequestReviewerDto reviewingInfo,User reviewer);
    }

}
