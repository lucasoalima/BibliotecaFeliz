import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarCategoriaComponent } from './componentes/pages/categoria/cadastrar-categoria/cadastrar-categoria.component';
import { ListarCategoriaComponent } from './componentes/pages/categoria/listar-categoria/listar-categoria.component';

@NgModule({
  declarations: [
    AppComponent,
    CadastrarCategoriaComponent,
    ListarCategoriaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
