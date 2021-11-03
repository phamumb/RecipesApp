import { AppApiService } from './services/app-api.service';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { AppContainerComponent } from './containers/app-container/app-container.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { RecipesPageComponent } from './pages/recipes-page/recipes-page.component';
import { IngredientsPageComponent } from './pages/ingredients-page/ingredients-page.component';
import { CartPageComponent } from './pages/cart-page/cart-page.component';
import { IngredientComponent } from './components/ingredient/ingredient.component';
import { HttpClientModule } from '@angular/common/http';
import { RecipesComponent } from './components/recipes/recipes.component';
import { RecipesListComponent } from './components/recipes-list/recipes-list.component';
import { CreateRecipesModalComponent } from './modals/create-recipes-modal/create-recipes-modal.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { IngredientListComponent } from './components/ingredient-list/ingredient-list.component';
import { IngredientModalComponent } from './modals/ingredient-modal/ingredient-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    AppContainerComponent,
    HomePageComponent,
    NavComponent,
    RecipesPageComponent,
    IngredientsPageComponent,
    CartPageComponent,
    IngredientComponent,
    RecipesComponent,
    RecipesListComponent,
    CreateRecipesModalComponent,
    IngredientListComponent,
    IngredientModalComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [
    AppApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
