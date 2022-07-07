using HR_Leave_Managment_System.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.DTOs.LeaveRequest
{
    internal class LeaveRequestListDto:BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime RequestedDate { get; set; }
        public bool? Approved { get; set; }
    }
}
