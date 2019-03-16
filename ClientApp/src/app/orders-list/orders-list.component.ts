import { Component, OnInit, Input } from '@angular/core';
import { Repository } from '../models/repository';
import { Order } from '../models/order.model';
import { Car } from '../models/car.model/car.model';
import { User } from '../models/user.model';

@Component({
  selector: 'app-orders-list',
  templateUrl: './orders-list.component.html',
  styleUrls: ['./orders-list.component.css']
})
export class OrdersListComponent implements OnInit {

  displayedColumns: string[] = ['orderId', 'startOfRental', 'endOfRental', 'comment', 'car', 'user'];
  orders: Order[];
  users: User[];
  cars: Car[];
  order: Order;
  tableMode: boolean;

  constructor(private repo: Repository) {
   }

  deleteOrder() {
    // this.repo.deleteOrder()
  }

  selectOrder(id: number) {
    this.repo.getOrder(id)
      .subscribe(res =>
        this.order = res);
        console.log(this.order);
  }

  saveOrder() {
    if (this.order.orderId == null) {
      this.repo.createOrder(this.order)
      .subscribe();
    } else {
      this.repo.updateOrder(this.order)
      .subscribe();
    }
    this.clearOrder();
  }
  clearOrder() {
    this.order = new Order();
    this.tableMode = true;
  }

  ngOnInit() {
    this.tableMode = true;
    this.repo.getOrders().subscribe(res => {
      this.orders = res;
    });
  }
}
