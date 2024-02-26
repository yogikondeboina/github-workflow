var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string userInput = Console.ReadLine();

        if (double.TryParse(userInput, out double number))
        {
            double result = SquareRootOfNumber(number);
            Console.WriteLine($"Square root of {number} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static double SquareRootOfNumber(double x)
    {
        return Math.Sqrt(x);
    }
}
