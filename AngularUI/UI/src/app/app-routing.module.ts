import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserConsumptionComponent } from './components/consumption/user-consumption/user-consumption.component';

const routes: Routes = [
  {
    path:'',
    component: UserConsumptionComponent
  },
  {
    path:'estimate',
    component: UserConsumptionComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
