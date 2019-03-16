import { Component, OnInit } from '@angular/core';
import { Repository } from '../models/repository';
import { Car } from '../models/car.model/car.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-cars-list',
  templateUrl: './cars-list.component.html',
  styleUrls: ['./cars-list.component.css']
})

export class CarsListComponent implements OnInit {

  displayedColumns: string[] = ['carId', 'model', 'carClass', 'whoManufacturerCar', 'registrationNumber', 'yearOfIssue'];
  public cars: Car[];

  constructor(private repo: Repository) { }


  ngOnInit() {
    this.repo.getCars().subscribe(res => {
      this.cars = res;
    });
  }

}
