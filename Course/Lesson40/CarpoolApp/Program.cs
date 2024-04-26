using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddSingleton<ICarpoolManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<CarpoolerContext>();
    optionsBuilder.UseSqlite("Data Source=CarpoolDataBase.db"); 
    var carpoolerContext = new CarpoolerContext(optionsBuilder.Options);
    carpoolerContext.Database.EnsureCreated(); 
    ICarpoolRepository carpoolerRepository = new CarpoolRepository(carpoolerContext);
    ICarpoolManager carpoolerManager = new CarpoolManager(carpoolerRepository);

    return carpoolerManager;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
