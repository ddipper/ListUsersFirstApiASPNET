using System.Net.Cache;
using System.Text.RegularExpressions;

List<Person> users = new List<Person>
{
    new() {Id = Guid.NewGuid().ToString(), Name = "Tom", Age = 20},
    new() {Id = Guid.NewGuid().ToString(), Name = "Bob", Age = 32},
    new() {Id = Guid.NewGuid().ToString(), Name = "Sam", Age = 12}
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


public class Person
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public int Age { get; set; }
}