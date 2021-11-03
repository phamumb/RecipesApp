import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppContainerComponent } from './containers/app-container/app-container.component';
import { HomePageComponent } from './pages/home-page/home-page.component';


const routes: Routes = [{ path: '', component: AppContainerComponent, children: [
  {path: '', component: HomePageComponent}
]}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
