using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace receitas.api.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Idcategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namecategory = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Idcategory);
                });

            migrationBuilder.CreateTable(
                name: "Dificuldade",
                columns: table => new
                {
                    Iddifficulty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namedifficulty = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dificuldade", x => x.Iddifficulty);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Idingredient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameingredient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Idingredient);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Idpermission = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namepermission = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Idpermission);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Idstate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameState = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Idstate);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Idunity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameunity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Siglaunity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Idunity);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Idrecipe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namerecipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preparationrecipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durationrecipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagerecipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Daterecipe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idcategory = table.Column<int>(type: "int", nullable: false),
                    Iduser = table.Column<int>(type: "int", nullable: false),
                    Idstate = table.Column<int>(type: "int", nullable: false),
                    Iddifficulty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Idrecipe);
                    table.ForeignKey(
                        name: "FK_Receitas_Categorias_Idcategory",
                        column: x => x.Idcategory,
                        principalTable: "Categorias",
                        principalColumn: "Idcategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receitas_Dificuldade_Iddifficulty",
                        column: x => x.Iddifficulty,
                        principalTable: "Dificuldade",
                        principalColumn: "Iddifficulty",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receitas_State_Idstate",
                        column: x => x.Idstate,
                        principalTable: "State",
                        principalColumn: "Idstate",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Iduser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameuser = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Emailuser = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Passworduser = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Userimage = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Idstate = table.Column<int>(type: "int", nullable: false),
                    Idpermission = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Iduser);
                    table.ForeignKey(
                        name: "FK_Utilizadores_Permissao_Idpermission",
                        column: x => x.Idpermission,
                        principalTable: "Permissao",
                        principalColumn: "Idpermission",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Utilizadores_State_Idstate",
                        column: x => x.Idstate,
                        principalTable: "State",
                        principalColumn: "Idstate",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Idcomment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Commentrecipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classificationrecipe = table.Column<int>(type: "int", nullable: false),
                    DateComment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Iduser = table.Column<int>(type: "int", nullable: false),
                    Idrecipe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Idcomment);
                    table.ForeignKey(
                        name: "FK_Comentarios_Receitas_Idrecipe",
                        column: x => x.Idrecipe,
                        principalTable: "Receitas",
                        principalColumn: "Idrecipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destaques",
                columns: table => new
                {
                    Idhighlight = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idrecipe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destaques", x => x.Idhighlight);
                    table.ForeignKey(
                        name: "FK_Destaques_Receitas_Idrecipe",
                        column: x => x.Idrecipe,
                        principalTable: "Receitas",
                        principalColumn: "Idrecipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    Idfavorite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iduser = table.Column<int>(type: "int", nullable: false),
                    Idrecipe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Idfavorite);
                    table.ForeignKey(
                        name: "FK_Favoritos_Receitas_Idrecipe",
                        column: x => x.Idrecipe,
                        principalTable: "Receitas",
                        principalColumn: "Idrecipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaIngredientes",
                columns: table => new
                {
                    Idingredientrecipe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantityingredient = table.Column<int>(type: "int", nullable: false),
                    Idingredient = table.Column<int>(type: "int", nullable: false),
                    Idunity = table.Column<int>(type: "int", nullable: false),
                    Idrecipe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaIngredientes", x => x.Idingredientrecipe);
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientes_Ingredientes_Idingredient",
                        column: x => x.Idingredient,
                        principalTable: "Ingredientes",
                        principalColumn: "Idingredient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientes_Receitas_Idrecipe",
                        column: x => x.Idrecipe,
                        principalTable: "Receitas",
                        principalColumn: "Idrecipe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientes_Unidade_Idunity",
                        column: x => x.Idunity,
                        principalTable: "Unidade",
                        principalColumn: "Idunity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Temporario",
                columns: table => new
                {
                    Idtemp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iduser = table.Column<int>(type: "int", nullable: false),
                    Idingredient = table.Column<int>(type: "int", nullable: false),
                    Idunity = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporario", x => x.Idtemp);
                    table.ForeignKey(
                        name: "FK_Temporario_Ingredientes_Idingredient",
                        column: x => x.Idingredient,
                        principalTable: "Ingredientes",
                        principalColumn: "Idingredient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Temporario_Unidade_Idunity",
                        column: x => x.Idunity,
                        principalTable: "Unidade",
                        principalColumn: "Idunity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Temporario_Utilizadores_Iduser",
                        column: x => x.Iduser,
                        principalTable: "Utilizadores",
                        principalColumn: "Iduser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Idcategory", "Namecategory" },
                values: new object[,]
                {
                    { 1, "Carne" },
                    { 2, "Peixe" },
                    { 3, "Entradas" },
                    { 4, "Sopas" },
                    { 5, "Sobremesas" }
                });

            migrationBuilder.InsertData(
                table: "Dificuldade",
                columns: new[] { "Iddifficulty", "Namedifficulty" },
                values: new object[,]
                {
                    { 1, "Fácil" },
                    { 2, "Médio" },
                    { 3, "Difícil" }
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "Idingredient", "Nameingredient" },
                values: new object[,]
                {
                    { 1, "Bacalhau" },
                    { 2, "Batatas Palha" },
                    { 3, "Cebolas" },
                    { 4, "Alhos" },
                    { 5, "Azeite" },
                    { 6, "Ovos" },
                    { 7, "Sal" },
                    { 8, "Pimenta Branca" },
                    { 9, "Salsa" },
                    { 10, "Pimenta Preta" },
                    { 11, "Frango" },
                    { 12, "Margarina" },
                    { 13, "Cerveja" },
                    { 14, "Pimentão Doce" },
                    { 15, "PiriPiri" },
                    { 16, "Limões" },
                    { 17, "Sardinhas" },
                    { 18, "Batatas" },
                    { 19, "Pimento Vermelhos" },
                    { 20, "Pimento Verde" },
                    { 21, "Cebola Roxa" },
                    { 22, "Lulas" },
                    { 23, "Vinho Branco" },
                    { 24, "Massa de Pimentão" },
                    { 25, "Ketchup" },
                    { 26, "Polpa de Tomate" },
                    { 27, "Banha de Porco" },
                    { 28, "Louro" },
                    { 29, "Farinha sem Fermento" },
                    { 30, "Manteiga" },
                    { 31, "Leite" },
                    { 32, "Açucar" },
                    { 33, "Gelado" },
                    { 34, "Fruta" }
                });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "Idpermission", "Namepermission" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Utilizador" }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Idstate", "NameState" },
                values: new object[,]
                {
                    { 1, "Bloqueado" },
                    { 2, "Publicado" },
                    { 6, "Não Publicado" },
                    { 7, "Por Validar" },
                    { 8, "Ativo" }
                });

            migrationBuilder.InsertData(
                table: "Unidade",
                columns: new[] { "Idunity", "Nameunity", "Siglaunity" },
                values: new object[,]
                {
                    { 1, "Unidade", "Uni" },
                    { 2, "Gramas", "G" },
                    { 3, "Litro", "L" },
                    { 4, "Decilitro", "dL" },
                    { 5, "Centilitro", "cL" },
                    { 6, "Mililitro", "dL" },
                    { 7, "Colher de Sopa", "Colh" },
                    { 8, "Colher de Chá", "Colh Chá" },
                    { 9, "Dente", "Dent" },
                    { 10, "q.b.", "QB" },
                    { 11, "Colher de Café", "Colh CaF" },
                    { 12, "Kilo", "Kg" }
                });

            migrationBuilder.InsertData(
                table: "Receitas",
                columns: new[] { "Idrecipe", "Daterecipe", "Durationrecipe", "Idcategory", "Iddifficulty", "Idstate", "Iduser", "Imagerecipe", "Namerecipe", "Preparationrecipe" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(3168), "00:25", 2, 1, 2, 2, "bacalhaubras.jpg", "Bacalhau à Brás", "1 - Se optou por utilizar bacalhau congelado, só precisa de o deixar descongelar e fica pronto a utilizar. Caso, prefira utilizar bacalhau salgado, deverá deixar a demolhar no minimo durante 20 a 24 horas em bastante água.2 - Escalde o bacalhau durante cerca de 10 minutos numa panela com água a ferver. Retire da água e deixe arrefecer um pouco antes de lhe retirar as peles e as espinhas. Agora já pode desfiá-lo em lascas.3 - Refogue as cebolas e os alhos no azeite, junte o bacalhau e deixe-o absorver um pouco o azeite durante 2 a 3 minutos.4 - Adicione depois a batata palha envolvendo bem.5 - Quando estiver quente, junte os ovos previamente batidos e temperados com sal e pimenta. Atenção porque se utilizar as batatas de pacote nem sequer necessita de adicionar sal.6 - Mantenha o lume baixo e envolva bem, mexendo sempre com uma colher de pau até os ovos ficarem com uma consistência semelhante á dos ovos mexidos.7 - Polvilhe com salsa picada e enfeite com azeitonas pretas. Sirva com salada de alface cortada em juliana grossa." },
                    { 2, new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(3344), "01:40", 1, 1, 2, 2, "frangonoforno.jpg", "Frango no Forno com limão e cerveja", "1 - Para preparar esta receita de frango, aqueça o forno a 170° C. Descasque os dentes de alho e coloque-os na picadora, bem como o azeite, o pimentão-doce, o piripiri e a cerveja. Ligue para triturar bem.2 - Coloque o frango num tabuleiro, barre-o com o preparado anterior, tempere-o com sal e pimenta e regue com o sumo dos limões.3 - Espalhe por cima a margarina cortada em cubos e leve ao forno durante 25 minutos ou até o frango ficar bem assado e tostadinho, virando-o de vez em quando. Sirva decorado a gosto, por exemplo com gomos de limão." },
                    { 3, new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(3548), "00:50", 2, 2, 2, 2, "lulasribeira.jpg", "Lulas à moda da Ribeira", "1 - Corte as lulas em pedaços e tempere-os com sal, o piripíri, a folha de louro, o alho picado, a massa de pimentão e o vinho branco. Deixe marinar.2 - Leve a lume médio um tacho com azeite. Quando estiver quente, junte as lulas com a marinada e cozinhe-as até estarem tenras.3 - Transfira as lulas para uma travessa de forno, junte o ketchup, a polpa de tomate e a banha e regue com bastante azeite. Tempere com sal e envolva tudo muito bem. Leve ao forno, pré-aquecido a 180ºC, durante cerca de 20 minutos. Sirva salpicado com salsa." },
                    { 4, new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(3676), "01:10", 2, 1, 2, 2, "sardinhasassadas.jpg", "Sardinhas assadas com salada de batata e pimentos", "1 - Pincele as sardinhas com azeite, tempere-as com sal grosso e grelhe-as, até ficarem douradas e cozinhadas.2 - Coza as batatinhas, com a pele, em água com sal. Escorra-as, deixe arrefecer e elimine a pele. Reserve.3 - Grelhe os pimentos, até a pele ficar queimada. Depois, coloque-os num saco de plástico e feche. Elimine-lhes a pele e as sementes e corte-os em tiras.4 - Corte as batatas em metades ou quartos e misture com os pimentos e a cebola roxa, previamente picada. Tempere com um fio de azeite, a salsa picada, sal e pimenta. Envolva, cuidadosamente, e sirva com as sardinhas." },
                    { 5, new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(3771), "01:20", 5, 2, 2, 3, "crepefrutas.jpg", "Crepes com fruta e gelado de baunilha", "1 - Coloque a farinha e um pouco de sal numa tigela. Junte o açúcar e, mexendo, adicione o leite aos poucos. Acrescente os ovos e mexa bem com uma vara de arames. Por fim, junte a manteiga derretida e mexa novamente.2 - Passe a massa anterior por um passador de rede e deixe repousar, durante 30 minutos, no frigorífico.3 - Após o tempo indicado, leve ao lume uma frigideira antiaderente grande e deixe aquecer.Unte - a com um pouco de manteiga e retire o excesso com uma folha de papel.4 - Espalhe uma concha de massa por toda a frigideira. Quando começar a dourar em volta, vire-a e deixe cozinhar desse lado. Retire para um prato e repita o procedimento até terminar a massa.5 - Descasque e corte fruta a gosto em pedaços. Recheie os crepes com a fruta, enrole e polvilhe com açúcar em pó. Sirva os crepes mornos ou frios, acompanhados com gelado de baunilha e decorados com hortelã." }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Iduser", "Emailuser", "Idpermission", "Idstate", "Passworduser", "Userimage", "nameuser" },
                values: new object[,]
                {
                    { 1, "admin@receitas.pt", 1, 8, "123", "assets/imagepage/userimage.jpg", "Administrador" },
                    { 2, "briangomes@sapo.pt", 1, 8, "123", "assets/imagepage/userimage.jpg", "Brian Gomes" },
                    { 3, "catarinacorreia@sapo.pt", 2, 8, "123", "assets/imagepage/userimage.jpg", "Catarina Correia" },
                    { 4, "filipegomes@sapo.pt", 2, 1, "123", "assets/imagepage/userimage.jpg", "Filipe Gomes" }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Idcomment", "Classificationrecipe", "Commentrecipe", "DateComment", "Idrecipe", "Iduser" },
                values: new object[] { 1, 5, "Adorei! Fiz hoje e ficou ótimo, recomendo!", new DateTime(2022, 6, 30, 20, 11, 8, 453, DateTimeKind.Local).AddTicks(4012), 1, 3 });

            migrationBuilder.InsertData(
                table: "Destaques",
                columns: new[] { "Idhighlight", "Idrecipe" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Favoritos",
                columns: new[] { "Idfavorite", "Idrecipe", "Iduser" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "ReceitaIngredientes",
                columns: new[] { "Idingredientrecipe", "Idingredient", "Idrecipe", "Idunity", "Quantityingredient" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 400 },
                    { 2, 2, 1, 2, 500 },
                    { 3, 3, 1, 1, 2 },
                    { 4, 4, 1, 9, 3 },
                    { 5, 5, 1, 7, 3 },
                    { 6, 6, 1, 1, 6 },
                    { 7, 7, 1, 10, 0 },
                    { 8, 8, 1, 10, 0 },
                    { 9, 9, 1, 10, 0 },
                    { 10, 11, 2, 1, 1 },
                    { 11, 4, 2, 9, 2 },
                    { 12, 12, 2, 2, 70 },
                    { 13, 5, 2, 4, 2 },
                    { 14, 13, 2, 4, 3 },
                    { 15, 14, 2, 8, 1 },
                    { 16, 15, 2, 11, 1 },
                    { 17, 16, 2, 1, 2 },
                    { 18, 7, 2, 10, 0 },
                    { 19, 10, 2, 10, 0 },
                    { 20, 17, 4, 2, 800 },
                    { 21, 18, 4, 2, 500 },
                    { 22, 19, 4, 1, 2 },
                    { 23, 20, 4, 1, 1 },
                    { 24, 21, 4, 1, 1 },
                    { 25, 9, 4, 7, 7 },
                    { 29, 22, 3, 12, 1 },
                    { 30, 4, 3, 9, 1 },
                    { 31, 23, 3, 6, 50 },
                    { 32, 24, 3, 7, 2 },
                    { 33, 25, 3, 7, 2 },
                    { 34, 26, 3, 7, 2 },
                    { 35, 27, 3, 7, 1 },
                    { 36, 15, 3, 8, 1 },
                    { 37, 28, 3, 1, 1 },
                    { 41, 29, 5, 2, 140 }
                });

            migrationBuilder.InsertData(
                table: "ReceitaIngredientes",
                columns: new[] { "Idingredientrecipe", "Idingredient", "Idrecipe", "Idunity", "Quantityingredient" },
                values: new object[,]
                {
                    { 42, 30, 5, 2, 70 },
                    { 43, 6, 5, 1, 2 },
                    { 44, 31, 5, 6, 600 },
                    { 45, 32, 5, 7, 3 },
                    { 46, 33, 5, 10, 0 },
                    { 47, 34, 5, 10, 0 },
                    { 48, 7, 5, 10, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_Idrecipe",
                table: "Comentarios",
                column: "Idrecipe");

            migrationBuilder.CreateIndex(
                name: "IX_Destaques_Idrecipe",
                table: "Destaques",
                column: "Idrecipe");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_Idrecipe",
                table: "Favoritos",
                column: "Idrecipe");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_Idingredient",
                table: "ReceitaIngredientes",
                column: "Idingredient");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_Idrecipe",
                table: "ReceitaIngredientes",
                column: "Idrecipe");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_Idunity",
                table: "ReceitaIngredientes",
                column: "Idunity");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_Idcategory",
                table: "Receitas",
                column: "Idcategory");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_Iddifficulty",
                table: "Receitas",
                column: "Iddifficulty");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_Idstate",
                table: "Receitas",
                column: "Idstate");

            migrationBuilder.CreateIndex(
                name: "IX_Temporario_Idingredient",
                table: "Temporario",
                column: "Idingredient");

            migrationBuilder.CreateIndex(
                name: "IX_Temporario_Idunity",
                table: "Temporario",
                column: "Idunity");

            migrationBuilder.CreateIndex(
                name: "IX_Temporario_Iduser",
                table: "Temporario",
                column: "Iduser");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_Idpermission",
                table: "Utilizadores",
                column: "Idpermission");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_Idstate",
                table: "Utilizadores",
                column: "Idstate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Destaques");

            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "ReceitaIngredientes");

            migrationBuilder.DropTable(
                name: "Temporario");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Dificuldade");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
