import { CadastrarAlunoComponent } from './componentes/pages/alunos/cadastrar-aluno/cadastrar-aluno.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarCategoriaComponent } from './componentes/pages/categoria/cadastrar-categoria/cadastrar-categoria.component';
import { ListarCategoriaComponent } from './componentes/pages/categoria/listar-categoria/listar-categoria.component';
import { CadastrarLivroComponent } from './componentes/pages/livro/cadastrar-livro/cadastrar-livro.component';
import { ListarLivroComponent } from './componentes/pages/livro/listar-livro/listar-livro.component';
import { ListarAlunoComponent } from './componentes/pages/alunos/listar-aluno/listar-aluno.component';
import { CadastrarEmprestimoComponent } from './componentes/pages/emprestimo/cadastrar-emprestimo/cadastrar-emprestimo.component';
import { ListarEmprestimoComponent } from './componentes/pages/emprestimo/listar-emprestimo/listar-emprestimo.component';


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
      {
        path : "pages/aluno/listar",
        component: ListarAlunoComponent
      },
      {
        path : "pages/aluno/cadastrar",
        component: CadastrarAlunoComponent
      },
      {
        path : "pages/emprestimo/cadastrar",
        component: CadastrarEmprestimoComponent
      },
      {
        path : "pages/emprestimo/listar",
        component: ListarEmprestimoComponent
      },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
