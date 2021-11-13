import { Observable } from 'rxjs';
import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.scss']
})
export class RecipesComponent implements OnInit {
  recipes$: Observable<any>;
  ingredients$: Observable<any>;

  units = ['Teaspoon', 'Tablespoon', 'Cup', 'Pint', 'Quart', 'Gallon']
  isEditing = false;
  constructor(public context: RecipesContextService) {
    this.recipes$ = this.context.recipes$;
    this.ingredients$ = this.context.ingredients$;
  }

  ngOnInit(): void {
    this.context.getAllRecipes();
  }

  edit() {
    this.isEditing = true;
    console.log('click')
  }

  save(model) {
    this.context.updateRecipes(model).subscribe(x => {
      if (x) {
        this.isEditing = false;
      }
    })
  }

  cancel(){
    this.isEditing = false;
  }

  editIngredient(item) {
    item.editing = true;
  }

  addToCart(item) {
    this.context.addToCart(item.ingredient);
  }

}
