Publish (single-file EXE)
------------------------

From the repo root run (PowerShell):

dotnet publish WinFormsApp1.slnx -c Release -p:PublishProfile=FolderSingleFile.pubxml

Outputs will be in the publish\win-x64\ folder under the solution directory.
