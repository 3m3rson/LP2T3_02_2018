using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Ex_01
{
    interface IDatabase
    {
        void Save(Livro l);
        void Delete(long codigo);
        void Update(Livro l);
        Livro Read(long codigo);

        List<Livro> ListAll();




    }
}
