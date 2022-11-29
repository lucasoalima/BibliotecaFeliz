import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Aluno } from 'src/app/models/aluno';

@Component({
  selector: 'app-cadastrar-aluno',
  templateUrl: './cadastrar-aluno.component.html',
  styleUrls: ['./cadastrar-aluno.component.css']
})
export class CadastrarAlunoComponent implements OnInit {

  
  nomeAluno!: string;
  telefone!: string;
  email!: string;
  alunos!: Aluno[];
  rgm!: string;
  alunoId!: number;

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit(): void {
    this.http.get<Aluno[]>("https://localhost:5001/api/aluno/cadastrar").subscribe({
      next: (alunos) => {
        this.alunos = alunos;
      },
    });
  }

  cadastrar(): void {
    console.log(this.alunoId);
   // let dataConvertida = new Date(this.data);

    let aluno: Aluno = {
      nomeAluno: this.nomeAluno,
      telefone: this.telefone,
      email: this.email,
      alunoId: this.alunoId,
      rgm: this.rgm
    };

    this.http.post<Aluno>("https://localhost:5001/api/aluno/cadastrar", aluno).subscribe({
      next: (aluno) => {
        this.router.navigate(["pages/aluno/cadastrar"]);
      },
    });
  }

}
