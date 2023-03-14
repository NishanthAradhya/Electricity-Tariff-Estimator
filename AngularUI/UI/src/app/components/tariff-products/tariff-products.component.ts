import { Component, Input, OnInit } from '@angular/core';
import { Product } from 'src/app/models/consumption.model';

@Component({
  selector: 'app-tariff-products',
  templateUrl: './tariff-products.component.html',
  styleUrls: ['./tariff-products.component.css']
})
export class TariffProductsComponent implements OnInit {
  ngOnInit(): void {
    console.log()
  }
  @Input() productList :Product[]= [];
}
