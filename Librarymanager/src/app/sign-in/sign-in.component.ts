import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserDetailService } from '../shared/user-detail.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
 

  constructor(public  service:UserDetailService, private router:Router) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  onSubmit(from:NgForm){
    for(let uds of this.service.list){
      if(this.service.userName== uds.userName && this.service.password == uds.password)
       this.router.navigateByUrl('book-detail');
    
      else{
      alert('eneter valid username & password');
      }
    }
  }
 
}
