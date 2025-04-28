import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormArray, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Cidade } from 'src/app/models/cidade';
import { EditarRegiaoDto } from 'src/app/models/dto/cidade/regiao/editar-regiao-dto';
import { NovaRegiaoDto } from 'src/app/models/dto/cidade/regiao/nova-regiao-dto';
import { Regiao } from 'src/app/models/regiao';
import { CidadeService } from 'src/app/services/cidade/cidade.service';
import { RegiaoService } from 'src/app/services/regiao/regiao.service';
import * as ExcelJS from 'exceljs';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  regiaoForm: FormGroup;
  regiaoFormEdicao: FormGroup;
  url: string = 'cadastrarRegiao';
  regioes: Regiao[] = [];

  cidadesSelect: Cidade[] = [];

  cidadesFormArray: FormArray;
  cidadesFormArrayEdicao: FormArray;

  constructor(private fb: FormBuilder
    , private regiaoService: RegiaoService
    , private cidadeService: CidadeService
    , private router: Router
  ) {
  }

  async ngOnInit() {
    this.url = this.router.url.split('/')[1];
    await this.buscarRegioes();

    this.regiaoForm = this.fb.group({
      nome: ['', Validators.required],
      cidades: this.fb.array([], Validators.required)
    });

    this.regiaoFormEdicao = this.fb.group({
      id: ['', Validators.required],
      nome: ['', Validators.required],
      ativo: [true],
      cidades: this.fb.array([], Validators.required)
    });

    this.cidadesFormArray = this.regiaoForm.get('cidades') as FormArray;

    this.cidadesFormArrayEdicao = this.regiaoFormEdicao.get('cidades') as FormArray;
  }

  async alterarUrl(url: string) {
    this.regioes = [];
    switch (url) {
      case 'cadastrarRegiao':
        this.url = 'cadastrarRegiao';
        await this.buscarCidades();
        break;
      case 'editarRegiao':
        this.url = 'editarRegiao';
        this.buscarCidades();
        break;
      default:
        this.url = 'regiao';
        await this.buscarRegioes();
        break;
    }
  }

  async buscarRegioes(): Promise<void> {
    this.regioes = await this.regiaoService.getRegioes(1, 10);

    console.log(this.regioes);
  }

  async exportarParaExcel(): Promise<void> {
    const workbook = new ExcelJS.Workbook();
    const worksheet = workbook.addWorksheet('Regiões');

    worksheet.columns = [
      { header: 'Nome', key: 'nome', width: 30 },
      { header: 'Status', key: 'status', width: 15 }
    ];

    this.regioes.forEach(regiao => {
      worksheet.addRow({
        nome: regiao.nome,
        status: regiao.status ? 'Ativo' : 'Inativo'
      });
    });

    const buffer = await workbook.xlsx.writeBuffer();
    const blob = new Blob([buffer], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
    const url = window.URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = 'regioes.xlsx';
    a.click();
    window.URL.revokeObjectURL(url);
  }

  adicionarCidade() {
    this.cidadesFormArray.push(this.fb.group({
      id: [],
      nome: ['', Validators.required],
      uf: []
    }));
  }

  adicionarCidadeEdicao() {
    this.cidadesFormArrayEdicao.push(this.fb.group({
      id: [],
      nome: ['', Validators.required],
      uf: []
    }));
  }

  removerCidade(index: number) {
    this.cidadesFormArray.removeAt(index);
  }

  removerCidadeEdicao(index: number) {
    this.cidadesFormArrayEdicao.removeAt(index);
  }

  async buscarCidades() {
    await this.cidadeService.getRegioes(1, 10).subscribe(cidades => {
      this.cidadesSelect = cidades;
    });
  }

  async salvarNovaRegiao() {
    try {
      console.log(this.regiaoForm.value);
      var novaRegiao = new NovaRegiaoDto(this.regiaoForm.value.nome, true, this.regiaoForm.value.cidades);
      await this.regiaoService.salvarRegiao(novaRegiao);
    } catch (error) {
      console.log(error);

      alert('Ocorreu um erro ao salvar a região. Por favor, tente novamente.' + error.error);

    }
  }

  async editarRegiao(regiao: Regiao) {
    try {
      this.regiaoForm.patchValue(regiao);
      await this.regiaoService.getRegiaoById(regiao.id).then(regiao => {
        console.log(regiao);
        this.regiaoFormEdicao.patchValue(regiao);
        this.cidadesFormArrayEdicao.clear();
        regiao.cidades.forEach(cidade => {
          this.cidadesFormArrayEdicao.push(this.fb.group({
            id: [cidade.id],
            nome: [cidade.nome],
            uf: [cidade.uf]
          }));
        });
      });
      this.alterarUrl('editarRegiao');
    } catch (error) {
      console.log(error);
      console.log("oi");

      alert('Ocorreu um erro ao editar a região. Por favor, tente novamente.' + error.error);

    }
  }

  async salvarEditarRegiao() {
    console.log(this.regiaoFormEdicao.value);
    var novaRegiao = new EditarRegiaoDto(
      this.regiaoFormEdicao.value.nome, 
      this.regiaoFormEdicao.value.ativo, 
      this.regiaoFormEdicao.value.cidades, 
      this.regiaoFormEdicao.value.id
    );
    await this.regiaoService.editarRegiao(novaRegiao);
    this.alterarUrl('regiao');
  }
}
