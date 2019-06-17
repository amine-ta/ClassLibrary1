using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Mappeur
{
   public interface IMappeur
    {
        IMapper CreerMappeur<Source, Destination>();

    }
}
