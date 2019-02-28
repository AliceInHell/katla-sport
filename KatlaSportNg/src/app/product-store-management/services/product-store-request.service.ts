import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { ProductStoreRequest } from '../models/product-store-request';

@Injectable({
  providedIn: 'root'
})
export class ProductStoreRequestService {
  private url = environment.apiUrl + 'api/productRequests/';

  constructor(private http: HttpClient) { }  

  createRequest(productStoreRequest: ProductStoreRequest): Observable<ProductStoreRequest> {
    return this.http.post<ProductStoreRequest>(`${this.url}`, productStoreRequest);
  }
}
