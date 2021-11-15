import { Observable } from 'rxjs';
import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit {
  cart$ : Observable<any[]>;
  constructor(private context: RecipesContextService) { }

  ngOnInit(): void {
    this.context.getCartItems();
    this.cart$ = this.context.cart$;
  }

  remove(index){
    this.context.removeCartItem(index);
  }

}
