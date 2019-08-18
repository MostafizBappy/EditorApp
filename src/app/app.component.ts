import { User } from './_models/User';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Title } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { Spinkit } from 'ng-http-loader/spinkits';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Editorial App';
  public spinkit = Spinkit;

  constructor(public authService: AuthService, private titleService: Title,
    private jwtHelperService: JwtHelperService) { }
  ngOnInit() {
    this.titleService.setTitle(this.title);
    const token = localStorage.getItem('token');
    const user: User = JSON.parse(localStorage.getItem('user'));
    if (token) {
      this.authService.decodedToken = this.jwtHelperService.decodeToken(token);
    }
    if (user) {
      this.authService.currentUser = user;
    }
  }
  loggedIn() {
    return this.authService.loggedIn();
  }


}
