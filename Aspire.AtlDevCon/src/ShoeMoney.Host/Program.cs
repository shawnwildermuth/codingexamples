using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var userResource = builder.AddParameter("queueUserName");
var passwordResource = builder.AddParameter("queuePassword");

var connectionString = builder.AddConnectionString("ShoeMoneyDb");

var cache = builder.AddRedis("theCache");
var theQueue = builder.AddRabbitMQ("theQueue", userResource, passwordResource);

var theApi = builder.AddProject<Projects.ShoeMoney_API>("theApi")
  .WithReference(connectionString)
  .WithReference(cache)
  .WithReference(theQueue);

builder.AddProject<Projects.ShoeMoney_OrderProcessing>("theProcessor")
  .WithReference(connectionString)
  .WithReference(theQueue);

builder.AddNpmApp("store", "../shoemoney.store/", "dev")
  .WithReference(theApi)
  .WithHttpEndpoint(env: "PORT");

builder.Build().Run();
