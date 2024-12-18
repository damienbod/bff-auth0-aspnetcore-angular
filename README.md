# Auth0 BFF security architecture using ASP.NET Core and nx Angular standalone
npm 
[![.NET and npm build](https://github.com/damienbod/bff-auth0-aspnetcore-angular/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/bff-auth0-aspnetcore-angular/actions/workflows/dotnet.yml) [![License](https://img.shields.io/badge/license-Apache%20License%202.0-blue.svg)](https://github.com/damienbod/bff-auth0-aspnetcore-angular/blob/main/LICENSE)

[Secure Angular application using Auth0 and ASP.NET Core with BFF](https://damienbod.com/2023/09/18/secure-angular-application-using-auth0-and-asp-net-core-with-bff/)

## Debugging

Start the Angular project from the **ui** folder

```
nx serve --ssl
```

Start the ASP.NET Core project from the **server** folder

```
dotnet run
```

Or just open Visual Studio and run the solution.

## Credits and used libraries

- NetEscapades.AspNetCore.SecurityHeaders
- Yarp.ReverseProxy
- ASP.NET Core
- Angular 
- Nx

## Angular nx Updates

```
nx migrate latest

nx migrate --run-migrations=migrations.json
```

## History

- 2024-12-18 Angular 19
- 2024-12-06 .NET 9
- 2024-10-17 Improved security headers performance, updated packages
- 2024-10-06 Updated Angular 18.2.7
- 2024-10-03 Updated packages
- 2024-06-06 Updated packages
- 2024-04-27 Updated build
- 2024-04-14 Updated packages
- 2024-01-14 Updated packages
- 2023-12-31 Open redirect protection added to login
- 2023-11-17 Updated .NET 8

## Links

https://github.com/damienbod/bff-aspnetcore-angular

https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core

https://nx.dev/getting-started/intro

https://auth0.com/docs

https://github.com/isolutionsag/aspnet-react-bff-proxy-example

https://damienbod.com/2021/04/12/securing-blazor-web-assembly-using-cookies-and-auth0/

https://github.com/damienbod/bff-openiddict-aspnetcore-angular

https://github.com/damienbod/bff-azureadb2c-aspnetcore-angular

https://github.com/damienbod/bff-aspnetcore-vuejs

https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular
