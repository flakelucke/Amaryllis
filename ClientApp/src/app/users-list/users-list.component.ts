import { Component, OnInit } from '@angular/core';
import { User } from '../models/user.model';
import { Repository } from '../models/repository';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css']
})
export class UsersListComponent implements OnInit {

  displayedColumns: string[] = ['userId', 'firstName', 'lastName', 'dateOfBirth', 'dlNumber'];
  public users: User[];

  constructor(private repo: Repository) { }

  ngOnInit() {
    this.repo.getUsers().subscribe(res => {
      this.users = res;
    });
  }

}
