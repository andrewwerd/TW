import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserForLogin } from '../_models/account/userForLogin';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';
import { ValidationErrors } from '@angular/forms';

import { map, first } from 'rxjs/operators';

import { environment } from '../../environments/environment';
import { User } from '../_models/account/user';
import { Router } from '@angular/router';
import { CustomerForRegistration } from '../_models/customer/customerForRegistration';
import { PartnerForRegistration } from '../_models/partners/partnerForRegistration';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  private baseUrl = environment.apiUrl + 'account/';
  private jwtService = new JwtHelperService();
  private currentUserSubject: BehaviorSubject<User>;
  private validationResultSubject: Subject<ValidationErrors>;
  currentUser: Observable<User>;

  constructor(private http: HttpClient, private router: Router) {
    this.validationResultSubject = new Subject<ValidationErrors>();
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): User {
    return this.currentUserSubject.value;
  }

  // login
  isLoggedIn(): boolean {
    const token = localStorage.getItem('accessToken');
    return token ? true : false;
  }

  login(userForLogin: UserForLogin) {
    return this.http.post<any>(this.baseUrl + 'login/', userForLogin)
      .pipe(map((loginResult) => {
        if (loginResult.accessToken) {
          const curUser = this.jwtService.decodeToken(loginResult.accessToken);
          curUser.token = loginResult.accessToken;
          localStorage.setItem('accessToken', JSON.stringify(loginResult.accessToken));
          this.currentUserSubject.next(curUser);
          localStorage.setItem('currentUser', JSON.stringify(curUser));
        }
        return loginResult;
      }));
  }

  logout() {
    localStorage.removeItem('currentUser');
    localStorage.removeItem('accessToken');
    this.currentUserSubject.next(null);
    this.router.navigate(['/login']);
  }

  // registration
  validateName(userName: string): Observable<ValidationErrors> {
    return this.http.get<ValidationErrors>(this.baseUrl + 'validateUserName', { params: { userName } });
  }

  validateEmail(email: string): Observable<ValidationErrors> {
    return this.http.get<ValidationErrors>(this.baseUrl + 'validateEmail', { params: { email } });
  }

  customerRegistration( customer: CustomerForRegistration){
    return this.http.post<boolean>(this.baseUrl + 'customerRegistration', customer);
  }
  partnerRegistration( partner: PartnerForRegistration){
    return this.http.post<boolean>(this.baseUrl + 'partnerRegistration', partner);
  }
}
