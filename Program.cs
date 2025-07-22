namespace CoreConsole;

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


public class Program
{
    static void Main(string[] args)
    {
		// Console.WriteLine("Hello, World!");
		
		var config = new ConfigurationBuilder()
			.AddCommandLine(args)
			.Build();

		var host = new WebHostBuilder()
			.UseKestrel()
			.UseConfiguration(config)
			.UseStartup<Startup>()
			.Build();

		host.Run();
    }
}

[Route("[controller]")]
public class HelloWorldController : Controller
{
	[HttpGet]
	public string Index()
	{

		Console.WriteLine("Hello World, Han Sti from [ACR][A515]/CoreConsole!");
		return "Hello World, Han Sti from [ACR][A515]/CoreConsole!";
	}
}

public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMvc();
	}

	public void Configure(IApplicationBuilder app)
	{
		app.UseMvc();
	}
}