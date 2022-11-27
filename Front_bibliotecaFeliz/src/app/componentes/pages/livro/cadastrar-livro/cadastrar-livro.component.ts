import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Categoria } from 'src/app/models/categoria';
import { Livro } from 'src/app/models/livro';

@Component({
  selector: 'app-cadastrar-livro',
  templateUrl: './cadastrar-livro.component.html',
  styleUrls: ['./cadastrar-livro.component.css']
})
export class CadastrarLivroComponent implements OnInit {

  nomeLivro!: string;
  quantidadeEstoque!: number;
  autor!: string;
  categorias!: Categoria[];
  categoriaId!: number;

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit(): void {
    this.http.get<Categoria[]>("https://localhost:5001/api/categoria/listar").subscribe({
      next: (categorias) => {
        this.categorias = categorias;
      },
    });
  }

  cadastrar(): void {
    console.log(this.categoriaId);
   // let dataConvertida = new Date(this.data);

    let livro: Livro = {
      nomeLivro: this.nomeLivro,
      quantidadeEstoque: this.quantidadeEstoque,
      autor: this.autor,
      categorias_ID: this.categoriaId,
    };

    this.http.post<Livro>("https://localhost:5001/api/livro/cadastrar", livro).subscribe({
      next: (livro) => {
        this.router.navigate(["pages/livro/listar"]);
      },
    });
  }

}
