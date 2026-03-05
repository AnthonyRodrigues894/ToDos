using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ToDoPlatform.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Perfis de Usuários
        List<IdentityRole> roles = new()
        {
            new()
            {
                Id = "3a777483-7bef-49ef-8271-26d84a615246",
                Name= "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },

            new()
            {
                Id = "6e083c1a-17a7-468e-b17b-b553e610fdb9",
                Name= "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion



        #region Popular Usuário

        #endregion
    }    
}

