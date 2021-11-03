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
  ingredients$: Observable<any>;
  constructor(private context: IngredientContextService) {
    this.ingredients$ = this.context.ingredients$;
  }

  ngOnInit(): void {
  }

  openModal() {
    this.modal?.open();
  }

  addToCart(item: any){
    console.log(item)
  }

}
