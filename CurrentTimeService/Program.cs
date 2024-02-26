var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok("Hello YOGI this new changes"));
//Console.WriteLine("Hello, .NET!");

//app.MapGet("/", () => Results.Ok("Hello YOGI this new changes"));


await app.RunAsync();



        
    