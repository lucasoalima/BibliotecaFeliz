import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Emprestimo } from 'src/app/models/emprestimo';

@Component({
  selector: 'app-listar-emprestimo',
  templateUrl: './listar-emprestimo.component.html',
  styleUrls: ['./listar-emprestimo.component.css']
})
export class ListarEmprestimoComponent implements OnInit {

  constructor(private http: HttpClient) { }

  emprestimos!: Emprestimo[];

  ngOnInit(): void {
      //Configuração da requisição
      this.http
      .get<Emprestimo[]>("https://localhost:5001/emprestimo/listar")
      // Execução da requisição
      .subscribe({
        next: (emprestimos) => {
          // console.table(funcionarios);
          this.emprestimos = emprestimos;
        },
      });
  }

}
