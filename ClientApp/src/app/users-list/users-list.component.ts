import { Component, OnInit, ViewChild } from '@angular/core';
import { User } from '../models/user.model';
import { Repository } from '../models/repository';
import { MatSort, MatPaginator, MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css']
})
export class UsersListComponent implements OnInit {

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  displayedColumns: string[] = ['userId', 'firstName', 'lastName', 'dateOfBirth', 'dlNumber'];
  public users: User[];
  dataSource = new MatTableDataSource<object>(this.users);

  constructor(private repo: Repository) { }

  ngOnInit() {
    this.repo.getUsers().subscribe(res => {
      this.users = res;
      this.dataSource.data = this.users;
    });
    this.dataSource.sort = this.sort;
  }
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
}
