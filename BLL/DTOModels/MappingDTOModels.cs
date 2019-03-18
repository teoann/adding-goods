using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataLevel.Entities;

namespace BLL.DTOModels
{
    public class MappingDTOModels
    {
        public static void MapperInitializes()
        {
            Mapper.Initialize(map=>
            {
                map.CreateMap<ProductDTO, Product>().ReverseMap();
            });
        }
    }
}
