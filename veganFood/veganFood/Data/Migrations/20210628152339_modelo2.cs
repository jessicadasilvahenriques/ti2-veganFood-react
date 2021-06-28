using Microsoft.EntityFrameworkCore.Migrations;

namespace veganFood.Data.Migrations
{
    public partial class modelo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "IDutilizador", "Email", "Nome", "UserNameId" },
                values: new object[] { 1, "jose@hotmail.com", "Jose", "8b045d16-ea55-410e-afce-695013e76972" });

            migrationBuilder.InsertData(
                table: "Receitas",
                columns: new[] { "IDreceita", "AutorFK", "Descricao", "Ingredientes", "ModoPreparo" },
                values: new object[,]
                {
                    { 1, 1, "Arroz do mar", "Azeite qb, 1 cebola média, 2 dentes de alho, Tomate sem pele picado, 1 / 2 pimento vermelho aos cubos, 1 / 2 chouriço vegan 1 embalagem de flor de bananeira em matinada de algas , 1 copo de arroz, 1 caldo de legumes vegan, sal e açafrão qb", "Põe-se numa paelheira azeite cebola picadinha e dois dentes de alho.Quando estiver alourado deita-se um tomate sem pele picado e meio pimento vermelho e meio pimento verde aos cubos. Tempera - se com sal e açafrão. Adiciona meio chouriço vegan, cortado às rodelas e flor de bananeira.Deixa - se cozer um pouco. Acrescenta um copo de arroz e mexe - se. Juntam - se dois copos de água com caldo de legumes. Mexe - se e deixa - se cozer o arroz 12 a 15 minutos. Está pronto a ser servido" },
                    { 2, 1, "Almôndegas vegan", "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." },
                    { 3, 1, "Mousse de leite vegan", "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." },
                    { 4, 1, "Alho francês à Brás", "1 embalagem de proteína texturizada de ervilha ( Let’s Meat ), 1 pão(tipo molete), salsa qb, 1 dente de alho, 50 g de cebola, sal qb, 1 colher de sobremesa de molho de soja, 1 pitada de pimenta em pó, 1 ovo vegan(usei my ey), azeite para pincelar, farinha de glúten(se necessário)", "Começa por hidratar a proteína de ervilha, coloquei em água quente durante 15 minutos. Com um processador de alimentos começa por picar a salsa, o alho e o pão. Numa tigela à parte mistura os restantes ingredientes, adiciona a mistura de salsa e a proteína texturizada bem espremida. Se necessário, podes acrescentar farinha para modelar as bolinhas.Eu utilizei farinha de glúten. Coloca no frigorifico durante 1 hora. Retira e com a ajuda de duas colheres faz bolinhas. Podes pincelar e colocar no forno ou fritar em azeite. Serve com molho de tomate e esparguete ou uma salada." }
                });

           
            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "IDfotografia", "Fotografia", "ReceitaFK" },
                values: new object[,]
                {
                    { 1, "almondegas.jpg", 1 },
                    { 2, "arroz.jpg", 2 },
                    { 3, "mousse.jpg", 3 },
                    { 4, "alho.jpg", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "IDfotografia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "IDfotografia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "IDfotografia",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "IDfotografia",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IDutilizador",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "IDreceita",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "IDreceita",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "IDreceita",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "IDreceita",
                keyValue: 4);
        }
    }
}
