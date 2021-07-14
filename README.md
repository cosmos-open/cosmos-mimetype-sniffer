# COSMOSLOOPS/MimeTypeSniffer

Mime type sniffer component, a library that used to identify the real type of physical file via infering the head of the file binary information, and then returns the MIME type for that/those file extension name(s). 

This repository belongs to [Open Cosmos](https://github.com/cosmos-open) Project, a part of [COSMOS LOOPS PROGRAMME](https://github.com/cosmos-loops/).

This project depend on [OPENCOSMOS/FileTypeSniffer](https://github.com/cosmos-open/cosmos-filetype-sniffer).

---

## Nuget Packages

| Package Name                                                                                                                                                                           | Version                                                                                                           | Downloads                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------ |
| [Cosmos.Extensions.MimeTypeSniffer](https://www.nuget.org/packages/Cosmos.Extensions.MimeTypeSniffer/)                                                               | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.MimeTypeSniffer.svg)                                | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.MimeTypeSniffer.svg)                                |
| [Cosmos.Extensions.MimeTypeSniffer.Extra.DependencyInjection](https://www.nuget.org/packages/Cosmos.Extensions.MimeTypeSniffer.Extra.DependencyInjection/) | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.MimeTypeSniffer.Extra.DependencyInjection.svg) | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.MimeTypeSniffer.Extra.DependencyInjection.svg) |
| [Cosmos.Extensions.MimeTypeSniffer.Extra.Autofac](https://www.nuget.org/packages/Cosmos.Extensions.MimeTypeSniffer.Extra.Autofac/)                         | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.MimeTypeSniffer.Extra.Autofac.svg)             | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.MimeTypeSniffer.Extra.Autofac.svg)             |
| [Cosmos.Extensions.MimeTypeSniffer.Extra.AspectCoreInjector](https://www.nuget.org/packages/Cosmos.Extensions.MimeTypeSniffer.Extra.AspectCoreInjector/)   | ![](https://img.shields.io/nuget/v/Cosmos.Extensions.MimeTypeSniffer.Extra.AspectCoreInjector.svg)  | ![](https://img.shields.io/nuget/dt/Cosmos.Extensions.MimeTypeSniffer.Extra.AspectCoreInjector.svg)  |

## Usage

### Install the package

Choose one kind of dependency extensions that you need and install it via nuget.

```
Install-Package Cosmos.Extensions.MimeTypeSniffer.Extra.DependencyInjection
Install-Package Cosmos.Extensions.MimeTypeSniffer.Extra.Autofac
```

or use directly

```
Install-Package Cosmos.Extensions.MimeTypeSniffer
```

Install the specific file type libraries of [FileTypeSniffer](https://github.com/cosmos-open/cosmos-filetype-sniffer#nuget-packages) as needed.

### Config in Startup class

```c#
public class Startup
{
    //...
    public void ConfigureServices(IServiceCollection services)
    {
        //configuration
        services.AddCosmosFileTypeSniffer();
        // since MimeTypeSniffer is depended on FileTypeSniffer
        services.AddCosmosMimeTypeSniffer();
    }
}
```

...Also, you can juse register MimeTypeSniffer:

```c#
public class Startup
{
    //...
    public void ConfigureServices(IServiceCollection services)
    {
        //configuration
        services.AddCosmosMimeTypeSniffer();
        //It'll register FileTypeSniffer automatically
    }
}
```

### Use directly

```c#
IFileTypeSniffer fileTypeSniffer = Get();//... get instance of IFileTypeSniffer 

var library = new MimeTypeLibrary();
var defaultProvider = new DefaultMimeTypeProvider();
library.Register(defaultProvider.GetMimeTypes());

IMimeTypeFinder finder = new MimeTypeFinder(library);

var sniffer = new MimeTypeSniffer(fileTypeSniffer, finder);

//sniffer.Match...
```

### Write code

```c#
//Get sniffer from DI or use dirsctly
//_sniffer...

//Load file from some place...
var path = Path.Combine(Local, fileName);
byte[] array = new byte[20];
using (var file = File.Open(path, FileMode.Open))
{
    file.Read(array, 0, array.Length);
}
var results = _sniffer.Match(bytes, true);
//..
```

### Find single result or multiple results

```c#
//For single result in list, false as default:
List<string> results0 = _sniffer.Match(bytes, false);

//For multiple results:
List<string> results1 = _sniffer.Match(bytes, true);

//or
string result2 = _sniffer.MatchSingle(bytes);
```

### Available file types

Full list of available file types is [here](https://github.com/cosmos-open/cosmos-filetype-sniffer#available-file-types).


### How to Unit Test

Copy the `tests\samples` directory under the tests folder to `tests\IntegrationTests\bin\Debug\netcoreapp2.2`.

---

## Thanks

People or projects that have made a great contribbution to this project:

- _null_
- _The next one must be you_

### Organizations and projects

- _null_

---

## License

Member project of [COSMOS LOOPS PROGRAMME](https://github.com/cosmos-loops).

[Apache 2.0 License](/LICENSE)
