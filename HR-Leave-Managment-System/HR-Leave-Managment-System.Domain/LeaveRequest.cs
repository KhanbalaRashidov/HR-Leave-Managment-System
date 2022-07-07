using HR_Leave_Managment_System.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Domain
{
    public class LeaveRequest:BaseDomainEntity
    {
       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestComments { get; set; }
        public DateTime? ActionedDate { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }


    }
}
