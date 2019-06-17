using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Context
{
    public interface IContext
    {
        IDbSet<utilisateur> utilisateur { get; set; }
        int SaveChanges();
    }
}
