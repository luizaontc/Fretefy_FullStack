using AutoMapper;
using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly IMapper _mapper;

        public RegiaoService(IRegiaoRepository regiaoRepository, IMapper mapper
            )
        {
            _mapper = mapper;
            _regiaoRepository = regiaoRepository;
        }

        public Regiao ChangeStatus(string nome)
        {
            Regiao regiao = _regiaoRepository.ListByName(nome).FirstOrDefault();

            regiao.Status = !regiao.Status;

            return _regiaoRepository.ChangeStatus(regiao);
        }

        public Regiao Get(Guid id)
        {
            return _regiaoRepository.List().FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List();
        }

        public IEnumerable<Regiao> ListByName(string uf)
        {
            return _regiaoRepository.ListByName(uf);
        }

        public Regiao NewRegiao(RegiaoDTO dTO)
        {
            if (ExisteRegiao(dTO.Nome))
                throw new ArgumentException("Região já cadastrada.");

            Regiao regiao = _mapper.Map<Regiao>(dTO);

            List<RegiaoCidade> regiaoCidade = _mapper.Map<List<RegiaoCidade>>(regiao);

            if (regiao.cidades.Count() == 0)
                throw new ArgumentException("Adicione pelo menos uma cidade.");

            if (ExisteCidadeDuplicada(dTO.cidades))
                throw new ArgumentException("Não é possivel adicionar cidades duplicadas na mesma região");

            _regiaoRepository.NewRegiao(regiao);
            _regiaoRepository.NewRegiaoCidade(regiaoCidade);

            return regiao;
        }

        public IEnumerable<Regiao> Query(string terms)
        {
            return _regiaoRepository.Query(terms);
        }

        private bool ExisteRegiao(string nome)
        {
            return _regiaoRepository.ListByName(nome).Any();
        }

        private bool ExisteCidadeDuplicada(List<CidadeDTO> cidades)
        {
            return cidades
                  .GroupBy(c => c.Nome) 
                  .Where(g => g.Count() > 1) 
                  .Select(g => g.Key) 
                  .Any();
        }

        public Regiao UpdateRegiao(RegiaoDTO dto)
        {
            Regiao regiao = _mapper.Map<Regiao>(dto);

            return _regiaoRepository.UpdateRegiao(regiao);
        }
    }
}
