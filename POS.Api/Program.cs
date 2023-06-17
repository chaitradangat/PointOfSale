using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using POS.Api;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, builder.Environment);

/*
var builder = WebApplication.CreateBuilder(args);

//Azure AD stuff
ConfigurationBuilder builder1 = new ConfigurationBuilder();

builder1.AddAzureKeyVault(new Uri("xxxx"), new DefaultAzureCredential());

IConfiguration configuration = builder1.Build();

Console.WriteLine(configuration["pos-db-constring"]);


// Add services to the container.
1.

var app = builder.Build();

// Configure the HTTP request pipeline.
2.
*/