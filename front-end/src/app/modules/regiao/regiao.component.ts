import { Component, OnInit } from '@angular/core';
import { Cidade } from 'src/app/models/cidade.model';
import { Regiao } from 'src/app/models/regiao.model';
import { RegiaoService } from 'src/app/services/regiao.service';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  currentTab: 'listar' | 'criar' = 'listar';
  regioes: Regiao[] = [];
  novaRegiao: Regiao;

  constructor(private regiaoService: RegiaoService) {
    this.novaRegiao = new Regiao('',true,[]);
  }

  ngOnInit() {
    this.loadRegioes();
  }

  loadRegioes() {
    this.regiaoService.getRegioes().subscribe(
      (data) => (this.regioes = data.map((r: any) => new Regiao(r.nome, r.status, r.cidades, r.id))),
      (error) => console.error('Erro ao carregar regiões', error)
    );
  }

  switchTab(tab: 'listar' | 'criar') {
    this.currentTab = tab;
  }

  addCidadeToRegiao(nome: string, uf: string) {
    const novaCidade = new Cidade(nome, uf);
    this.novaRegiao.addCidade(novaCidade);
  }

  createRegiao() {
    this.regiaoService.createRegiao(this.novaRegiao).subscribe(
      () => {
        alert('Região criada com sucesso!');
        this.novaRegiao = new Regiao('',true,[]);
        this.switchTab('listar');
        this.loadRegioes();
      },
      (error) => console.error('Erro ao criar região', error)
    );
  }
}