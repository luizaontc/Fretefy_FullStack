import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cidade } from 'src/app/models/cidade';
import { RegiaoResponseDto } from 'src/app/models/dto/cidade/regiao/regiao-response-dto';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CidadeService {

  private apiUrl : string = environment.apiUrl

  constructor(private http: HttpClient) { }

  // async adicionarRegiao(regiao: Regiao) {
  //   const regioes = await this.getRegioes();
  //   regioes.push(regiao);
  //   localStorage.setItem('regioes', JSON.stringify(regioes));
  // }

  getRegioes(page:number,pageSize:number): Observable<Cidade[]> {
    return this.http.get<Cidade[]>(`${this.apiUrl}buscarCidades`);
  }
}
