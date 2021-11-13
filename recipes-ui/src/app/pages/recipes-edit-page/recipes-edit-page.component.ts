import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-recipes-edit-page',
  templateUrl: './recipes-edit-page.component.html',
  styleUrls: ['./recipes-edit-page.component.scss']
})
export class RecipesEditPageComponent implements OnInit {

  constructor(private route: ActivatedRoute, private context: RecipesContextService) { }

  ngOnInit(): void {
    this.route.params.subscribe(({ id }) => {
      this.context.recipesId$.next(id);
    })
  }

}
