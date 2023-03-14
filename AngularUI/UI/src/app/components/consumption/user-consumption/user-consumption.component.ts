import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/consumption.model';
import { TariffsService } from 'src/app/services/tariffs.service';

@Component({
  selector: 'app-user-consumption',
  templateUrl: './user-consumption.component.html',
  styleUrls: ['./user-consumption.component.css']
})
export class UserConsumptionComponent implements OnInit {
  products:Product[]=[];
  showList:boolean=false;
  errorMessage:string=" ";
  validationError:boolean=false;
  constructor(private svc:TariffsService){}
  ngOnInit(): void {
    
  }
  estimate(data:string){
    this.svc.getEstimatedTarrif(Number(data))
    .subscribe({
      next:(data) =>{
        console.log(data);
        this.showList=true;
        this.products=data;
        this.validationError=false;
      },
      error:(res)=>{
        this.validationError=true;
        this.showList=false;
        this.errorMessage =res.error;
        console.log(res);
      }
    });
  }
}
