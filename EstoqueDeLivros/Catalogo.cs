using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo : ICatalogo //interface 
    {
        //criando o metodo Get para livros e definindo qual seu retorno
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha Query?", 12.99m));
            livros.Add(new Livro("002", "Fique Rico Com C#", 30.99m));
            livros.Add(new Livro("003", "Java para baixinhos", 10.99m));
            //m para provar que é decimal

            return livros;
        }
    }
}
