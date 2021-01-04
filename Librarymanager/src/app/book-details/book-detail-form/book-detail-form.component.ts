import { Component, OnInit } from '@angular/core';
import { BookDetailService } from 'src/app/shared/book-detail.service';
import {NgForm} from '@angular/forms'
import { BookDetail } from 'src/app/shared/book-detail.model';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-book-detail-form',
  templateUrl: './book-detail-form.component.html',
  styles: [
  ]
})
export class BookDetailFormComponent implements OnInit {

  constructor(public service:BookDetailService, 
   private toastr:ToastrService){ }
  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    if(this.service.formData.bookId == null)
       this.insertRecord(form);
    else
        this.updateRecord(form) ;  
  }

  insertRecord(form: NgForm){
    this.service.postBookDetail().subscribe(
      res=>{ 
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Saved successfully','Book Register')

      },
      err=>{console.log(err);}

    );

  }

  updateRecord(form: NgForm){
    this.service.putBookDetail().subscribe(
      res=>{ 
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully','Book Register')

      },
      err=>{console.log(err);}

    );

  }
  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData=new BookDetail();

  }

 }
