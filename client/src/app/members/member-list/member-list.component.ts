import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  users: any;
  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers() {
    this.accountService.getUsers().subscribe(users => {
      this.users = users;

    }, error => {
      console.log(error);
    });
  }

}
