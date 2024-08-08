// MusicStreamingApp.AppHost/Program.cs
var builder = DistributedApplication.CreateBuilder(args);
var apiService = builder.AddProject<Projects.NETGroove_ApiService>("apiservice");
builder.AddProject<Projects.NETGroove_UserService>("userservice").WithReference(apiService);
builder.AddProject<Projects.NETGroove_CatalogService>("catalogservice").WithReference(apiService);
builder.AddProject<Projects.NETGroove_PlaylistService>("playlistservice").WithReference(apiService);
builder.AddProject<Projects.NetGroove_StreamingService>("streamingservice").WithReference(apiService);
builder.AddProject<Projects.NETGroove_RecommendationService>("recommendationservice").WithReference(apiService);
builder.AddProject<Projects.NetGroove_ArtistInfoService>("artistinfoservice").WithReference(apiService);
builder.AddProject<Projects.NETGroove_Web>("web").WithReference(apiService);
builder.Build().Run();