using EFRepro;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<ReproDbContext>();

optionsBuilder.UseCosmos(
    "https://localhost:8081",
    "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
    "repro-context");

var reproContext = new ReproDbContext(
    optionsBuilder.Options);

var query = reproContext.Foos.ToQueryString();

Console.WriteLine(query); // No filter - select all from root

