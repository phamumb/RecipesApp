import { CreateRecipesModalComponent } from './../../modals/create-recipes-modal/create-recipes-modal.component';
import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.scss']
})
export class RecipesListComponent implements OnInit {
  @ViewChild('createRecipesModal') createRecipesModal: CreateRecipesModalComponent | undefined;

  recipes$: Observable<any>;
  constructor(public context: RecipesContextService, private router: Router) {
    this.recipes$ = context.list$;
  }

  ngOnInit(): void {
    this.context.getAllRecipes();
  }

  openCreateModal() {
    this.createRecipesModal?.open();
  }

  showRecipes(recipes: any) {
    this.router.navigateByUrl("/recipes/" + recipes.id)
  }

}
