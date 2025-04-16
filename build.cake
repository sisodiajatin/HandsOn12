#addin "nuget:?package=StyleCop.Analyzers&version=1.2.0"

Task("Build")
    .Does(() =>
{
    Information("Building Hello World Console App...");
    DotNetBuild("./HelloWorldApp.csproj");
});

Task("Analyze")
    .Does(() =>
{
    Information("Running StyleCop Analyzers...");
    DotNetRun("dotnet stylecop");
});

Task("GenerateDocs")
    .Does(() =>
{
    Information("Generating Documentation...");
    StartProcess("doxygen", "./Doxyfile");
});

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Analyze")
    .IsDependentOn("GenerateDocs");

RunTarget("Default");
