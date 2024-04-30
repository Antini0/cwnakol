var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddXmlSerializerFormatters();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// var list = new List<int> { 1, 2, 3, 4, 5 };
//
// var evens = list.Where(n => n % 2 == 0); //linq
//
// foreach(int i in evens){
//     Console.WriteLine(i);
// }

//app controllers
app.MapControllers();

app.Run();

