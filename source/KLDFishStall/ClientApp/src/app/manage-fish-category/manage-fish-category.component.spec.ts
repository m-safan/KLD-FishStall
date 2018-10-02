import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageFishCategoryComponent } from './manage-fish-category.component';

describe('ManageFishCategoryComponent', () => {
  let component: ManageFishCategoryComponent;
  let fixture: ComponentFixture<ManageFishCategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManageFishCategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManageFishCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
