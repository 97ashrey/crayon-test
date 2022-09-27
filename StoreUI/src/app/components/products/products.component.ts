import { Component, OnInit } from '@angular/core';
import { Product, ProductsService } from '../../services/products.service';
import { Observable, of } from 'rxjs';
import { shareReplay, ignoreElements, catchError, delay} from 'rxjs/operators';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  public products$: Observable<Product[]>;
  public productsErrors$: Observable<any>;

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.products$ = this.productsService.getProducts().pipe(shareReplay(1));
    this.productsErrors$ = this.products$.pipe(ignoreElements(), catchError(error => of(error)))
  }
}
