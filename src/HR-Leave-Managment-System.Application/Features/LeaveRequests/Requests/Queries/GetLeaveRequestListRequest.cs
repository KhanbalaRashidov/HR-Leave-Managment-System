using HR_Leave_Managment_System.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest:IRequest<List<LeaveRequestDto>>
    {
    }
}
