import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserConsumptionComponent } from './user-consumption.component';

describe('UserConsumptionComponent', () => {
  let component: UserConsumptionComponent;
  let fixture: ComponentFixture<UserConsumptionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserConsumptionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserConsumptionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
