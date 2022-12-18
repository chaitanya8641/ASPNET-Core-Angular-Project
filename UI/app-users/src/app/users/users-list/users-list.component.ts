import { Component, OnInit, ViewChild } from '@angular/core';
import { UserService } from '../../shared/user.service';
import { user } from './../../models/user';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css'],
})
export class UsersListComponent implements OnInit {
  displayedColumns = ['fullName', 'email', 'status'];
  users: MatTableDataSource<user> = new MatTableDataSource();
  isLoading = true;
  searchKey!: string;

  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(private service: UserService) {}

  ngOnInit() {
    this.service.getAllUsers().subscribe((data) => {
      this.users = data;
      this.users = new MatTableDataSource(data);
      this.users.paginator = this.paginator;
      this.users.sort = this.sort;
      this.isLoading = false;
    });
  }

  onSearchClear() {
    this.searchKey = '';
    this.applyFilter();
  }

  applyFilter() {
    this.users.filter = this.searchKey.trim().toLowerCase();
  }
}
