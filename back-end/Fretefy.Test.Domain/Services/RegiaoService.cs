using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<Regiao> NovaRegiao(NovaRegiaoDto dto)
        {
            ExisteRegiao(dto.Nome);

            Regiao request = new Regiao
            {
                Nome = dto.Nome,
                Status = true
            };

            var response = await _regiaoRepository.AdicionarRegiao(request);

            List<RegiaoCidade> regiaoCidadesList = new List<RegiaoCidade>();

            foreach (var item in dto.Cidades)
            {
                var regiaoCidade = new RegiaoCidade(response.Id,item.Id);

                regiaoCidadesList.Add(regiaoCidade);
            }

            await _regiaoRepository.AdicionarRegiaoCidades(regiaoCidadesList);

            return response;
        }

        public async Task<Regiao> EditarRegiaoDto(EditarRegiaoDto dto)
        {
            ExisteRegiao(dto.Nome);

            var regiao = await _regiaoRepository.GetRegiaoById(dto.Id);
            regiao.Nome = dto.Nome;
            regiao.Status = dto.Status;

            await _regiaoRepository.AtualizarRegiao(regiao);
        
            var regiaoCidadesRegiao = await _regiaoRepository.GetRegiaoCidades(dto.Id);

            var listCidadesARemover = regiaoCidadesRegiao
                                    .Where(item => !dto.Cidades.Any(cidade => cidade.Id == item.IdCidade))
                                    .ToList();

            if (listCidadesARemover.Count() > 0)
            {
                regiaoCidadesRegiao = await _regiaoRepository.RemoverRegiaoCidade(listCidadesARemover, regiao.Id);
            }

            var listCidadesAAdicionar = dto.Cidades
                                        .Where(cidade => !regiaoCidadesRegiao.Any(regiaoCidade => regiaoCidade.IdCidade == cidade.Id))
                                        .ToList();

            return regiao;
        }

        public async Task<Regiao> GetRegiaoById(Guid id)
        {
            return await _regiaoRepository.GetRegiaoById(id);
        }

        public async Task<IEnumerable<Regiao>> ListRegioes(int page, int pageSize)
        {
            return await _regiaoRepository.GetRegiao(page, pageSize);
        }

        private async void ExisteRegiao(string nome)
        {
            var existeRegiao = await _regiaoRepository.ExisteRegiao(nome);

            if (existeRegiao)
                throw new Exception($"A região com nome \"{nome}\" já existe. Altere o nome e tente novamente");
        }
    }
}
