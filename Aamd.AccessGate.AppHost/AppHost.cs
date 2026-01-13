var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Aamd_LetMeIn_Tests_Client>("aamd-lestmein-tests-client");

builder.AddProject<Projects.Aamd_LetMeIn_Tests_ApiGateway>("aamd-letmein-tests-apigateway");

builder.AddProject<Projects.Aamd_LetMeIn_Web>("aamd-letmein-web");

builder.Build().Run();
