import { IngredientContextService } from './../../services/ingredient-context.service';
import { IngredientModalComponent } from './../../modals/ingredient-modal/ingredient-modal.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-ingredient-list',
  templateUrl: './ingredient-list.component.html',
  styleUrls: ['./ingredient-list.component.scss']
})
export class IngredientListComponent implements OnInit {
  @ViewChild('modal') modal: IngredientModalComponent | undefined;
  amount: string = '';
  items$: Observable<any>;
  categories$: Observable<any>;
  constructor(private context: IngredientContextService) {
    this.items$ = this.context.list$;
    this.categories$ = this.context.getCategories();
  }

  ngOnInit(): void {
  }

  openModal() {
    this.modal?.open();
  }

  searchIngredient(value){
    this.context.search(value);
  }

  filterCategory(value){
    this.context.searchCategory(value);
  }

}
