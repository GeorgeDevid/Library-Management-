import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserDetail } from './user-detail.model';

@Injectable({
  providedIn: 'root'
})
export class UserDetailService {

  readonly baseURL ='http://localhost:53031/api/Logindetails'

  list : UserDetail[];
  
  userName:string;
  password: string;

  

  constructor(private http:HttpClient) { }

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as UserDetail[]);
  }
}
