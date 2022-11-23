import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Categoria } from 'src/app/models/categoria';

@Component({
  selector: 'app-listar-categoria',
  templateUrl: './listar-categoria.component.html',
  styleUrls: ['./listar-categoria.component.css']
})
export class ListarCategoriaComponent implements OnInit {

  categorias! : Categoria[];

  constructor(private http : HttpClient) { }

  ngOnInit(): void {

    this.http.get<Categoria[]>("https://localhost:5001/api/categoria/listar").subscribe({
        next : (categorias) => {
        //  console.table(categorias);

          this.categorias = categorias;

        }
        
      });

  }

  remover(id: number): void{

    this.http.delete<Categoria[]>("https://localhost:5001/api/categoria/deletar/" + id).subscribe({
      next : (categoria) => {
      //  console.table(categorias);

      this.ngOnInit();

      }
      
    })

  }

}
