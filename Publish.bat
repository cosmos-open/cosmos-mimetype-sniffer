@echo off

::create nuget_pub
if not exist nuget_pub (
    md nuget_pub
)

::clear nuget_pub
for /R "nuget_pub" %%s in (*) do (
    del %%s
)

::Core
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer -c Release -o ../../nuget_pub

::Extensions for dependency
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.Autofac -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Extensions.DependencyInjection -c Release -o ../../nuget_pub

::Extensions for library
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Development -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Image -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Media -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Office -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Science -c Release -o ../../nuget_pub
dotnet pack src/Cosmos.Business.Extensions.FileTypeSniffer.Library.Zip -c Release -o ../../nuget_pub

for /R "nuget_pub" %%s in (*symbols.nupkg) do (
    del %%s
)

echo.
echo.

set /p key=input key:
set source=https://api.nuget.org/v3/index.json

for /R "nuget_pub" %%s in (*.nupkg) do ( 
    call nuget push %%s %key% -Source %source%	
	echo.
)

pause