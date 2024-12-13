import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
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
  regiaoForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private regiaoService: RegiaoService) {

    this.novaRegiao = new Regiao('', true, []);
  }

  ngOnInit() {
    this.loadRegioes();

    this.initForm();
  }

  loadRegioes() {
    this.regiaoService.getRegioes().subscribe(
      (data) => (this.regioes = data.map((r: any) => new Regiao(r.nome, r.status, r.cidades, r.id))),
      (error) => console.error('Erro ao carregar regiões', error)
    );
  }

  get cidades() {
    return (this.regiaoForm.get('cidades') as FormArray);
  }

  addCidade(): void {
    const cidadeGroup = this.formBuilder.group({
      nome: ['', Validators.required],
      uf: ['', Validators.required],
    });
    this.cidades.push(cidadeGroup);
  }

  removeCidade(index: number): void {
    this.cidades.removeAt(index);
  }

  switchTab(tab: 'listar' | 'criar') {
    this.currentTab = tab;
  }

  changeStatus(nome: string) {
    console.log(nome);
    this.regiaoService.changeStatus(nome).subscribe({
      next: (response) => {
        this.loadRegioes();
      },
      error: (error) => {
        console.error('Erro:', error);
      }
    });
  }

  initForm(): void {
    this.regiaoForm = this.formBuilder.group({
      id: [''],
      nome: ['', Validators.required], 
      cidades: this.formBuilder.array([]),
    });
  }

  addCidadeToRegiao(nome: string, uf: string) {
    const novaCidade = new Cidade(nome, uf);
    this.novaRegiao.addCidade(novaCidade);
  }

  carregarEdicao(regiao: Regiao) {
    this.currentTab = 'criar'

    console.log(regiao);

    this.regiaoForm.patchValue({
      id: regiao.id,
      nome: regiao.nome,
    });
  }

  carregarCriacao() {
    this.currentTab = 'criar'

    console.log("oi");

    this.initForm();
  }

  onSubmit(): void{
    if (this.regiaoForm.valid) {
      const novaRegiao = this.regiaoForm.value;

      console.log(novaRegiao);
      
      if (novaRegiao.id) {
        this.regiaoService.updateRegiao(novaRegiao).subscribe({
          next: (response) => {
            this.loadRegioes();
            this.switchTab("listar");
          },
          error: (error) => {
            console.error('Erro:', error);
          }
        });
      }
      else{
        delete novaRegiao.id;
        this.regiaoService.createRegiao(novaRegiao).subscribe({
          next: (response) => {
            this.loadRegioes();
            this.switchTab("listar");
          },
          error: (error) => {
            console.error('Erro:', error.message);
          }
        });
      }    
    }
  }

  createRegiao() {
    this.regiaoService.createRegiao(this.novaRegiao).subscribe(
      () => {
        alert('Região criada com sucesso!');
        this.novaRegiao = new Regiao('', true, []);
        this.switchTab('listar');
        this.loadRegioes();
      },
      (error) => console.error('Erro ao criar região', error)
    );
  }
}