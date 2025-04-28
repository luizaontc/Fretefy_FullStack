import { Cidade } from '../../../cidade'; 

export class EditarRegiaoDto {
  id: string;
  nome: string;
  status: boolean;
  cidades: Cidade[];

  constructor(nome: string, status: boolean, cidades: Cidade[], id?: string) {
    this.id = id;
    this.nome = nome;
    this.status = status;
    this.cidades = cidades;
  }
}