using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.CreationDemande;
using ClassLibrary1;
using ClassLibrary1.Mappeur;
using ClassLibrary1.CreationDemande;
using ClassLibrary1.Context;
using ClassLibrary1.Dto;
using ClassLibrary1.ObtentionDemande;

namespace ClassLibrary1
{
    public class Maine
    {
        static void Main(string[] args)
        {
            IMappeur mp = new Mappeur.Mappeur();
            IOracleContext ct = new OracleContext();
            ICreationDemande cr = new CreationDemande.CreationDemande(ct, mp);
            UserDto dto = new UserDto();
            dto.nom ="saw";

            IObtentionDemande ob = new ObtentionDemande.ObtentionDemande(ct, mp);

            Console.WriteLine(ob.ObtenirDemande(1).nom);
            Console.ReadKey();
           
        }

       
    }
}
