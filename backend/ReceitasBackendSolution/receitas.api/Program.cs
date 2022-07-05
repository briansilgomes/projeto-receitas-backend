
using receitas.api.Data;
using receitas.api.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http:/localhost")
            .AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod();
        });
});



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ReceitasDbContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IIngredientSercvice, IngredientService>();
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IUnityService, UnityService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IHighlightServcie, HighlightService>();
builder.Services.AddScoped<IFavoriteService, FavoriteService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IDifficultyService, DifficultyService>();
builder.Services.AddScoped<ITempService, TempService>();
builder.Services.AddScoped<IPermissionService, PermissionService>();
builder.Services.AddScoped<IStateService, StateService>();

builder.Services.AddScoped<IUserDao, UserDao>();
builder.Services.AddScoped<IIngredientDao, IngredtientDao>();
builder.Services.AddScoped<ICategoryDao, CategoryDao>();
builder.Services.AddScoped<IUnityDao, UnityDao>();
builder.Services.AddScoped<IRecipeDao, RecipeDao>();
builder.Services.AddScoped<IHighlightDao, HighlightDao>();
builder.Services.AddScoped<IFavoriteDao, FavoriteDao>();
builder.Services.AddScoped<ICommentDao, CommentDao>();
builder.Services.AddScoped<IDifficultyDao, DifficultyDao>();
builder.Services.AddScoped<ITemp, TempDao>();
builder.Services.AddScoped<IPermissionDao, PermissionDao>();
builder.Services.AddScoped<IStateDao, StateDao>();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.


app.UseAuthorization();

app.MapControllers();



app.Run();