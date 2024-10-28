

import { Routes } from '@angular/router';

import { ProductListComponent } from './products/product-list/product-list.component';
import { AddNewProductComponent } from './products/add-new-product/add-new-product.component';
import { ProductDetailsComponent } from './products/product-details/product-details.component';
import { UpdateProductComponent } from './products/update-product/update-product.component';
import { DeleteProductComponent } from './products/delete-product/delete-product.component';
import { ProductsComponent } from './products/products.component';

export const routes: Routes = [
     {path: 'products', component: ProductsComponent},
    {path: 'productlist', component: ProductListComponent },
    {path: 'addnewproduct', component: AddNewProductComponent },
    {path: 'productdetails', component: ProductDetailsComponent },
    {path: 'updateproduct', component: UpdateProductComponent },
    {path: 'deleteproduct', component: DeleteProductComponent },

    { path: '', redirectTo: '/products', pathMatch: 'full' },
   

];

