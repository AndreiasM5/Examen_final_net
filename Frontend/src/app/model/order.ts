// order.model.ts

import { Product } from "./product";

export class order {
    OrderId: number;
    TotalAmount : number;
    UserId : string;
    Products : Product[];
    

    constructor(OrderId: number, TotalAmount : number,
         UserId : string, Products : Product[]) {
      this.OrderId = OrderId;
      this.TotalAmount = TotalAmount;
      this.UserId = UserId;
      this.Products = Products;
    }
  }
  