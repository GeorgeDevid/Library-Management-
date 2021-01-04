import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookDetailsComponent } from './book-details/book-details.component';
import { SignInComponent } from './sign-in/sign-in.component';


const routes: Routes = [ 


  { path : '', redirectTo:'login', pathMatch : 'full'},
  {component:SignInComponent,path:'login'},

  {component:BookDetailsComponent,path:'book-detail'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
