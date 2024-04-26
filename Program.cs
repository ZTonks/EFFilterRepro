using EFRepro;
using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<ReproDbContext>();

optionsBuilder.UseCosmos(
    "https://localhost:8081",
    "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
    "repro-context");

var reproContext1 = new ReproDbContext(
    optionsBuilder.Options);

reproContext1.Foos.Add(
    new Foo()
    {
        Bar = "A",
        Baz = "B",
    });

reproContext1.Foos.Add(
    new Foo()
    {
        Bar = "C",
        Baz = "D",
    });

reproContext1.SaveChanges();

var reproContext2 = new ReproDbContext(
    optionsBuilder.Options);

var query = reproContext2.Foos.ToQueryString();

Console.WriteLine(query); // No filter - select all from root

var foos = reproContext2.Foos.ToList();

Console.WriteLine(foos.Count);
