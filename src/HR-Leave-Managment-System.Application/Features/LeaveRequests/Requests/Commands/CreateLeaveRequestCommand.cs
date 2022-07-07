using HR_Leave_Managment_System.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand:IRequest<int>
    {
        public CreateLeaveRequestDto  LeaveRequestDto { get; set; }
    }
}
