import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from 'app/main-page/main-page.component';
import { HiveFormComponent } from './hive-management/forms/hive-form.component';
import { HiveSectionFormComponent } from './hive-management/forms/hive-section-form.component';
import { HiveListComponent } from './hive-management/lists/hive-list.component';
import { HiveSectionListComponent } from './hive-management/lists/hive-section-list.component';
import { ProductCategoryFormComponent } from './product-management/forms/product-category-form.component';
import { ProductFormComponent } from './product-management/forms/product-form.component';
import { ProductCategoryListComponent } from './product-management/lists/product-category-list.component';
import { ProductCategoryProductListComponent } from './product-management/lists/product-category-product-list.component';
import { ProductListComponent } from './product-management/lists/product-list.component';
import { ProductStoreListComponent } from './product-store-management/lists/product-store-list.component';
import { ProductStoreRequestComponent } from './product-store-management/forms/product-store-request-form.component'
import { ProductStoreRequestListComponent } from './product-store-management/lists/product-store-request-list.component'

const routes: Routes = [
  { path: '', redirectTo: '/main', pathMatch: 'full' },
  { path: 'main', component: MainPageComponent },
  { path: 'categories', component: ProductCategoryListComponent },
  { path: 'category', component: ProductCategoryFormComponent },
  { path: 'category/:id', component: ProductCategoryFormComponent },
  { path: 'category/:id/products', component: ProductCategoryProductListComponent },
  { path: 'products', component: ProductListComponent },
  { path: 'product/:id', component: ProductFormComponent },
  { path: 'category/:categoryId/product/:id', component: ProductFormComponent },
  { path: 'hives', component: HiveListComponent },
  { path: 'hive', component: HiveFormComponent },
  { path: 'hive/:id', component: HiveFormComponent },
  { path: 'hive/:id/sections', component: HiveSectionListComponent },
  { path: 'section/:id', component: HiveSectionFormComponent },
  { path: 'hive/:hiveId/section', component: HiveSectionFormComponent },
  { path: 'section/:hiveId/:id', component: HiveSectionFormComponent },
  { path: 'productStore/:hiveId/:hiveSectionId', component: ProductStoreListComponent },
  { path: 'productRequest/:hiveId/:sectionId/:productStoreId', component: ProductStoreRequestComponent },
  { path: 'requests', component: ProductStoreRequestListComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
