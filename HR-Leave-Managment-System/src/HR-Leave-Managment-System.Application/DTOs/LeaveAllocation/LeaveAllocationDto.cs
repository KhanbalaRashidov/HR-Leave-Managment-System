using HR_Leave_Managment_System.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.DTOs
{
    public class LeaveAllocationDto:BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
