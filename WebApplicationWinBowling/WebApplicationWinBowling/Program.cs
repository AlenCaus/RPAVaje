using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }



        app.MapGet("/igralci", () =>
        {
            if (!File.Exists("baza.json"))
            {
                return new List<IgralecModel>();
            }
            return JsonSerializer.Deserialize<List<IgralecModel>>
            (File.ReadAllText("baza.json"));
        })
        .WithName("GetIgralci")
        .WithOpenApi();

        app.MapPut("/igralci", (List<IgralecModel> igralci) =>
        {
            string jsonString = JsonSerializer.Serialize(igralci);
            File.WriteAllText("baza.json", jsonString);
        })
        .WithName("PutIgralci")
        .WithOpenApi();

        app.Run();
    }
}

public class IgralecModel
{
    public string Ime { get; set; }
    public int Tocke { get; set; }

}