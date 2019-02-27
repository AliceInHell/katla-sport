import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductStoreItem } from '../models/product-store';
import { ProductStoreService } from '../services/product-store.service';

@Component({
  selector: 'app-product-ыещку-list',
  templateUrl: './product-store-list.component.html',
  styleUrls: ['./product-store-list.component.css']
})
export class ProductStoreListComponent implements OnInit {

  hiveSectionId: number;
  storeItems: ProductStoreItem[];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productStoreService: ProductStoreService
  ) { }

  ngOnInit() {
    this.route.params.subscribe(p => {
      this.hiveSectionId = p['hiveSectionId'];
      this.productStoreService.getSectionProducts(this.hiveSectionId).subscribe(i => this.storeItems = i);
    })
  }
}