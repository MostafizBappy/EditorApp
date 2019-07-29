import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { Spinkit } from 'ng-http-loader/spinkits';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
  public spinkit = Spinkit;

  constructor(public authService: AuthService) { }
  ngOnInit() {}
  loggedIn() {
    return this.authService.loggedIn();
  }

}
