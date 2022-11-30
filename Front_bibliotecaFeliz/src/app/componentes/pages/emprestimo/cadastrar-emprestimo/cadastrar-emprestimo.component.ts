import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Aluno } from 'src/app/models/aluno';
import { Categoria } from 'src/app/models/categoria';
import { Emprestimo } from 'src/app/models/emprestimo';
import { Livro } from 'src/app/models/livro';

@Component({
  selector: 'app-cadastrar-emprestimo',
  templateUrl: './cadastrar-emprestimo.component.html',
  styleUrls: ['./cadastrar-emprestimo.component.css']
})
export class CadastrarEmprestimoComponent implements OnInit {

  livroId!: number;
  alunoId!: number;
  emprestimos!: Emprestimo[];
  alunos!: Aluno[];
  livros!: Livro[];
  categorias!: Categoria[];
  categoriaId!: number;

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit(): void {
    //Configurando a requisição para a API
    this.http.
      get<Aluno[]>(
        "https://localhost:5001/api/aluno/listar"
      )
      // Executar a requisição
      .subscribe({
        next: (alunos) => {
          this.alunos = alunos;
        }
      });

      this.http.
      get<Livro[]>(
        "https://localhost:5001/api/livro/Listar"
      )
      // Executar a requisição
      .subscribe({
        next: (livros) => {
          this.livros = livros;
        }
      });
      this.http.
      get<Categoria[]>(
        "https://localhost:5001/api/categoria/listar"
      )
      // Executar a requisição
      .subscribe({
        next: (categorias) => {
          this.categorias = categorias;
        }
      });
  }

  cadastrar(): void {
    console.log(this.livroId);
    console.log(this.alunoId);
    console.log(this.categoriaId);

    let emprestimo: Emprestimo = {
      "livroId": this.livroId,
      "alunoId": this.alunoId,
      "categoriaId": this.categoriaId,
      dataEmprestimo: "2022-11-30T21:08:26.645Z"
    };

    this.http.post<Emprestimo>("https://localhost:5001/emprestimo/emprestar", emprestimo).subscribe({   
      next : (emprestimo) => {
        this.router.navigate(["pages/emprestimo/listar"]);
      }, 
         });
    }

}
