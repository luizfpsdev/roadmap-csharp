using Recycle_web_api.Abstrations;
using Recycle_web_api.Middlewares;
using Recycle_web_api.Services;

var builder = WebApplication.CreateSlimBuilder(args);

// usado para serializar respostas dos endpoints gerados usando MinialAPIs
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});

builder.Services.AddScoped<ICicloDeVidaService, CicloDeVidaService>();
builder.Services.AddSingleton<ICiclodeVidaSingleton, CicloDeVidaSingleton>();
builder.Services.AddTransient<ICicloDeVidaTransientService, CicloDeVidaTransientService>();


builder.Services.AddSwaggerGen();

var app = builder.Build();

var sampleTodos = new Todo[] {
    new(1, "Walk the dog"),
    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
    new(4, "Clean the bathroom"),
    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
};

// minimal api bom para projetos pequenos e performáticos
var todosapi = app.MapGroup("/todos");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CultureMidleware>();

todosapi.MapGet("/", () => sampleTodos);
todosapi.MapGet("/{id}", (int id) =>
    sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
        ? Results.Ok(todo)
        : Results.NotFound());

app.MapControllers();
app.Run();

