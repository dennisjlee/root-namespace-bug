# root-namespace-bug
Quick demo of a bug in JetBrains Rider around parsing RootNamespace in project files

Reproduction steps:
* Load this project in JetBrains Rider (I originally found this in 2018.3).
* Open RootNamespaceBug/Program.cs
* Note that "VBClass" and "VBNamespace" are showing up as errors
* Build the solution - note that the solution builds properly with MSBuild

The crux of the problem seems to be that VBLibrary has a <RootNamespace> element with nothing but whitespace in it (spaces and a newline). 
Rider is interpreting that whitespace as part of the namespace. This is not happening for an equivalent C# project.
