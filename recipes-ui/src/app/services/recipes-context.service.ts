import { AppApiService } from './app-api.service';
import { Injectable } from '@angular/core';
import { BehaviorSubject, forkJoin, zip } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecipesContextService {
  // recipes
  list$ = new BehaviorSubject<any>([]);
  recipes$ = new BehaviorSubject<any>(null);
  ingredients$ = new BehaviorSubject<any>(null);
  recipesId$ = new BehaviorSubject<number>(null);
  icons = [
    { icon: 'fa-stopwatch', color: '#57b885', backgroundColor: '#ddf1e6' },
    { icon: 'fa-fire', color: '#ff2626', backgroundColor: '#ff8886' },
    { icon: 'fa-user', color: '#fbb148', backgroundColor: '#feefda' }
  ]

  // cart
  cart$ = new BehaviorSubject<any[]>([]);

  constructor(private api: AppApiService) {
    this.recipesId$.subscribe(id => {
      if (id != null) {
        this.getSingleRecipes(id);
      }
    })
  }

  getAllRecipes() {
    this.api.getAllRecipes().subscribe(recipes => {
      this.list$.next(recipes);
    })
  }

  refreshRecipes() {
    this.recipesId$.next(this.recipesId$.value);
  }

  getSingleRecipes(id: number) {
    zip(this.api.getSingleRecipes(id), this.api.getRecipesIngredients(id))
      .subscribe(([recipes, ingredients]) => {
        this.recipes$.next(recipes);
        this.ingredients$.next(ingredients)
      })
  }

  createRecipes(model: any) {
    return this.api.createRecipes(model);
  }

  addRecipesIngredients(model: any) {
    return this.api.addRecipesIngredients(model);
  }

  updateRecipes(model: any) {
    return this.api.updateRecipes(model);
  }

  getCartItems() {
    let items = JSON.parse(localStorage.getItem('cart'))
    if(items != null){
      this.cart$.next(items);
    }
  }

  removeCartItem(index){
    let items = this.cart$.value;
    items.splice(index, 1);
    this.saveToCart(items);
  }

  addToCart(ingredient) {
    let items = this.cart$.value;
    let existedItem = items.find(x => x.ingredientId == ingredient.id);
    if(existedItem){
      existedItem.quantity += 1;
    }else{
      items.push({
        ingredientId: ingredient.id,
        quantity: 1,
      });
    }
    this.saveToCart(items);
  }

  saveToCart(items){
    this.cart$.next(items);
    localStorage.setItem('cart', JSON.stringify(items));
  }
}
