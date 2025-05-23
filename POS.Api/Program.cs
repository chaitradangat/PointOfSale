using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

using POS.Api;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, builder.Environment);