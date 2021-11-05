import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.scss']
})
export class RecipesComponent implements OnInit {
  items: MenuItem[];
  constructor(private context: RecipesContextService) { }

  ngOnInit(): void {
    this.context.getAllRecipes();
    this.items = [
      {label: 'Step 1'},
      {label: 'Step 2'},
      {label: 'Step 3'}
  ];
  }

}
