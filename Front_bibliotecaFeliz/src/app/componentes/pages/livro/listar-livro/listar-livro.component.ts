import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Livro } from 'src/app/models/livro';

@Component({
  selector: 'app-listar-livro',
  templateUrl: './listar-livro.component.html',
  styleUrls: ['./listar-livro.component.css']
})
export class ListarLivroComponent implements OnInit {
  livros!: Livro[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {

//Configuração da requisição
this.http
.get<Livro[]>("https://localhost:5001/api/livro/Listar")
// Execução da requisição
.subscribe({
  next: (livros) => {
    // console.table(funcionarios);
    this.livros = livros;
  },
  });
  }

}
