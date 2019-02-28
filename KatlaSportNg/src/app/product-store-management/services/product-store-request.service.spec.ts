import { TestBed, inject } from '@angular/core/testing';

import { ProductStoreRequestService } from './product-store-request.service';

describe('ProductService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProductStoreRequestService]
    });
  });

  it('should be created', inject([ProductStoreRequestService], (service: ProductStoreRequestService) => {
    expect(service).toBeTruthy();
  }));
});
