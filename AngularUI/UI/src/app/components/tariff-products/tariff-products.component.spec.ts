import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TariffProductsComponent } from './tariff-products.component';

describe('TariffProductsComponent', () => {
  let component: TariffProductsComponent;
  let fixture: ComponentFixture<TariffProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TariffProductsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TariffProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
