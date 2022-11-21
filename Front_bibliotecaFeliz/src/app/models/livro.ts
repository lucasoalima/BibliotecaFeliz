import { Categoria } from "./categoria";

export interface Livro{

    id?: number;
    nomeLivro?: string;
    quantidadeEstoque: number;
    autor: string;
    categorias_ID: number;
    categoria: Categoria;
}