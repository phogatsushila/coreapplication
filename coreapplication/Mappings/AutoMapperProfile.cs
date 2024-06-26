﻿using coreapplication.Model.Domain;
using coreapplication.Model.DTO;
//using coreapplication.Model.Domain.;

using AutoMapper;
namespace coreapplication.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Region, Regiondto>().ReverseMap();
            CreateMap<Regiondto,Region>() .ReverseMap();//ADD   region
            CreateMap<UpdateRegionDTO, Region>() .ReverseMap();

            CreateMap<AddWalkDTO, Walk>().ReverseMap();
            CreateMap<Walk,walkdto>().ReverseMap() ;
            //CreateMap<walkdto,Walk>().ReverseMap() ;

            CreateMap<Dificulity,difficultydto>().ReverseMap();
        }

    }
   
}

