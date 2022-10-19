using F1Reader;
using RaceReader;
using RaceReader.Clients;
using RaceReader.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IF1Service, F1Service>();
        services.AddTransient<F1ReaderProgram>();
        services.AddHttpClient<F1Client>(c => c.BaseAddress = new Uri("http://ergast.com/"));
    })
    .Build();

var raceReaderProgram = host.Services.GetRequiredService<F1ReaderProgram>();
raceReaderProgram.Execute();
Console.WriteLine("Press any key to finish");
Console.ReadKey();
