using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = [
            new() { Id = 1, Nome = "Shampoo" },
            new() { Id = 2, Nome = "Condicionador"},
            new() { Id = 3, Nome = "Máscara"},
            new() { Id = 4, Nome = "Creme de Pentear"},
        ];
        modelBuilder.Entity<Categoria>().HasData(categorias);
    }
}