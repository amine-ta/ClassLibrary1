
using AutoMapper;
using ClassLibrary1.Context;
using ClassLibrary1.Dto;
using ClassLibrary1.Mappeur;

namespace ClassLibrary1.CreationDemande
{
    public class CreationDemande : ICreationDemande
    {
        private IOracleContext context;
        private IMappeur mappeur;
        private IMapper configuration;

        public CreationDemande(IOracleContext _con, IMappeur mapeur)
        {
            this.context = _con;
            this.mappeur = mapeur;
            this.configuration = mappeur.CreerMappeur<UserDto, utilisateur>();


        }

        public int CreerDemande(UserDto _userDto)
        {
            utilisateur user = configuration.Map<UserDto, utilisateur>(_userDto);
            context.OracleContext.utilisateur.Add(user);
            context.OracleContext.SaveChanges();
            return _userDto.id;
        }

    }
}
