import { Aluno } from "./aluno";
import { Categoria } from "./categoria";
import { Livro } from "./livro";

export interface Emprestimo{

    emprestimoId?: number;
    livroId?: number;
    livro?: Livro;
    alunoId?: number;
    aluno?: Aluno;
    categoriaId?: number;
    categoria?: Categoria;
    dataEmprestimo?: string;
}