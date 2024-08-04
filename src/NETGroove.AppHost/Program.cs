// MusicStreamingApp.AppHost/Program.cs
var builder = DistributedApplication.CreateBuilder(args);

var apiGateway = builder.AddProject<Projects.NETGroove_ApiService>("apigateway");

builder.AddProject<Projects.NETGroove_UserService>("userservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NETGroove_CatalogService>("catalogservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NETGroove_PlaylistService>("playlistservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NetGroove_StreamingService>("streamingservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NETGroove_RecommendationService>("recommendationservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NetGroove_ArtistInfoService>("artistinfoservice")
    .WithReference(apiGateway);
builder.AddProject<Projects.NETGroove_Web>("web")
    .WithReference(apiGateway);

builder.Build().Run();