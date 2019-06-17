using AutoMapper;
using ClassLibrary1.Context;
using ClassLibrary1.Dto;
using ClassLibrary1.Mappeur;


namespace ClassLibrary1.ObtentionDemande
{
    public class ObtentionDemande : IObtentionDemande
    {
        private IOracleContext cxt;
        private IMapper impa;

        public ObtentionDemande(IOracleContext oraContext, IMappeur mappeur)
        {
            this.cxt = oraContext;
            this.impa = mappeur.CreerMappeur<utilisateur, UserDto>();
        }
        public UserDto ObtenirDemande(int idUser)
        {
            utilisateur user =  cxt.OracleContext.utilisateur.Find(idUser);

            if (user == null)
            {
                return null;
            }

            UserDto dto= impa.Map<UserDto>(user);

            return dto;
        }
    }
}
