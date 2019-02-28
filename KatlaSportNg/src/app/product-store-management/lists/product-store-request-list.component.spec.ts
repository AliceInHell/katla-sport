import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductStoreRequestListComponent } from './product-store-request-list.component';

describe('ProductListComponent', () => {
  let component: ProductStoreRequestListComponent;
  let fixture: ComponentFixture<ProductStoreRequestListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductStoreRequestListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductStoreRequestListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
