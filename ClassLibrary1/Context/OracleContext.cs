using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Context;

namespace ClassLibrary1.Context
{
    public class OracleContext : IOracleContext
    {
        public IContext ctx;


        IContext IOracleContext.OracleContext
        {
            get
            {
                if( ctx != null)
                {
                    return ctx;
                }
                ctx = new Context();

                return ctx;
            }

        }

    }

}
