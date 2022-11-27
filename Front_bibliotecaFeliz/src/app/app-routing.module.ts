import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarCategoriaComponent } from './componentes/pages/categoria/cadastrar-categoria/cadastrar-categoria.component';
import { ListarCategoriaComponent } from './componentes/pages/categoria/listar-categoria/listar-categoria.component';
import { CadastrarLivroComponent } from './componentes/pages/livro/cadastrar-livro/cadastrar-livro.component';
import { ListarLivroComponent } from './componentes/pages/livro/listar-livro/listar-livro.component';

const routes: Routes = [
  {
    path : "pages/categoria/cadastrar",
    component: CadastrarCategoriaComponent
    },
    {
      path : "pages/categoria/listar",
      component: ListarCategoriaComponent
      },
      {
        path : "pages/livro/cadastrar",
        component: CadastrarLivroComponent
      },
      {
        path : "pages/livro/listar",
        component: ListarLivroComponent
      },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
