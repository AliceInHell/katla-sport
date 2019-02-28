import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductStoreRequestComponent } from './product-store-request-form.component';

describe('HiveSectionFormComponent', () => {
  let component: ProductStoreRequestComponent;
  let fixture: ComponentFixture<ProductStoreRequestComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductStoreRequestComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductStoreRequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
