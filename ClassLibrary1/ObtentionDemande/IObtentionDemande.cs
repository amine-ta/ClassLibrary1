using ClassLibrary1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ObtentionDemande
{
    public interface IObtentionDemande
    {
        UserDto ObtenirDemande(int idUser);
    }
}
