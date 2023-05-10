// ex. StringBuilder

using BuilderPattern.Builders;

UrlBuilder urlBuilder = new("https://www.example.com");
urlBuilder
    .AddPath("api")
    .AddPath("v1")
    .AddPath("users")
    .AddQuery("id", "1")
    .AddQuery("name", "John");

Console.WriteLine(urlBuilder.Build());
Console.ReadLine();