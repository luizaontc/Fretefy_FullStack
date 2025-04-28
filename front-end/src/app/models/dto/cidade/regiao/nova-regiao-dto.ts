import { Cidade } from '../../../cidade'; 

export class NovaRegiaoDto {
  nome: string;
  status: boolean;
  cidades: Cidade[];

  constructor(nome: string, status: boolean, cidades: Cidade[]) {
    this.nome = nome;
    this.status = status;
    this.cidades = cidades;
  }
}