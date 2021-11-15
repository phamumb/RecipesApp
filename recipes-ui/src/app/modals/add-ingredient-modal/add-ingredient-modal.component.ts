import { RecipesContextService } from './../../services/recipes-context.service';
import { Observable, of } from 'rxjs';
import { IngredientContextService } from './../../services/ingredient-context.service';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-add-ingredient-modal',
  templateUrl: './add-ingredient-modal.component.html',
  styleUrls: ['./add-ingredient-modal.component.scss']
})
export class AddIngredientModalComponent implements OnInit {
  @ViewChild('modal') modal: any;
  model: any = '';
  list$: Observable<any> = of([]);
  ingredients: any[] = [];
  selectedIngredients: any[] = [];
  constructor(
    public modalService: NgbModal,
    private ingredientContext: IngredientContextService,
    private recipesContext: RecipesContextService) { }

  ngOnInit(): void {
    this.list$ = this.ingredientContext.getCategories();
  }

  open() {
    this.modalService.open(this.modal, { ariaLabelledBy: 'create-recipes-modal' }).result.then((res) => {
      console.log(res)
    }, (res) => {
      console.log(res)
    });
  }

  addIngredients() {
    var ingredients = this.selectedIngredients.map(x => {
      return {
        recipesId: this.recipesContext.recipesId$.value,
        ingredientId: x.code
      }
    })

    this.recipesContext.addRecipesIngredients(ingredients).subscribe(x => {
      this.recipesContext.refreshRecipes();
      this.modalService.dismissAll();
    })
  }

  onCategoryChange() {
  }


}
