using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Livro
    {
        public Livro(int id, string codigo, string titulo, string autor)
        {
            IdLivro = id;
            CodigoLivro = codigo;
            TituloLivro = titulo;
            AutorLivro = autor;
        }

        const int tamanhoCodigo = 6;
        const int tamanhoTitulo = 50;
        const int tamanhoAutor = 50;

        int idLivro;
        string codigoLivro;
        string tituloLivro;
        string autorLivro;

        public int IdLivro
        {
            get { return idLivro; }
            set {
                if (value < 0)
                    throw new Exception("Id negativo é inválido");

                idLivro = value; }
        }

        public string CodigoLivro
        {
            get { return codigoLivro; }
            set {

                //Remove qualquer caracter além do tamanho máximo do campo
               //value = value.Remove(tamanhoCodigo);
                if (value.Length > 6)
                    throw new Exception("Código do livro deve ter apenas 6 caracteres");

                //Preenche codigo com zeros à esquerda até completar o máximo
                value = value.PadLeft(tamanhoCodigo, '0');

                codigoLivro = value; }
        }   

        public string TituloLivro
        {
            get { return tituloLivro; }
            set {
                //value = value.Remove(tamanhoTitulo);

                value = value.PadRight(tamanhoTitulo, ' ');

                tituloLivro = value;

            }
        } 

        public string AutorLivro
        {
            get { return autorLivro; }
            set {
                //value = value.Remove(tamanhoAutor);
                value = value.PadRight(tamanhoAutor, ' ');

                autorLivro = value; }
        }
    }
}
