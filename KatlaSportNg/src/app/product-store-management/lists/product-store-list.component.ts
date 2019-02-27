import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductStoreItem } from '../models/product-store';
import { ProductStoreService } from '../services/product-store.service';

@Component({
  selector: 'app-product-store-list',
  templateUrl: './product-store-list.component.html',
  styleUrls: ['./product-store-list.component.css']
})
export class ProductStoreListComponent implements OnInit {

  hiveId: number;
  hiveSectionId: number;
  storeItems: ProductStoreItem[];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productStoreService: ProductStoreService
  ) { }

  ngOnInit() {
    this.route.params.subscribe(p => {
      this.hiveId = p['hiveId'];
      this.hiveSectionId = p['hiveSectionId'];
      this.productStoreService.getSectionProducts(this.hiveSectionId).subscribe(i => this.storeItems = i);
    })
  }  

  navigateToHiveSections() {
    if (this.hiveSectionId === undefined) {
      this.router.navigate(['/hives']);
    } else {
      this.router.navigate([`/hive/${this.hiveId}/sections`]);
    }
  }

  onCancel() {
    this.navigateToHiveSections();
  }
}