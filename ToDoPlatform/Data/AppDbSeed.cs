using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToDoPlatform.Models;

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
        List<AppUser> users = new()
        {
            new AppUser()
            {
                Id = "c46a77f6-3bcd-4a7b-b0ef-35bb55630fbb",
                Email = "viniciusgodoy.martins@gmail.com",
                NormalizedEmail = "VINICIUSGODOY.MARTINS@GMAIL.COM",
                UserName = "viniciusgodoy.martins@gmail.com",
                NormalizedUserName = "VINICIUSGODOY.MARTINS@GMAIL.COM",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Name = " Vinicius Godoy Martins",
                ProfilePicture = "/img/users/caralha_do_demonio_das_profundezas_do_usuario_idiota"
        }, 

        new AppUser()
            {
                Id = "af249a93-6a3b-45f0-b097-440b8f8f0446",
                Email = "anthonyserrano849@gmail.com",
                NormalizedEmail = "ANTHONYSERRANO894@GMAIL.COM",
                UserName = "anthonyserrano894@gmail.com",
                NormalizedUserName = "ANTHONYSERRANO894@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Name = " Anthony Rodrigues da Silva",
                ProfilePicture = "/img/users/caralha_do_demonio_das_profundezas_do_usuario_idiota"
        }, 
        };


        foreach(var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<AppUser>().HasData(users);
        #endregion



        #region Popular Dados de Usuário Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>()
            {
                UserId = users[0].Id,
                RoleId = users[0].Id,
            },

            new IdentityUserRole<string>()
            {
                UserId= users[1].Id,
                RoleId = roles[1].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region  Popular as Tarefas do usuarío
        List<ToDo> toDos = new()
        {
            new ToDo()
            {
                id=1,
                Title=" Se matar",
                Description= "cometer suicidio",
                UserId= users[0].Id
            },

            new ToDo()
            {
                id=2,
                Title=" Se matar",
                Description= "cometer suicidio",
                UserId= users[0].Id
            },

            new ToDo()
            {
                id=3,
                Title=" Se matar",
                Description= "cometer suicidio",
                UserId= users[1].Id
            },
            
        };
        builder.Entity<ToDo>().HasData(toDos);
        #endregion


    }    
}

