using LoFit_Client.SpaEngine;
using LoFit_Client.SpaEngine.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LoFit_Client.Services.CommonServices;
using LoFit_Client.Services.ClientServices.Interfaces;
using LoFit_Client.Services.ClientServices;



var builder = WebAssemblyHostBuilder.CreateDefault(args);

CommonServices.ConfigureCommonServices(builder.Services);

builder.Services.AddTransient<ITrainingService, TrainingService>();

await builder.Build().RunAsync();
