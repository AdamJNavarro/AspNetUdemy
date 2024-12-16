using AspNetUdemy.Data;
using AspNetUdemy.Models.LeaveTypes;
using AutoMapper;

namespace AspNetUdemy.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
        //.ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumOfDays));
        CreateMap<LeaveTypeCreateVM, LeaveType>();
        CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
    }
}