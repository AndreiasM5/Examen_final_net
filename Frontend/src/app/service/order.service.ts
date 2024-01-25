import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { order } from '../model/order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private host = "http://localhost:5156";

  constructor(private http: HttpClient) { }

  public getOrders(): Observable<order[]> {
    return this.http.get<order[]>(`${this.host}/api/order/orders`);
  }
  

  public getOrder(OrderId : number): Observable<order>{
    return this.http.get<order>(`${this.host}/api/order/${OrderId}`)
  }
}
