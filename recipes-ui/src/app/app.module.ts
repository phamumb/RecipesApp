import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { MultiSelectModule } from 'primeng/multiselect';
import { StepsModule } from 'primeng/steps';
import { AppRoutingModule } from './app-routing.module';
import {EditorModule} from 'primeng/editor';

import { AppComponent } from './app.component';
import { IngredientListComponent } from './components/ingredient-list/ingredient-list.component';
import { IngredientComponent } from './components/ingredient/ingredient.component';
import { NavComponent } from './components/nav/nav.component';
import { RecipesDetailIconComponent } from './components/recipes-detail-icon/recipes-detail-icon.component';
import { RecipesListComponent } from './components/recipes-list/recipes-list.component';
import { RecipesComponent } from './components/recipes/recipes.component';
import { AppContainerComponent } from './containers/app-container/app-container.component';
import { AddIngredientModalComponent } from './modals/add-ingredient-modal/add-ingredient-modal.component';
import { CreateRecipesModalComponent } from './modals/create-recipes-modal/create-recipes-modal.component';
import { IngredientModalComponent } from './modals/ingredient-modal/ingredient-modal.component';
import { CartPageComponent } from './pages/cart-page/cart-page.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { IngredientsPageComponent } from './pages/ingredients-page/ingredients-page.component';
import { RecipesEditPageComponent } from './pages/recipes-edit-page/recipes-edit-page.component';
import { RecipesPageComponent } from './pages/recipes-page/recipes-page.component';
import { AppApiService } from './services/app-api.service';
import { CartComponent } from './components/cart/cart.component';
import { IngredientPipe } from './pipes/ingredient.pipe';



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
    IngredientModalComponent,
    RecipesEditPageComponent,
    RecipesDetailIconComponent,
    AddIngredientModalComponent,
    CartComponent,
    IngredientPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    BrowserAnimationsModule,
    StepsModule,
    InputTextModule,
    ButtonModule,
    MultiSelectModule,
    EditorModule
  ],
  providers: [
    AppApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
