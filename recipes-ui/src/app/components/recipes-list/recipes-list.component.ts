import { CreateRecipesModalComponent } from './../../modals/create-recipes-modal/create-recipes-modal.component';
import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.scss']
})
export class RecipesListComponent implements OnInit {
  @ViewChild('modal') modal: CreateRecipesModalComponent | undefined;

  recipes$: Observable<any>;
  constructor(private context: RecipesContextService) {
    this.recipes$ = this.context.recipes$;
  }

  ngOnInit(): void {
  }

  openModal() {
    this.modal?.open();
  }

}
