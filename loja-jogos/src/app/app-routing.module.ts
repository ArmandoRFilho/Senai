import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioComponent} from './componentes/inicio/inicio.component';
import { CadastroComponent } from './componentes/cadastro/cadastro.component';

const routes: Routes = [
  {
    path: 'inicio',
    component: InicioComponent
  },
  {
    path: 'cadastro',
    component: CadastroComponent
  },
  {
    path: 'cadastro/:id',
    component: CadastroComponent
  },
  {
    path: '',
    redirectTo: '/inicio',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
