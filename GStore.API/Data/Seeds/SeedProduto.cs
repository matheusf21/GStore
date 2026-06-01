using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder modelBuilder)
    {
        List<Produto> produtos = [

            // ── Shampoo (CategoriaId = 1) ──────────────────────────────────

            new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Shampoo Hidratação Intensa",
                Descricao = @"Shampoo com queratina e proteínas da seda para fios ressecados e sem brilho. 
Restore a maciez dos cabelos após o primeiro uso, sem agredir o couro cabeludo.",
                ValorCusto = 12.50m,
                ValorVenda = 24.90m,
                Qtde = 80,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Shampoo Low Poo Cachos",
                Descricao = @"Formulado para cabelos cacheados e crespos, limpa suavemente sem retirar a umidade natural 
dos fios. Enriquecido com óleo de coco e aloe vera.",
                ValorCusto = 14.00m,
                ValorVenda = 27.90m,
                Qtde = 65,
                Destaque = false,
                Foto = "/img/produtos/2.png"
            },

            // ── Condicionador (CategoriaId = 2) ────────────────────────────

            new() {
                Id = 3,
                CategoriaId = 2,
                Nome = "Condicionador Reconstrução",
                Descricao = @"Condicionador de ação profunda com aminoácidos e pantenol que reconstrói o fio 
de dentro para fora, reduzindo o frizz e facilitando a desembaraçada.",
                ValorCusto = 13.00m,
                ValorVenda = 25.90m,
                Qtde = 70,
                Destaque = false,
                Foto = "/img/produtos/3.png"
            },

            new() {
                Id = 4,
                CategoriaId = 2,
                Nome = "Condicionador Brilho & Suavidade",
                Descricao = @"Fórmula leve com extrato de pérola e vitamina E que sela as cutículas, 
devolvendo brilho espelhado e toque sedoso sem pesar nos fios.",
                ValorCusto = 11.00m,
                ValorVenda = 22.90m,
                Qtde = 90,
                Destaque = true,
                Foto = "/img/produtos/4.png"
            },

            // ── Máscara (CategoriaId = 3) ───────────────────────────────────

            new() {
                Id = 5,
                CategoriaId = 3,
                Nome = "Máscara Nutrição Profunda",
                Descricao = @"Máscara capilar com manteiga de karité e óleo de argan para nutrição intensa 
de cabelos muito ressecados ou quimicamente tratados. Uso semanal recomendado.",
                ValorCusto = 18.00m,
                ValorVenda = 39.90m,
                Qtde = 50,
                Destaque = true,
                Foto = "/img/produtos/5.png"
            },

            new() {
                Id = 6,
                CategoriaId = 3,
                Nome = "Máscara Fortalecedora Anti-Quebra",
                Descricao = @"Tratamento com colágeno vegetal e biotina para reduzir a quebra e fortalecer 
os fios fragilizados. Deixa o cabelo mais elástico e resistente.",
                ValorCusto = 16.50m,
                ValorVenda = 35.90m,
                Qtde = 45,
                Destaque = false,
                Foto = "/img/produtos/6.png"
            },

            // ── Creme para pentear (CategoriaId = 4) ───────────────────────

            new() {
                Id = 7,
                CategoriaId = 4,
                Nome = "Creme para Pentear Cachos Definidos",
                Descricao = @"Creme leave-in com linho e proteína de trigo que define os cachos e ondas, 
controla o volume e mantém a hidratação ao longo do dia sem resíduos.",
                ValorCusto = 15.00m,
                ValorVenda = 32.90m,
                Qtde = 60,
                Destaque = true,
                Foto = "/img/produtos/7.png"
            },

            new() {
                Id = 8,
                CategoriaId = 4,
                Nome = "Creme para Pentear Desembaraçante",
                Descricao = @"Fórmula fluida com manteiga de murumuru e óleo de jojoba que facilita a 
desembaraçada, reduz o frizz e protege os fios do calor de chapinhas e secadores.",
                ValorCusto = 13.50m,
                ValorVenda = 29.90m,
                Qtde = 55,
                Destaque = false,
                Foto = "/img/produtos/8.png"
            },
        ];

        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}