import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/models/aluno';

@Component({
  selector: 'app-listar-aluno',
  templateUrl: './listar-aluno.component.html',
  styleUrls: ['./listar-aluno.component.css']
})
export class ListarAlunoComponent implements OnInit {
  alunos!: Aluno[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {

//Configuração da requisição
this.http
.get<Aluno[]>("https://localhost:5001/aluno/listar")
// Execução da requisição
.subscribe({
  next: (alunos) => {
    // console.table(funcionarios);
    this.alunos = alunos;
  },
  });
  }

}
