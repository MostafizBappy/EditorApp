import { Component, OnInit } from '@angular/core';
import { AlertifyService } from './../_services/alertify.service';
import { AuthService } from './../_services/auth.service';
import { Router } from '@angular/router';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  model: any = {};
  constructor(private authService: AuthService,
    private alertifyService: AlertifyService,
    private router: Router,
    private titleService: Title) { }

  ngOnInit() {
    this.titleService.setTitle('Home');
  }

  login() {
    this.authService.login(this.model).subscribe(data => {
      this.alertifyService.success('Logged in successfully');
    }, error => {
      this.alertifyService.error('Log in failed.');
    }, () => {
      this.router.navigate(['/home']);
    });
  }

  logout() {
    this.authService.userToken = null;
    localStorage.removeItem('token');
    this.alertifyService.message('Logged out');
    this.router.navigate(['/home']);
  }

  loggedIn() {
    return this.authService.loggedIn();
  }
}
