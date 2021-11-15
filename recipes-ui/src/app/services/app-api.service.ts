import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppApiService {
  private root = '/Recipes';
  private appApi = environment.appApi;
  private url = `${this.appApi}${this.root}`;
  constructor(private http: HttpClient) { }

  // Recipes
  getAllRecipes() {
    return this.http.get(`${this.url}/GetAllRecipes`)
  }

  getAllIngredient() {
    return this.http.get(`${this.url}/GetAllIngredients`)
  }

  getSingleRecipes(id: number) {
    return this.http.get(`${this.url}/GetSingleRecipes?id=${id}`);
  }

  createRecipes(model: any) {
    return this.http.post(`${this.url}/CreateNewRecipes`, model)
  }

  addRecipesIngredients(model) {
    return this.http.post(`${this.url}/AddRecipesIngredients`, model);
  }

  getRecipesIngredients(id: number) {
    return this.http.get(`${this.url}/GetRecipesIngredients?recipesId=${id}`);
  }

  updateRecipes(model: any) {
    return this.http.post(`${this.url}/UpdateRecipes`, model);
  }

  // Ingredients
  createUpdateIngredient(model: any) {
    return this.http.post(`${this.url}/AddUpdateIngredient`, model);
  }

  getSingleIngredient(id) {
    return this.http.get(`${this.url}/GetSingleIngredient?id=${id}`);
  }

  getIngredientCategories(){
    return this.http.get(`${this.url}/GetIngredientCategories`);
  }

  // Cart
  addToCart(model: any) {
    return this.http.post(`${this.url}/AddToCart`, model);
  }
}
