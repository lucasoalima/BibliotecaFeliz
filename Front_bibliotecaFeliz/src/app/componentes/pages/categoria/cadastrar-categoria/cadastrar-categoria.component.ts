import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Categoria } from 'src/app/models/categoria';
import { Livro } from 'src/app/models/livro';

@Component({
  selector: 'app-cadastrar-categoria',
  templateUrl: './cadastrar-categoria.component.html',
  styleUrls: ['./cadastrar-categoria.component.css']
})
export class CadastrarCategoriaComponent implements OnInit {

  NomeCategoria!: string;
  QtdEstoqueCategoria!: number;
  mensagem!: string;
  CategoriaId!: string;

  constructor(private http : HttpClient, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe({
      next: (params) => {
  
      let {CategoriaId} = params;
      /*this.CategoriaId = CategoriaId;
      this.NomeCategoria = "skjdksld";*/
  
      console.log(CategoriaId);
  
      if(CategoriaId != undefined){
  
        this.http.get<Categoria>(`https://localhost:5001/api/categoria/buscar/${CategoriaId}`).subscribe({
          next : (categoria) => {
            this.CategoriaId = CategoriaId;
            this.NomeCategoria = categoria.nomeCategoria;
            this.QtdEstoqueCategoria =  categoria.qtdEstoqueCategoria;
          }, 
        })
      }
      }
    })
  }

  alterar(): void{
    let categoria: Categoria = {
      categoriaId: Number.parseInt(this.CategoriaId),
      nomeCategoria: this.NomeCategoria,
      qtdEstoqueCategoria: this.QtdEstoqueCategoria,
     };


     
    this.http.patch<Categoria>("https://localhost:5001/api/categoria/alterar", categoria).subscribe({
      next : (categoria) => {
        this.router.navigate(["pages/categoria/listar"]);
      }, 
    });
  }

  cadastrar(): void {
    let categoria: Categoria = {
     nomeCategoria: this.NomeCategoria,
     qtdEstoqueCategoria: this.QtdEstoqueCategoria,
    };

    this.http.post<Categoria>("https://localhost:5001/api/categoria/cadastrar", categoria).subscribe({
      next : (categoria) => {
        console.log("Gravmos um func", categoria);
        this.router.navigate(["pages/categoria/listar"]);
      }, 
      error: (error) => {

        if(error.status === 400)
        {
          this.mensagem =
          "Algum erro de validação se deu";          
        }else if(error.status === 0){
          this.mensagem = "Rode a sua API!"
        }

        
      }
    });
  

    // this.soma = Number.parseInt (this.numero1) + Number.parseInt(this.numero2);
  }

}
