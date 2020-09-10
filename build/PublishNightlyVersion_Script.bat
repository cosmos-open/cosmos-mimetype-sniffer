@echo off

echo =======================================================================
echo Cosmos.Extensions.MimeTypeSniffer
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
dotnet pack src/Cosmos.Extensions.MimeTypeSniffer/Cosmos.Extensions.MimeTypeSniffer._build.csproj                                                               -c Release -o nuget_packages --no-restore

echo =======================================================================
echo Cosmos.Extensions.MimeTypeSniffer EXTRA
echo =======================================================================

::start to build, package and push solo/extra projects
cd extra/AspectCore
dotnet build MimeTypeSniffer-Extra-AspectCore.sln
cd ../..

cd extra/Autofac
dotnet build MimeTypeSniffer-Extra-Autofac.sln
cd ../..

cd extra/DI
dotnet build MimeTypeSniffer-Extra-DI.sln
cd ../..

dotnet pack extra/AspectCore/src/Extra/Extra.csproj    -c Release -o nuget_packages --no-restore
dotnet pack extra/Autofac/src/Extra/Extra.csproj       -c Release -o nuget_packages --no-restore
dotnet pack extra/DI/src/Extra/Extra.csproj            -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do (
    dotnet nuget push "%%s" -s "Nightly" --skip-duplicate
	echo.
)

::get back to build folder
cd build