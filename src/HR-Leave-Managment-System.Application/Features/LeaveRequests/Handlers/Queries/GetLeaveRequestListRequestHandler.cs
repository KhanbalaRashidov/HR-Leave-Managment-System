using AutoMapper;
using HR_Leave_Managment_System.Application.DTOs.LeaveRequest;
using HR_Leave_Managment_System.Application.Features.LeaveRequests.Requests.Queries;
using HR_Leave_Managment_System.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_Leave_Managment_System.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
           var leaveRequesties= await _leaveRequestRepository.GetAll();
           return _mapper.Map<List<LeaveRequestDto>>(leaveRequesties);
        }
    }
}
