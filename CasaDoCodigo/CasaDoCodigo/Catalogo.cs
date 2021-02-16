using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class Catalogo
    {

       public List<Livr> GetLivros()
        {
            var livros = new List<Livr>();
            livros.Add(new Livr("001", "Quem mexeu na query?", 12.22m));
            livros.Add(new Livr("002", "Quem mexeu no meu código?", 15.22m));
            livros.Add(new Livr("003", "Quem mexeu no meu repositório?", 20.22m));

            return livros;
        }
    }
}
