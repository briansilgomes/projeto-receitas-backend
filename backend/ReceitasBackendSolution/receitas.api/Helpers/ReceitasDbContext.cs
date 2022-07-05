
using Microsoft.EntityFrameworkCore;
using receitas.api.Helpers;
using receitas.entidades;

public class ReceitasDbContext : DbContext
{
    protected readonly IConfiguration Configuration; 
    public ReceitasDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {// connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("ReceitasBD"));
    }
  


    public DbSet<User> Utilizadores { get; set; }
    public DbSet<Ingredient> Ingredientes { get; set; }
    public DbSet<Category> Categorias { get; set; }
    public DbSet<Unity> Unidade { get; set; }
    public DbSet<State> State { get; set; }
    public DbSet<Difficulty> Dificuldade { get; set; }
    public DbSet<Recipe> Receitas { get; set; }
    public DbSet<RecipeIngredient> ReceitaIngredientes { get; set; }
    public DbSet<Highlight> Destaques { get; set; }
    public DbSet<Favorite> Favoritos { get; set; }
    public DbSet<Comment> Comentarios { get; set; }
    public DbSet<Temp> Temporario { get; set; }
    public DbSet<Permission> Permissao { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Seed();
    }

}

