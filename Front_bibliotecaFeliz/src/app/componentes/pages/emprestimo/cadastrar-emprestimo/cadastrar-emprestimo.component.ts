import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Aluno } from 'src/app/models/aluno';
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
  }

  cadastrar(): void {

    let emprestimo: Emprestimo = {
      "livroId": this.livroId,
      "alunoId": this.alunoId,
      dataEmprestimo: "12/12/2002"
    };

    this.http.post<Emprestimo>("https://localhost:5001/emprestimo/emprestar", emprestimo).subscribe({   
      next : (emprestimo) => {
        this.router.navigate(["pages/emprestimo/listar"]);
      }, 
         });
    }

}