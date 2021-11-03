import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.scss']
})
export class RecipesComponent implements OnInit {

  constructor(private context: RecipesContextService) { }

  ngOnInit(): void {
    this.context.getAllRecipes();
  }

}
