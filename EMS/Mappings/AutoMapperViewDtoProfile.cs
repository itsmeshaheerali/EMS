using AutoMapper;
using EMS.BLL.DTO;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Mappings
{
    public class AutoMapperViewDtoProfile : Profile
    {
        public AutoMapperViewDtoProfile()
        {
            CreateMap<EmployeeDTO, EmployeeViewModal>().ReverseMap();
        }
    }
}