import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { Product } from '../models/consumption.model';

@Injectable({
  providedIn: 'root'
})
export class TariffsService {
  baseApiUrl:string=environment.baseApiUrl;
  constructor(private http:HttpClient) { }

  getEstimatedTarrif(data:number):Observable<Product[]>{
      return this.http.get<Product[]>(this.baseApiUrl + 'api/Tariff/Estimation?consumption='+data);
  }
}
