using GStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region Perfis de usuário
        List<IdentityRole> perfis = [
            new () {
                Id = "073ff7a4-aa69-453c-8a21-5aabe3f6f22b",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR",
            },
            new () {
                Id = "e15bfe2b-8b69-4a02-adc1-f0bd150f9174",
                Name = "Cliente",
                NormalizedName = "CLIENTE",
            },
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuario
        List<Usuario> usuarios = [
            new () {
                Id = "5bcdf9b5-b125-4900-9785-f82b8acfddd9",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gstore.com",
                NormalizedEmail = "ADMIN@GSTORE.COM.BR",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Matheus Ferreira de Lima",
                DataNascimento = new DateTime(2008, 5, 21),,
                Foto = "https://avatars.githubusercontent.com/u/12345678?v=4",
            },
        ];
        foreach (var usuario in usuarios)
        {
            PasswordHasher<Usuario> pass = new();
            usuario.PasswordHash = pass.HashPassword(usuario, "123456");
        }

        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Usuario Perfil
        #endregion   
    }
}
