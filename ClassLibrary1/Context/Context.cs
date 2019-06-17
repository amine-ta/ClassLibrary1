using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Context
{
   public class Context : DbContext, IContext
    {

        public Context() : base("testEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual IDbSet<utilisateur> utilisateur { get; set; }

    }

}





