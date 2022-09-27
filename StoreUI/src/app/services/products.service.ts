import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private http: HttpClient) { }

  public getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>('/products');
  }
}

export interface Product {
  productId: string;
  name: string;
  description: string;
  unitprice: number;
  maximumQuantity: number;
}
