import { CadastrarAlunoComponent } from './componentes/pages/alunos/cadastrar-aluno/cadastrar-aluno.component';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { AppComponent } from './app.component';
import { CadastrarCategoriaComponent } from './componentes/pages/categoria/cadastrar-categoria/cadastrar-categoria.component';
import { ListarCategoriaComponent } from './componentes/pages/categoria/listar-categoria/listar-categoria.component';
import { CadastrarLivroComponent } from './componentes/pages/livro/cadastrar-livro/cadastrar-livro.component';
import { ListarLivroComponent } from './componentes/pages/livro/listar-livro/listar-livro.component';
import { ListarAlunoComponent } from './componentes/pages/alunos/listar-aluno/listar-aluno.component';


@NgModule({
  declarations: [
    AppComponent,
    CadastrarCategoriaComponent,
    ListarCategoriaComponent,
    CadastrarLivroComponent,
    ListarLivroComponent,
    ListarAlunoComponent,
   CadastrarAlunoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    MatSlideToggleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
