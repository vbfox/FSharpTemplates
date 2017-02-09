F# Templates for `dotnet new`
=============================

> ️️️⚠️️ All theses templates reflect my personal way of architecturing projects, if you don't like it fork and create your own !

Installation

* Checkout the repository
* `dotnet new --install FSharpTemplates/content/FSharp-Dll-Sln`

FSharp-Dll-Sln
--------------

My own take on a full F# solution for VS2015 / .Net 4.5.2 :

* Project must be hosted on GitHub
* Include a library project and an unit test (NUnit) project
* Use paket as package manager.
* FAKE as build system with a [ProjectScaffold](https://fsprojects.github.io/ProjectScaffold/) inspired script
  * Take the version number from a `Release Notes.md` file
  * SourceLink is automatically applied to have the pdb link to GitHub
  * `build` Build & run the unit tests
  * `build release` Create a Git tag, GitHub release and publish the package to Nuget
* Is ready for AppVeyor
  * Publishing correct version numbers
  * Uploading test results
  * Publishing artifacts (Zip file and Nuget package)
* Is ready for TravisCI
* All build output is in `/artifacts/` (bin, obj, nuget package)

The solution come with 2 projects: A library and an unit test project
(Using NUnit).

Parameters:
* `--github-user` Name of the github user as it appear in URLs
* `--github-project` Name of the github project as it appear in URLs
* `--nuget` Name of the nuget package
* `--author` Full name of the author (For copyright, nuget package author, ...)
