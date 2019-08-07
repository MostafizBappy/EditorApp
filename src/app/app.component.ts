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

  constructor(public authService: AuthService, private titleService: Title) { }
  ngOnInit() {
    this.titleService.setTitle(this.title);
  }
  loggedIn() {
    return this.authService.loggedIn();
  }


}
