#tool "nuget:?package=GitVersion.CommandLine"

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  GitVersion(new GitVersionSettings {
        UpdateAssemblyInfo = true
    });
});

RunTarget(target);