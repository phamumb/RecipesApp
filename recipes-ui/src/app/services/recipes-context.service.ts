import { AppApiService } from './app-api.service';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecipesContextService {
  recipes$ = new BehaviorSubject<any>([]);
  constructor(private api: AppApiService) { }

  getAllRecipes(){
    this.api.getAllRecipes().subscribe(recipes => {
      this.recipes$.next(recipes);
    })
  }

  createRecipes(model: any){
    return this.api.createRecipes(model);
  }
}
