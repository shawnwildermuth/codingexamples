var builder = DistributedApplication.CreateBuilder(args);

var connString = builder.AddConnectionString("ShoeMoneyDb");

var userName = builder.AddParameter("queueusername");
var pwd= builder.AddParameter("queuepassword");

var queue = builder.AddRabbitMQ("theQueue", userName, pwd)
  .WithManagementPlugin();

var theApi = builder.AddProject<Projects.ShoeMoney_API>("theApi")
  .WithReference(queue)
  .WithReference(connString);

builder.AddProject<Projects.ShoeMoney_OrderProcessing>("orders")
  .WithReference(queue)
  .WithReference(connString);

builder.AddNpmApp("client", "../shoemoney.store/", "dev")
  .WithReference(theApi)
  .WithHttpEndpoint(env: "PORT");

builder.Build().Run();
