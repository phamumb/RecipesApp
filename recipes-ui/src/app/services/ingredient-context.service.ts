import { AppApiService } from './app-api.service';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IngredientContextService {
  ingredients$ = new BehaviorSubject<any>([]);
  constructor(private api: AppApiService) { }

  createNewIngredient(model: any){
    return this.api.createNewIngredient(model);
  }

  getAllIngredients(){
    this.api.getAllIngredient().subscribe(ingredients => {
      this.ingredients$.next(ingredients);
    })
  }
}
