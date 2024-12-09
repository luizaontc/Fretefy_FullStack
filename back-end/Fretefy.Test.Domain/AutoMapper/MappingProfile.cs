using AutoMapper;
using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Regiao, RegiaoDTO>();
            CreateMap<RegiaoDTO, Regiao>();

            CreateMap<Regiao, IEnumerable<RegiaoCidade>>()
    .ConvertUsing(src => src.cidades.Select(cidade => new RegiaoCidade
    {
        RegiaoId = src.Id,
        CidadeId = cidade.Id
    }).ToList());


            CreateMap<Cidade, CidadeDTO>();
            CreateMap<CidadeDTO, Cidade>();

        }
    }
}
