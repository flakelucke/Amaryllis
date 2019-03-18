import { Component, OnInit } from '@angular/core';
import { Repository } from 'src/app/models/repository';
import { ActivatedRoute, Router } from '@angular/router';
import { Order } from 'src/app/models/order.model';

@Component({
  selector: 'app-order-details',
  templateUrl: './order-details.component.html',
  styleUrls: ['./order-details.component.css']
})
export class OrderDetailsComponent implements OnInit {

  order:Order;

  constructor(private repository: Repository,
    private activeRoute: ActivatedRoute, 
    private router: Router) {
  }

  getOrder(id:number)
  {
    this.repository.getOrder(id)
    .subscribe((res)=>
    this.order=res)
  }

  ngOnInit() {
    let id = this.activeRoute.snapshot.params["id"];
    if (id) {
      this.getOrder(id);
    }
    else
    this.router.navigateByUrl("/");
  }

}
