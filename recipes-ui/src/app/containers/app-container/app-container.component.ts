import { Observable } from 'rxjs';
import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-app-container',
  templateUrl: './app-container.component.html',
  styleUrls: ['./app-container.component.scss']
})
export class AppContainerComponent implements OnInit {
  constructor(private context: RecipesContextService) { }

  ngOnInit() {
  }

}
