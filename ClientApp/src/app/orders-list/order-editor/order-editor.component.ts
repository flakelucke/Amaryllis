import { Component, OnInit, Input } from '@angular/core';
import { Repository } from 'src/app/models/repository';
import { Order } from 'src/app/models/order.model';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/app/models/user.model';
import { Car } from 'src/app/models/car.model/car.model';

@Component({
  selector: 'app-order-editor',
  templateUrl: './order-editor.component.html',
  styleUrls: ['./order-editor.component.css']
})
export class OrderEditorComponent implements OnInit {

  constructor(private repo: Repository) {
  }

  @Input() order;

  users: User[];
  cars: Car[];

  ngOnInit() {
    this.repo.getCars()
      .subscribe(res =>
        this.cars = res);
    this.repo.getUsers()
      .subscribe(res =>
        this.users = res);
  }
}
