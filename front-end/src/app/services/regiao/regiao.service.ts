import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RegiaoResponseDto } from 'src/app/models/dto/cidade/regiao/regiao-response-dto';
import { environment } from 'src/environments/environment';
import { NovaRegiaoDto } from 'src/app/models/dto/cidade/regiao/nova-regiao-dto';
import { Regiao } from 'src/app/models/regiao';
import { EditarRegiaoDto } from 'src/app/models/dto/cidade/regiao/editar-regiao-dto';
@Injectable({
  providedIn: 'root'
})
export class RegiaoService {

  private apiUrl : string = environment.apiUrl

  constructor(private http: HttpClient) { }

  getRegioes(page:number,pageSize:number): Promise<Regiao[]> {
    return this.http.get<Regiao[]>(`${this.apiUrl}buscarRegiao?page=${page}&pageSize=${pageSize}`).toPromise();
  }

  getRegiaoById(id: string): Promise<RegiaoResponseDto> {
    return this.http.get<RegiaoResponseDto>(`${this.apiUrl}buscarRegiaoById?IdRegiao=${id}`).toPromise();
  }

  async salvarRegiao(regiao: NovaRegiaoDto): Promise<Regiao> {
    try {
      var response =  await this.http.post<Regiao>(`${this.apiUrl}novaRegiao`, regiao).toPromise();
      return response;
    } catch (error) {
      console.log(error);
      throw error.error;
    }
  }

  async editarRegiao(regiao: EditarRegiaoDto): Promise<Regiao> {
    try {
      var response = await this.http.put<Regiao>(`${this.apiUrl}editarRegiao`, regiao).toPromise();
      
      return response;
    } catch (error) {
      console.log("oi");
      alert(error.error);
    }
  }
}
