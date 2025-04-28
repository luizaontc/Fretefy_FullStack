import { RegiaoCidade } from '../../../regiao-cidade';

export class CidadeResponseDto {
  id: string;
  nome: string;
  uf: string;
  regiaoCidades: RegiaoCidade[];

  constructor(id: string, nome: string, uf: string, regiaoCidades: RegiaoCidade[]) {
    this.id = id;
    this.nome = nome;
    this.uf = uf;
    this.regiaoCidades = regiaoCidades;
  }
}