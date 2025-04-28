using Fretefy.Test.Application.Dto;
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
        private readonly ICidadeRepository _cidadeRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository, ICidadeRepository cidadeRepository)
        {
            _regiaoRepository = regiaoRepository;
            _cidadeRepository = cidadeRepository;
        }

        public async Task<Regiao> NovaRegiao(NovaRegiaoDto dto)
        {
            if (await ExisteRegiao(dto.Nome, null))
            {
                throw new Exception($"A região com nome \"{dto.Nome}\" já existe. Altere o nome e tente novamente");
            }

            Regiao request = new Regiao
            {
                Nome = dto.Nome,
                Status = true
            };

            var response = await _regiaoRepository.AdicionarRegiao(request);

            List<RegiaoCidade> regiaoCidadesList = new List<RegiaoCidade>();

            foreach (var item in dto.Cidades)
            {
                var regiaoCidade = new RegiaoCidade(response.Id, item.Id);

                regiaoCidadesList.Add(regiaoCidade);
            }

            await _regiaoRepository.AdicionarRegiaoCidades(regiaoCidadesList);

            return response;
        }

        public async Task<Regiao> EditarRegiaoDto(EditarRegiaoDto dto)
        {
            if (dto.Cidades.GroupBy(x => x.Id).Any(g => g.Count() > 1))
            {
                throw new Exception("Existem cidades duplicadas na lista de cidades.");
            }

            if (await ExisteRegiao(dto.Nome, dto.Id))
            {
                throw new Exception($"A região com nome \"{dto.Nome}\" já existe. Altere o nome e tente novamente");
            }


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

            if (listCidadesAAdicionar.Count() > 0)
            {
                List<RegiaoCidade> regiaoCidadesList = new List<RegiaoCidade>();

                foreach (var item in listCidadesAAdicionar)
                {
                    var regiaoCidade = new RegiaoCidade(dto.Id, item.Id);

                    regiaoCidadesList.Add(regiaoCidade);
                }

                await _regiaoRepository.AdicionarRegiaoCidades(regiaoCidadesList);
            }

            return regiao;
        }

        public async Task<RegiaoResponseDto> GetRegiaoById(Guid id)
        {
            var response = await _regiaoRepository.GetRegiaoById(id);
            var regiaoCidadesRegiao = await _regiaoRepository.GetRegiaoCidades(id);

            List<Cidade> cidades = new List<Cidade>();

            foreach (var item in regiaoCidadesRegiao)
            {
                var cidade = await _cidadeRepository.GetCidadeById(item.IdCidade);

                var newCidade = new Cidade()
                {
                    Id = item.IdCidade,
                    Nome = cidade.Nome,
                    UF = cidade.UF
                };

                cidades.Add(newCidade);
            }

            var regiaoResponse = new RegiaoResponseDto() { Id = id, Nome = response.Nome, Cidades = cidades };


            return regiaoResponse;
        }

        public async Task<IEnumerable<Regiao>> ListRegioes(int page, int pageSize)
        {
            return await _regiaoRepository.GetRegiao(page, pageSize);
        }

        private async Task<bool> ExisteRegiao(string nome, Guid? IdRegiao)
        {
            return await _regiaoRepository.ExisteRegiao(nome, IdRegiao);
        }
    }
}
