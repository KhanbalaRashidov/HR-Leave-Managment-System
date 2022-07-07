using HR_Leave_Managment_System.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
