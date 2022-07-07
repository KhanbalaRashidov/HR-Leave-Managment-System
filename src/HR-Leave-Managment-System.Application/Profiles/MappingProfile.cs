using AutoMapper;
using HR_Leave_Managment_System.Application.DTOs;
using HR_Leave_Managment_System.Application.DTOs.LeaveRequest;
using HR_Leave_Managment_System.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Leave_Managment_System.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        }
    }
}
