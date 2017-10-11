#tool "nuget:?package=GitVersion.CommandLine"

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    var version = GitVersion(new GitVersionSettings {
        UpdateAssemblyInfo = true
    });

    if(AppVeyor.IsRunningOnAppVeyor){
        AppVeyor.UpdateBuildVersion(version.FullSemVer);
    }
});

RunTarget(target);