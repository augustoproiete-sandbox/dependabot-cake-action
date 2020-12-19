#addin "nuget:?package=Cake.MinVer&version=0.1.0"

var buildVersion = MinVer(s => s.WithTagPrefix("v").WithDefaultPreReleasePhase("preview"));
