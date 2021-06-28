using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using veganFood.Models;

namespace veganFood.Data
{
    /// <summary>
    /// esta classe representa a Base de Dados a ser utilizada neste projeto
    /// </summary>
    public class VeganDbContext : IdentityDbContext
    {

        // construtor da classe CriadoresCaesDB
        // indicar onde está a BD à qual estas classes (tabelas) serão associadas
        // ver o conteúdo do ficheiro 'startup.cs'
        public VeganDbContext(DbContextOptions<VeganDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Utilizadores>().HasData(
                new Utilizadores { Email = "jose@hotmail.com", IDutilizador = 1, Nome = "Jose", UserNameId = "8b045d16-ea55-410e-afce-695013e76972" });
            //insert DB seed
            modelBuilder.Entity<Receitas>().HasData(
                new Receitas { IDreceita = 1, Descricao = "Arroz do mar", Ingredientes = "Azeite qb, 1 cebola média, 2 dentes de alho, Tomate sem pele picado, 1 / 2 pimento vermelho aos cubos, 1 / 2 chouriço vegan 1 embalagem de flor de bananeira em matinada de algas , 1 copo de arroz, 1 caldo de legumes vegan, sal e açafrão qb", ModoPreparo = "Põe-se numa paelheira azeite cebola picadinha e dois dentes de alho.Quando estiver alourado deita-se um tomate sem pele picado e meio pimento vermelho e meio pimento verde aos cubos. Tempera - se com sal e açafrão. Adiciona meio chouriço vegan, cortado às rodelas e flor de bananeira.Deixa - se cozer um pouco. Acrescenta um copo de arroz e mexe - se. Juntam - se dois copos de água com caldo de legumes. Mexe - se e deixa - se cozer o arroz 12 a 15 minutos. Está pronto a ser servido" },
                new Receitas { IDreceita = 2, Descricao = "Almôndegas vegan", Ingredientes = "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", ModoPreparo = "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." },
                new Receitas { IDreceita = 3, Descricao = "Mousse de leite vegan", Ingredientes = "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", ModoPreparo = "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." },
                new Receitas { IDreceita = 4, Descricao = "Alho francês à Brás", Ingredientes = "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", ModoPreparo = "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." }
                );
        

            modelBuilder.Entity<Fotografias>().HasData(
                new Fotografias { IDfotografia = 1, Fotografia ="almondegas.jpg", ReceitaFK = 1},
                new Fotografias { IDfotografia = 2, Fotografia = "arroz.jpg", ReceitaFK = 2 },
                new Fotografias { IDfotografia = 3, Fotografia = "mousse.jpg", ReceitaFK = 3 },
                new Fotografias { IDfotografia = 4, Fotografia = "alho.jpg", ReceitaFK = 4 }
                );
        }

        //Representar as tabelas da BD
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }

    }
}
