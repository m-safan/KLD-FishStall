import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageFishPriceComponent } from './manage-fish-price.component';

describe('ManageFishPriceComponent', () => {
  let component: ManageFishPriceComponent;
  let fixture: ComponentFixture<ManageFishPriceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManageFishPriceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManageFishPriceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
