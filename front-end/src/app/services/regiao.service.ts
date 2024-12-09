import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Regiao } from '../models/regiao.model';
import { Cidade } from '../models/cidade.model';

@Injectable({
  providedIn: 'root'
})
export class RegiaoService {
  private apiUrl = environment.apiURL;

  constructor(private http: HttpClient) { }

  getRegioes(): Observable<any[]>{
    return this.http.get<any[]>(this.apiUrl + 'regiao')
  }

  createRegiao(regiao: { nome: string; status: boolean, cidades: Cidade[] }): Observable<any> {
    return this.http.post<any>(this.apiUrl + 'regiao', regiao);
  }
}
