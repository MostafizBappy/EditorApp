import { AuthUser } from './../_models/AuthUser';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { User } from '../_models/User';
import { JwtHelperService } from '@auth0/angular-jwt';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Injectable()
export class AuthService {
  baseUrl = environment.apiUrl;
  userToken: any;
  currentUser: User;
  decodedToken: any;

  constructor(private http: HttpClient, private jwtHealperService: JwtHelperService) {}


  login(model: any) {
    return this.http.post<AuthUser>(this.baseUrl + 'auth/login', model, {headers: new HttpHeaders()
      .set('Content-Type', 'application/json')})
      .map(user => {
        if (user && user.tokenString) {
            localStorage.setItem('token', user.tokenString);
            localStorage.setItem('user', JSON.stringify(user.user));
            this.decodedToken = this.jwtHealperService.decodeToken(user.tokenString);
            this.currentUser = user.user;
            console.log(this.decodedToken);
            this.userToken = user.tokenString;
        }
    });
  }

  loggedIn() {
    const token = this.jwtHealperService.tokenGetter();

    if (!token) {
      return false;
    }

    return !this.jwtHealperService.isTokenExpired(token);
  }
}
