using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Ex_01
{
    class BDDicionario : IDatabase
    {
        private static Dictionary<long, Livro> livros = new Dictionary<long, Livro>();
        private static int i = 0;

        public void Delete(long codigo)
        {
            livros.Remove(codigo);
        }

        public List<Livro> ListAll()
        {
            return livros.Values.ToList<Livro>();
        }

        public Livro Read(long codigo)
        {
            return livros[codigo];
        }

        public void Save(Livro l)
        {
            l.Codigo = i++;
            livros.Add(l.Codigo,l);
        }

        public void Update(Livro l)
        {
            livros[l.Codigo] = l; ;
        }
    }
}
