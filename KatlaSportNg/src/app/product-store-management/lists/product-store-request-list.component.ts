import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductStoreRequest } from '../models/product-store-request';
import { ProductStoreRequestService } from '../services/product-store-request.service';

@Component({
  selector: 'app-product-store-request-list',
  templateUrl: './product-store-request-list.component.html',
  styleUrls: ['./product-store-request-list.component.css']
})
export class ProductStoreRequestListComponent implements OnInit {

  requests: ProductStoreRequest[];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productStoreRequestService: ProductStoreRequestService
  ) { }

  ngOnInit() {
    this.route.params.subscribe(p => {      
      this.productStoreRequestService.getRequests().subscribe(r => this.requests = r);
    })
  }

  approve(requestId: number) {
    var request = this.requests.find(r => r.id == requestId);
    this.productStoreRequestService.approve(requestId).subscribe(r => {
      this.requests.splice(this.requests.indexOf(request), 1);
    });
  }

  reject(requestId: number) {
    var request = this.requests.find(r => r.id == requestId);
    this.productStoreRequestService.reject(requestId).subscribe(r => {
      this.requests.splice(this.requests.indexOf(request), 1);
    });
  }
}