import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { ProductStoreItem } from '../models/product-store';

@Injectable({
  providedIn: 'root'
})
export class ProductStoreService {
  private url = environment.apiUrl + 'api/productStore/';

  constructor(private http: HttpClient) { }  

  getSectionProducts(hiveSectionId: number): Observable<Array<ProductStoreItem>> {
    return this.http.get<Array<ProductStoreItem>>(`${this.url}${hiveSectionId}`);
  }
}
