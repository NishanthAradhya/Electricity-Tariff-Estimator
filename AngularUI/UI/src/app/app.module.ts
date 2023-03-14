import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserConsumptionComponent } from './components/consumption/user-consumption/user-consumption.component';
import { TariffProductsComponent } from './components/tariff-products/tariff-products.component';

@NgModule({
  declarations: [
    AppComponent,
    UserConsumptionComponent,
    TariffProductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
