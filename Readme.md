F# Templates for `dotnet new`
=============================

Installation

* Checkout the repository
* `dotnet new --install FSharpTemplates/content/FSharp-Dll-Sln`

FSharp-Dll-Sln
--------------

A full F# solution for VS2015 / .Net 4.5.2 using paket as package manager and
FAKE as build system.

The solution come with 2 projects: A library and an unit test project
(Using NUnit).

Parameters:
* `--github-user` Name of the github user as it appear in URLs
* `--github-projectuser` Name of the github project as it appear in URLs
* `--nuget` Name of the nuget package
* `--author` Full name of the author (For copyright, nuget package author, ...)