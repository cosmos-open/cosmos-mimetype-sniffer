@echo off

echo =======================================================================
echo CosmosStack.MimeTypeSniffer
echo =======================================================================

::go to parent folder
cd ..

::create nuget_packages
if not exist nuget_packages (
    md nuget_packages
    echo Created nuget_packages folder.
)

::clear nuget_packages
for /R "nuget_packages" %%s in (*) do (
    del "%%s"
)
echo Cleaned up all nuget packages.
echo.

::start to package all projects
dotnet pack src/CosmosStack.Extensions.MimeTypeSniffer                           -c Release -o nuget_packages --no-restore

::extra
dotnet pack src/CosmosStack.Extensions.MimeTypeSniffer.Extra.AspectCoreInjector  -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.MimeTypeSniffer.Extra.Autofac             -c Release -o nuget_packages --no-restore
dotnet pack src/CosmosStack.Extensions.MimeTypeSniffer.Extra.DependencyInjection -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

::get back to build folder
cd scripts