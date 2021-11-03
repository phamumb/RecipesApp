import { CartPageComponent } from './pages/cart-page/cart-page.component';
import { IngredientsPageComponent } from './pages/ingredients-page/ingredients-page.component';
import { RecipesPageComponent } from './pages/recipes-page/recipes-page.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppContainerComponent } from './containers/app-container/app-container.component';
import { HomePageComponent } from './pages/home-page/home-page.component';


const routes: Routes = [{
  path: '', component: AppContainerComponent, children: [
    { path: '', component: HomePageComponent },
    { path: 'recipes', component: RecipesPageComponent },
    { path: 'ingredients', component: IngredientsPageComponent },
    { path: 'cart', component: CartPageComponent }
  ]
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
