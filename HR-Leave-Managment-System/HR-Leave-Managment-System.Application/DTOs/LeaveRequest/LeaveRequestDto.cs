using HR_Leave_Managment_System.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto:BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestComments { get; set; }
        public DateTime ActionedDate { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
