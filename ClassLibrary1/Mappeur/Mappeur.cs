using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ClassLibrary1.Mappeur
{
    public class Mappeur : IMappeur
    {

        public IMapper CreerMappeur<Source, Destination>()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Source, Destination>();
            });           
            return configuration.CreateMapper();
        }


    }
}
