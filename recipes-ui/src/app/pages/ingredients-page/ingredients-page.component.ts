import { IngredientContextService } from './../../services/ingredient-context.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ingredients-page',
  templateUrl: './ingredients-page.component.html',
  styleUrls: ['./ingredients-page.component.scss']
})
export class IngredientsPageComponent implements OnInit {

  constructor(private context: IngredientContextService) { }

  ngOnInit(): void {
    this.context.getAllIngredients();
  }

}
