using LiteDB;

var builder = WebApplication.CreateBuilder(args);

//config do LiteDB
builder.Services.AddSingleton<LiteDatabase>(_ =>
{
    var dbPath = "parkpi.db";
    return new LiteDatabase($"Filename = {dbPath}; ConnectionString=SharedDataReader");
});

//repositorios
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddSingleton<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddSingleton<IRegistroMovimentacaoRepository, RegistroMovimentacaoRepository>();

//use cases
builder.Services.AddScoped<RegistrarEntradaUseCase>();
builder.Services.AddScoped<RegistrarSaidaUseCase>();

//config de serviços de web api
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();