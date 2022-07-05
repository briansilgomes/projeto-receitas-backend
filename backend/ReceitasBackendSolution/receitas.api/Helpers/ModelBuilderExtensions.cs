using Microsoft.EntityFrameworkCore;
using receitas.entidades;

namespace receitas.api.Helpers
{
    public static class ModelBuilderExtensions
    {
       
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(new Category { Idcategory = 1, Namecategory = "Carne" });
            modelBuilder.Entity<Category>().HasData(new Category { Idcategory = 2, Namecategory = "Peixe" });
            modelBuilder.Entity<Category>().HasData(new Category { Idcategory = 3, Namecategory = "Entradas" });
            modelBuilder.Entity<Category>().HasData(new Category { Idcategory = 4, Namecategory = "Sopas" });
            modelBuilder.Entity<Category>().HasData(new Category { Idcategory = 5, Namecategory = "Sobremesas" });

            modelBuilder.Entity<Difficulty>().HasData(new Difficulty { Iddifficulty = 1, Namedifficulty = "Fácil" });
            modelBuilder.Entity<Difficulty>().HasData(new Difficulty { Iddifficulty = 2, Namedifficulty = "Médio" });
            modelBuilder.Entity<Difficulty>().HasData(new Difficulty { Iddifficulty = 3, Namedifficulty = "Difícil" });

            modelBuilder.Entity<Permission>().HasData(new Permission { Idpermission = 1, Namepermission = "Administrador"});
            modelBuilder.Entity<Permission>().HasData(new Permission { Idpermission = 2, Namepermission = "Utilizador" });

            modelBuilder.Entity<State>().HasData(new State { Idstate = 1, NameState = "Bloqueado"});
            modelBuilder.Entity<State>().HasData(new State { Idstate = 2, NameState = "Publicado" });
            modelBuilder.Entity<State>().HasData(new State { Idstate = 6, NameState = "Não Publicado" });
            modelBuilder.Entity<State>().HasData(new State { Idstate = 7, NameState = "Por Validar" });
            modelBuilder.Entity<State>().HasData(new State { Idstate = 8, NameState = "Ativo" });

            modelBuilder.Entity<User>().HasData(new User { Iduser = 1, Nameuser = "Administrador", Emailuser ="admin@receitas.pt", Passworduser="123", Userimage= "assets/imagepage/userimage.jpg", Idpermission=1, Idstate=8 });
            modelBuilder.Entity<User>().HasData(new User { Iduser = 2, Nameuser = "Brian Gomes", Emailuser = "briangomes@sapo.pt", Passworduser = "123", Userimage = "assets/imagepage/userimage.jpg", Idpermission = 1, Idstate = 8 });
            modelBuilder.Entity<User>().HasData(new User { Iduser = 3, Nameuser = "Catarina Correia", Emailuser = "catarinacorreia@sapo.pt", Passworduser = "123", Userimage = "assets/imagepage/userimage.jpg", Idpermission = 2, Idstate = 8 });
            modelBuilder.Entity<User>().HasData(new User { Iduser = 4, Nameuser = "Filipe Gomes", Emailuser = "filipegomes@sapo.pt", Passworduser = "123", Userimage = "assets/imagepage/userimage.jpg", Idpermission = 2, Idstate = 1 });

            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 1, Nameunity="Unidade", Siglaunity="Uni"});
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 2, Nameunity = "Gramas", Siglaunity = "G" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 3, Nameunity = "Litro", Siglaunity = "L" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 4, Nameunity = "Decilitro", Siglaunity = "dL" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 5, Nameunity = "Centilitro", Siglaunity = "cL" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 6, Nameunity = "Mililitro", Siglaunity = "dL" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 7, Nameunity = "Colher de Sopa", Siglaunity = "Colh" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 8, Nameunity = "Colher de Chá", Siglaunity = "Colh Chá" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 9, Nameunity = "Dente", Siglaunity = "Dent" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 10, Nameunity = "q.b.", Siglaunity = "QB" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 11, Nameunity = "Colher de Café", Siglaunity = "Colh CaF" });
            modelBuilder.Entity<Unity>().HasData(new Unity { Idunity = 12, Nameunity = "Kilo", Siglaunity = "Kg" });


            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 1, Nameingredient = "Bacalhau"});
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 2, Nameingredient = "Batatas Palha" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 3, Nameingredient = "Cebolas" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 4, Nameingredient = "Alhos" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 5, Nameingredient = "Azeite" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 6, Nameingredient = "Ovos" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 7, Nameingredient = "Sal" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 8, Nameingredient = "Pimenta Branca" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 9, Nameingredient = "Salsa" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 10, Nameingredient = "Pimenta Preta" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 11, Nameingredient = "Frango" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 12, Nameingredient = "Margarina" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 13, Nameingredient = "Cerveja" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 14, Nameingredient = "Pimentão Doce" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 15, Nameingredient = "PiriPiri" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 16, Nameingredient = "Limões" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 17, Nameingredient = "Sardinhas" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 18, Nameingredient = "Batatas" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 19, Nameingredient = "Pimento Vermelhos" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 20, Nameingredient = "Pimento Verde" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 21, Nameingredient = "Cebola Roxa" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 22, Nameingredient = "Lulas" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 23, Nameingredient = "Vinho Branco" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 24, Nameingredient = "Massa de Pimentão" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 25, Nameingredient = "Ketchup" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 26, Nameingredient = "Polpa de Tomate" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 27, Nameingredient = "Banha de Porco" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 28, Nameingredient = "Louro" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 29, Nameingredient = "Farinha sem Fermento" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 30, Nameingredient = "Manteiga" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 31, Nameingredient = "Leite" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 32, Nameingredient = "Açucar" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 33, Nameingredient = "Gelado" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Idingredient = 34, Nameingredient = "Fruta" });


            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Idrecipe = 1,
                Namerecipe = "Bacalhau à Brás",
                Daterecipe = DateTime.Now,
                Durationrecipe = "00:25",
                Imagerecipe = "bacalhaubras.jpg",
                Idcategory = 2,
                Iddifficulty = 1,
                Idstate = 2,
                Iduser = 2,
                Preparationrecipe = "1 - Se optou por utilizar bacalhau congelado, só precisa de o deixar descongelar e fica pronto a utilizar. Caso, prefira utilizar bacalhau salgado, deverá deixar a demolhar no minimo durante 20 a 24 horas em bastante água." +
                "2 - Escalde o bacalhau durante cerca de 10 minutos numa panela com água a ferver. Retire da água e deixe arrefecer um pouco antes de lhe retirar as peles e as espinhas. Agora já pode desfiá-lo em lascas." +
                "3 - Refogue as cebolas e os alhos no azeite, junte o bacalhau e deixe-o absorver um pouco o azeite durante 2 a 3 minutos." +
                "4 - Adicione depois a batata palha envolvendo bem." +
                "5 - Quando estiver quente, junte os ovos previamente batidos e temperados com sal e pimenta. Atenção porque se utilizar as batatas de pacote nem sequer necessita de adicionar sal." +
                "6 - Mantenha o lume baixo e envolva bem, mexendo sempre com uma colher de pau até os ovos ficarem com uma consistência semelhante á dos ovos mexidos." +
                "7 - Polvilhe com salsa picada e enfeite com azeitonas pretas. Sirva com salada de alface cortada em juliana grossa."
            });

            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 1, Idrecipe=1,Idingredient = 1, Idunity=  2, Quantityingredient= 400 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 2, Idrecipe = 1, Idingredient = 2, Idunity = 2, Quantityingredient = 500 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 3, Idrecipe = 1, Idingredient = 3, Idunity = 1, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 4, Idrecipe = 1, Idingredient = 4, Idunity = 9, Quantityingredient = 3 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 5, Idrecipe = 1, Idingredient = 5, Idunity = 7, Quantityingredient = 3 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 6, Idrecipe = 1, Idingredient = 6, Idunity = 1, Quantityingredient = 6 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 7, Idrecipe = 1, Idingredient = 7, Idunity = 10, Quantityingredient = 0 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 8, Idrecipe = 1, Idingredient = 8, Idunity = 10, Quantityingredient = 0 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 9, Idrecipe = 1, Idingredient = 9, Idunity = 10, Quantityingredient = 0 });


            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Idrecipe = 2,
                Namerecipe = "Frango no Forno com limão e cerveja",
                Daterecipe = DateTime.Now,
                Durationrecipe = "01:40",
                Imagerecipe = "frangonoforno.jpg",
                Idcategory = 1,
                Iddifficulty = 1,
                Idstate = 2,
                Iduser = 2,
                Preparationrecipe = "1 - Para preparar esta receita de frango, aqueça o forno a 170° C. Descasque os dentes de alho e coloque-os na picadora, bem como o azeite, o pimentão-doce, o piripiri e a cerveja. Ligue para triturar bem." +
              "2 - Coloque o frango num tabuleiro, barre-o com o preparado anterior, tempere-o com sal e pimenta e regue com o sumo dos limões." +
              "3 - Espalhe por cima a margarina cortada em cubos e leve ao forno durante 25 minutos ou até o frango ficar bem assado e tostadinho, virando-o de vez em quando. Sirva decorado a gosto, por exemplo com gomos de limão."});

            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 10, Idrecipe = 2, Idingredient = 11, Idunity = 1, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 11, Idrecipe = 2, Idingredient = 4, Idunity = 9, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 12, Idrecipe = 2, Idingredient = 12, Idunity = 2, Quantityingredient = 70 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 13, Idrecipe = 2, Idingredient = 5, Idunity = 4, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 14, Idrecipe = 2, Idingredient = 13, Idunity = 4, Quantityingredient = 3 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 15, Idrecipe = 2, Idingredient = 14, Idunity = 8, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 16, Idrecipe = 2, Idingredient = 15, Idunity = 11, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 17, Idrecipe = 2, Idingredient = 16, Idunity = 1, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 18, Idrecipe = 2, Idingredient = 7, Idunity = 10, Quantityingredient = 0 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 19, Idrecipe = 2, Idingredient = 10, Idunity = 10, Quantityingredient = 0 });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Idrecipe = 3,
                Namerecipe = "Lulas à moda da Ribeira",
                Daterecipe = DateTime.Now,
                Durationrecipe = "00:50",
                Imagerecipe = "lulasribeira.jpg",
                Idcategory = 2,
                Iddifficulty = 2,
                Idstate = 2,
                Iduser = 2,
                Preparationrecipe = "1 - Corte as lulas em pedaços e tempere-os com sal, o piripíri, a folha de louro, o alho picado, a massa de pimentão e o vinho branco. Deixe marinar." +
                "2 - Leve a lume médio um tacho com azeite. Quando estiver quente, junte as lulas com a marinada e cozinhe-as até estarem tenras." +
                "3 - Transfira as lulas para uma travessa de forno, junte o ketchup, a polpa de tomate e a banha e regue com bastante azeite. Tempere com sal e envolva tudo muito bem. Leve ao forno, pré-aquecido a 180ºC, durante cerca de 20 minutos. Sirva salpicado com salsa."
                });

            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 29, Idrecipe = 3, Idingredient = 22, Idunity = 12, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 30, Idrecipe = 3, Idingredient = 4, Idunity = 9, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 31, Idrecipe = 3, Idingredient = 23, Idunity = 6, Quantityingredient = 50 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 32, Idrecipe = 3, Idingredient = 24, Idunity = 7, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 33, Idrecipe = 3, Idingredient = 25, Idunity = 7, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 34, Idrecipe = 3, Idingredient = 26, Idunity = 7, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 35, Idrecipe = 3, Idingredient = 27, Idunity = 7, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 36, Idrecipe = 3, Idingredient = 15, Idunity = 8, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 37, Idrecipe = 3, Idingredient = 28, Idunity = 1, Quantityingredient = 1 });
         

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Idrecipe = 4,
                Namerecipe = "Sardinhas assadas com salada de batata e pimentos",
                Daterecipe = DateTime.Now,
                Durationrecipe = "01:10",
                Imagerecipe = "sardinhasassadas.jpg",
                Idcategory = 2,
                Iddifficulty = 1,
                Idstate = 2,
                Iduser = 2,
                Preparationrecipe = "1 - Pincele as sardinhas com azeite, tempere-as com sal grosso e grelhe-as, até ficarem douradas e cozinhadas." +
                "2 - Coza as batatinhas, com a pele, em água com sal. Escorra-as, deixe arrefecer e elimine a pele. Reserve." +
                "3 - Grelhe os pimentos, até a pele ficar queimada. Depois, coloque-os num saco de plástico e feche. Elimine-lhes a pele e as sementes e corte-os em tiras." +
                "4 - Corte as batatas em metades ou quartos e misture com os pimentos e a cebola roxa, previamente picada. Tempere com um fio de azeite, a salsa picada, sal e pimenta. Envolva, cuidadosamente, e sirva com as sardinhas."
            });

            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 20, Idrecipe = 4, Idingredient = 17, Idunity = 2, Quantityingredient = 800 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 21, Idrecipe = 4, Idingredient = 18, Idunity = 2, Quantityingredient = 500 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 22, Idrecipe = 4, Idingredient = 19, Idunity = 1, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 23, Idrecipe = 4, Idingredient = 20, Idunity = 1, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 24, Idrecipe = 4, Idingredient = 21, Idunity = 1, Quantityingredient = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 25, Idrecipe = 4, Idingredient = 9, Idunity = 7, Quantityingredient = 7 });
           
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                Idrecipe = 5,
                Namerecipe = "Crepes com fruta e gelado de baunilha",
                Daterecipe = DateTime.Now,
                Durationrecipe = "01:20",
                Imagerecipe = "crepefrutas.jpg",
                Idcategory = 5,
                Iddifficulty = 2,
                Idstate = 2,
                Iduser = 3,
                Preparationrecipe = "1 - Coloque a farinha e um pouco de sal numa tigela. Junte o açúcar e, mexendo, adicione o leite aos poucos. Acrescente os ovos e mexa bem com uma vara de arames. Por fim, junte a manteiga derretida e mexa novamente." +
               "2 - Passe a massa anterior por um passador de rede e deixe repousar, durante 30 minutos, no frigorífico." +
               "3 - Após o tempo indicado, leve ao lume uma frigideira antiaderente grande e deixe aquecer.Unte - a com um pouco de manteiga e retire o excesso com uma folha de papel." +
               "4 - Espalhe uma concha de massa por toda a frigideira. Quando começar a dourar em volta, vire-a e deixe cozinhar desse lado. Retire para um prato e repita o procedimento até terminar a massa." +
               "5 - Descasque e corte fruta a gosto em pedaços. Recheie os crepes com a fruta, enrole e polvilhe com açúcar em pó. Sirva os crepes mornos ou frios, acompanhados com gelado de baunilha e decorados com hortelã."
            });


            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 41, Idrecipe = 5, Idingredient = 29, Idunity = 2, Quantityingredient = 140 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 42, Idrecipe = 5, Idingredient = 30, Idunity = 2, Quantityingredient = 70 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 43, Idrecipe = 5, Idingredient = 6, Idunity = 1, Quantityingredient = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 44, Idrecipe = 5, Idingredient = 31, Idunity = 6, Quantityingredient = 600 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 45, Idrecipe = 5, Idingredient = 32, Idunity = 7, Quantityingredient = 3 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 46, Idrecipe = 5, Idingredient = 33, Idunity = 10, Quantityingredient = 0 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 47, Idrecipe = 5, Idingredient = 34, Idunity = 10, Quantityingredient = 0 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { Idingredientrecipe = 48, Idrecipe = 5, Idingredient = 7, Idunity = 10, Quantityingredient = 0 });


            modelBuilder.Entity<Highlight>().HasData(new Highlight { Idhighlight = 1, Idrecipe = 1 });
            modelBuilder.Entity<Highlight>().HasData(new Highlight { Idhighlight = 2, Idrecipe = 2 });
            modelBuilder.Entity<Highlight>().HasData(new Highlight { Idhighlight = 3, Idrecipe = 3 });
            modelBuilder.Entity<Highlight>().HasData(new Highlight { Idhighlight = 4, Idrecipe = 4 });
            modelBuilder.Entity<Highlight>().HasData(new Highlight { Idhighlight = 5, Idrecipe = 5 });

            modelBuilder.Entity<Favorite>().HasData(new Favorite { Idfavorite = 1, Idrecipe = 1, Iduser= 2 });

            modelBuilder.Entity<Comment>().HasData(new Comment { Idcomment = 1, Idrecipe = 1, Iduser = 3, DateComment = DateTime.Now, Classificationrecipe = 5, Commentrecipe="Adorei! Fiz hoje e ficou ótimo, recomendo!" });

        }
    }
}
