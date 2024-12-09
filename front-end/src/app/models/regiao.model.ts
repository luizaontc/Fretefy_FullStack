import { Cidade } from './cidade.model';
import { v4 as uuidv4 } from 'uuid';

export class Regiao {
    id?: string ; 
    nome: string;
    status: boolean;
    cidades: Cidade[]; 
    
  constructor(nome: string, status: boolean, cidades: Cidade[] = [],id?: string) {
    this.id = id || uuidv4();;
    this.nome = nome;
    this.status = status;
    this.cidades = cidades;
  }

  isActive(): boolean {
    return this.status;
  }

  addCidade(cidade: Cidade): void {
    this.cidades.push(cidade);
  }
}
  