using AutoMapper;
using EMS.BLL.DTO;
using EMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Mapper
{
    public class EntityAndDTOMapper : Profile
    {
        public EntityAndDTOMapper()
        {
            CreateMap<EmployeeDTO, Employee>().ReverseMap();
        }
    }
}
