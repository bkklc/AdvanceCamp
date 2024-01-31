﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
        }
    }
}
