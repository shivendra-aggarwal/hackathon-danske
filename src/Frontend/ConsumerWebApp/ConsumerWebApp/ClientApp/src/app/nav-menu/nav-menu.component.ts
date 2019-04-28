import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  public userloggedIn: boolean = false;
  public userEmail: string = '';
  public displayLogin: boolean = false;
  ngOnInit(): void {
    if (localStorage.getItem("email") != null) {
      this.userloggedIn = true;
      this.userEmail = localStorage.getItem("email");

    }
    else {
      this.userloggedIn = false;
      this.userEmail = '';
    }

  }
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  login(value: boolean) {
    if (value) {
      if (this.userEmail && this.userEmail != '') {
        localStorage.setItem("email", this.userEmail);
        this.userloggedIn = true;
        if (this.userEmail == 'singhal.s01@gmail.com')
          localStorage.setItem("userId", "1");
        if (this.userEmail == 'tn.prashant@gmail.com')
          localStorage.setItem("userId", "2");
        if (this.userEmail == 'shivendra.aggarwal@gmail.com')
          localStorage.setItem("userId", "3");
      }
      this.displayLogin = false;
      
    }
    else {
      this.displayLogin = true;
    }
  }
  logout() {
    localStorage.removeItem('email');
    localStorage.removeItem("userId");
    this.userloggedIn = false;
    this.userEmail = "";
  }
  cancel() {
    this.displayLogin = false;
    this.userEmail = "";
  }
}
