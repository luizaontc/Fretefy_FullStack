import { v4 as uuidv4 } from 'uuid';

export class Cidade {
  id?: string;
  nome: string;
  uf: string;

  constructor(nome: string, uf: string,id?: string) {
    this.id = id || uuidv4();;
    this.nome = nome;
    this.uf = uf;
  }

  getDisplayName(): string {
    return `${this.nome} - ${this.uf}`;
  }
}
