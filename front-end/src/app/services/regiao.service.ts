import { Injectable } from '@angular/core';
import { Observable,throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Regiao } from '../models/regiao.model';
import { Cidade } from '../models/cidade.model';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RegiaoService {
  private url = environment.apiURL+'api/regiao/';

  constructor(private http: HttpClient) { }

  getRegioes(): Observable<any[]>{
    return this.http.get<any[]>(this.url)
  }

  createRegiao(regiao: Regiao): Observable<any> {
    console.log(regiao);

    return this.http.post<any>(this.url + 'newRegiao', regiao);
  }

  updateRegiao(regiao: { id: string ,nome: string }): Observable<any> {
    return this.http.put<any>(this.url + 'updateRegiao', regiao).pipe(
      catchError((error) => {
          console.error('Erro updateRegiao:', error);
          return throwError(() => error);
      })
  );
  }

  changeStatus(nome: string): Observable<any>  {
    const url = `${this.url}updateStatus?nome=${encodeURIComponent(nome)}`;
    console.log(url);

    return this.http.post<any>(url, null).pipe(
        catchError((error) => {
            console.error('Erro changeStatus:', error);
            return throwError(() => error);
        })
    );
  }
}
