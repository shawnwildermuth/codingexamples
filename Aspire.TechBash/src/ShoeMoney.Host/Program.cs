var builder = DistributedApplication.CreateBuilder(args);

var connectionString = builder.AddConnectionString("ShoeMoneyDb");

var cache = builder.AddRedis("theCache");

var queueUsername = builder.AddParameter("queueUserName");
var queuePassword = builder.AddParameter("queuePassword");

var queue = builder.AddRabbitMQ("queue", queueUsername, queuePassword);

var theApi = builder.AddProject<Projects.ShoeMoney_API>("theApi")
  .WithReference(queue)
  .WithReference(cache)
  .WithReference(connectionString);

builder.AddProject<Projects.ShoeMoney_OrderProcessing>("orderProcessor")
  .WithReference(queue)
  .WithReference(connectionString);

builder.AddNpmApp("frontend", "../shoemoney.store", "dev")
  .WithReference(theApi)
  .WithHttpEndpoint(env: "PORT");

builder.Build().Run();
