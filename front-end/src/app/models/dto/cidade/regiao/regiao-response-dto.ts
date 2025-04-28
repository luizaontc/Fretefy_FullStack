import { Cidade } from 'src/app/models/cidade';
import { CidadeResponseDto } from '../cidade/cidade-response-dto'; 

export class RegiaoResponseDto {
  id: string;
  nome: string;
  cidades: Cidade[];

  constructor(id: string, nome: string, cidades: CidadeResponseDto[]) {
    this.id = id;
    this.nome = nome;
    this.cidades = cidades;
  }
}