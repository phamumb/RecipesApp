import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppApiService {
  private root = '/App';
  private appApi = environment.appApi;
  private url = `${this.appApi}${this.root}`;
  constructor(private http: HttpClient) { }

  getAllRecipes(){
    return this.http.get(`${this.url}/GetAllRecipes`)
  }

  getAllIngredient(){
    return this.http.get(`${this.url}/GetAllIngredients`)
  }

  createNewIngredient(model: any){
    return this.http.post(`${this.url}/AddNewIngredient`, model);
  }
}
