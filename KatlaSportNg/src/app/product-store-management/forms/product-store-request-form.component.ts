import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductStoreRequestService } from '../services/product-store-request.service';
import { ProductStoreRequest } from '../models/product-store-request' 

@Component({
  selector: 'app-product-store-request-form',
  templateUrl: './product-store-request-form.component.html',
  styleUrls: ['./product-store-request-form.component.css']
})
export class ProductStoreRequestComponent implements OnInit {

  productStoreId: number;
  hiveId: number;
  sectionId: number;
  productStoreRequest = new ProductStoreRequest(0, 0, 0, false);

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productStoreRequestService: ProductStoreRequestService
  ) { }

  ngOnInit() {
    this.route.params.subscribe(p => {
      this.productStoreId = p['productStoreId'];
      this.hiveId = p['hiveId'];
      this.sectionId = p['sectionId'];
      this.productStoreRequest.productStoreId = this.productStoreId;
    });
  }

  navigateToProducts() {
    this.router.navigate([`/productStore/${this.hiveId}/${this.sectionId}`]);
  }

  onCancel() {
    this.navigateToProducts();
  }

  onSubmit() {
    this.productStoreRequestService.createRequest(this.productStoreRequest).subscribe(s => {
      this.navigateToProducts();
    });        
  }
}
