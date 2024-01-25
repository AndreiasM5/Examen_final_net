import { Component, OnInit } from '@angular/core';
import { ProductService } from './service/product.service';
import { Product } from './model/product';
import { OrderService } from './service/order.service';
import { order } from './model/order';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  public products: Product[];

  public orders: order[];

  constructor (private ProductService : ProductService
    ,private OrderService : OrderService) {}

  ngOnInit(): void {
    this.ProductService.getProducts().subscribe(
      (data: Product[]) => {
        this.products = data;
      },
      (error) => {
        console.error('Error loading products:', error);
      }
    );
    this.OrderService.getOrders().subscribe(
      (data: order[]) => {
        this.orders = data;
      },
      (error) => {
        console.error('Error loading products:', error);
      }
    );
  }

  

  
}
