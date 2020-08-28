# Code for tutorial ["Scale ASP.NET Core Apps with Docker Swarm Mode"](https://www.pluralsight.com/guides/scale-asp-net-core-apps-with-docker-swarm-mode) by Stefan Prodan

When I followed the tutorial I encountered lots (**lots**) of errors and wasted lots of time because it seems like the tutorial is already very old. It was written for .NET Core version 1.0.0-preview2-003121.

You can avoid the errors ignoring by the first part  -- the "Build the app" part -- and follow the ["Dockerize an ASP.NET Core application"](https://docs.docker.com/engine/examples/dotnetcore/) tutorial from the Docker docs instead.


**I also created a guide for the first part: ["Docker Swarm with ASP.NET introductory tutorial"](https://jeremiahflaga.github.io/2020/09/01/docker-swarm-with-aspnet-tutorial)**


### Errors

**docker build error "The current .NET SDK does not support targeting .NET Core 3.1"**

Solution: [Use explicit version tag in Dockerfile](https://github.com/OmniSharp/generator-aspnet/pull/854)

For example, use the one being used in [eShopOnConainers](https://github.com/dotnet-architecture/eShopOnContainers/blob/dev/src/Services/Basket/Basket.API/Dockerfile): `mcr.microsoft.com/dotnet/core/sdk:3.1`


- https://stackoverflow.com/questions/50787895/docker-build-fails-with-the-current-net-sdk-does-not-support-targeting-net-cor
- https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows

**docker build "It was not possible to find any installed .NET Core SDKs"**

- https://stackoverflow.com/questions/60119220/error-it-was-not-possible-to-find-any-installed-net-core-sdks