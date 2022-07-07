using HR_Leave_Managment_System.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Domain
{
    public class LeaveType:BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }

    }
}
