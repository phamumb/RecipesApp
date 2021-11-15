import { of } from 'rxjs';
import { IngredientContextService } from './../services/ingredient-context.service';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'ingredient'
})
export class IngredientPipe implements PipeTransform {
  constructor(private ingredientContext: IngredientContextService){

  }

  transform(value: unknown, ...args: unknown[]): unknown {
    if(args[0] != undefined){
      return this.ingredientContext.getSingleIngredient(args[0]);
    }else{
      return of({})
    }
  }

}
