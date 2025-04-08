using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DigiAssistant.Core.Dtos;
using DigiAssistant.Core.Entities;

namespace DigiAssistant.Service.Mapping
{
    public class MapProfile : Profile
    {
      public MapProfile()
      {
          CreateMap<ErrorDto, Error>().ReverseMap();
          CreateMap<ErrorCategoryDto, ErrorCategory>().ReverseMap();
      }   
    }
}