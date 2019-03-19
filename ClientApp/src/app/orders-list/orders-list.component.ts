import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { Repository } from '../models/repository';
import { Order } from '../models/order.model';
import { Car } from '../models/car.model/car.model';
import { User } from '../models/user.model';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-orders-list',
  templateUrl: './orders-list.component.html',
  styleUrls: ['./orders-list.component.css']
})

export class OrdersListComponent implements OnInit {

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  @Input() validStates: any;

  displayedColumns: string[] = ['info', 'startOfRental', 'endOfRental', 'car.whoManufacturerCar.whoManufacturer', 'car.model.model', 'user.firstName','details'];
  orders: Order[];
  users: User[];
  cars: Car[];
  order: Order;
  tableMode: boolean;
  dataSource = new MatTableDataSource<object>(this.orders);

  constructor(private repo: Repository) {
  }

  applyFilter(filterValue: string,fromDate?:Date,toDate?:Date) {
    this.getOrders(filterValue.toLocaleUpperCase(),fromDate,toDate);
  }

  fromDateEv(event?,toDate?:Date,filterValue?:string){
    this.getOrders(filterValue,event,toDate);
  }
  toDateEv(event?,fromDate?:Date,filterValue?:string){
    this.getOrders(filterValue,fromDate,event);
  }

  deleteOrder(id: number) {
    this.repo.deleteOrder(id)
      .subscribe(() => this.getOrders());
  }

  selectOrder(id: number) {
    this.repo.getOrder(id)
      .subscribe(res =>
        this.order = res);
  }

  saveOrder() {
    if (this.order.orderId == null) {
      this.repo.createOrder(this.order)
        .subscribe(res => this.getOrders());
    } else {
      this.repo.updateOrder(this.order)
        .subscribe(() => this.getOrders());
      this.getOrders();
    }
    this.clearOrder();
  }
  getOrders(filter?:string,fromDate?:Date,toDate?:Date) {
    this.repo.getOrders(filter,fromDate,toDate).subscribe(res => {
      this.orders = res;
      this.dataSource.data = this.orders;
      this.dataSource.sort = this.sort;
    });
  }

  clearOrder() {
    this.order = new Order();
    this.tableMode = true;
  }

  ngOnInit() {
    this.tableMode = true;
    this.getOrders();
  }

  ngAfterViewInit() {
    this.dataSource.sortingDataAccessor = (item, property) => {
      if (property.includes('.')) return property.split('.').reduce((o, i) => o[i], item)
      return item[property];
    };
    this.dataSource.paginator = this.paginator;
  }
}
