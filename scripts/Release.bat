@echo off

echo =======================================================================
echo Cosmos.MimeTypeSniffer
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
dotnet pack src/Cosmos.MimeTypeSniffer                           -c Release -o nuget_packages --no-restore

::extra
dotnet pack src/Cosmos.MimeTypeSniffer.DependOn.AspectCoreInjector  -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.MimeTypeSniffer.DependOn.Autofac             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.MimeTypeSniffer.DependOn.DependencyInjection -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do ( 	
    dotnet nuget push "%%s" -s "Release" --skip-duplicate
	echo.
)

::get back to build folder
cd scripts