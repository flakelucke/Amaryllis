import { Component, OnInit, ViewChild } from '@angular/core';
import { Repository } from '../models/repository';
import { Car } from '../models/car.model/car.model';
import { Observable } from 'rxjs';
import { MatTableDataSource, MatPaginator, MatSort } from '@angular/material';

@Component({
  selector: 'app-cars-list',
  templateUrl: './cars-list.component.html',
  styleUrls: ['./cars-list.component.css']
})

export class CarsListComponent implements OnInit {

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  displayedColumns: string[] = ['carId', 'model.model', 'carClass.className', 'whoManufacturerCar.whoManufacturer', 'registrationNumber', 'yearOfIssue'];
  public cars: Car[];
  dataSource = new MatTableDataSource<object>(this.cars);

  constructor(private repo: Repository) { }


  ngOnInit() {
    this.repo.getCars().subscribe(res => {
      this.cars = res;
      this.dataSource.data = this.cars;
    });
    this.dataSource.sortingDataAccessor = (item, property) => {
      if (property.includes('.')) return property.split('.').reduce((o, i) => o[i], item)
      return item[property];
    };
    this.dataSource.sort = this.sort;
  }
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
}
