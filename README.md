# 6Net

## skills - training - mind games

## focus - repetition - practice


***

## Design Patterns

https://www.dofactory.com/net/observer-design-pattern

https://refactoring.guru/design-patterns/behavioral-patterns


***

Architecture

    Corp.DOMAIN
        BAL: Business logic layer.
        DTO: Data transfer objects.
    Corp.DATA
        DAL: Data acess layer.
        Migrations EF.
    Corp.API
        API: Web API.
    Corp.WEB:
        APP: Application client.
    Corp.TEST:
        UnitTest: Unit Test project.


***

## Commands

create: `dotnet new classlib -o StringLibrary`

create: `dotnet new console -o Net6Migrations`

add lib ref

`dotnet add reference lib1/originPro.csproj lib2/targetPro.cspro`

`dotnet add reference Net6Data.csproj ../Net6DTO/Net6DTO.csproj`

<ItemGroup>
  <ProjectReference Include="originPro.csproj" />
  <ProjectReference Include="..\lib2\lib2.csproj" />
  <ProjectReference Include="..\lib1\lib1.csproj" />
</ItemGroup>

`dotnet run --urls "http://localhost:5100"`


add lib to sln

`dotnet sln add StringLibrary/StringLibrary.csproj`


run project 

`dotnet run --project ShowCase/ShowCase.csproj`

Nuget
`dotnet add package Newtonsoft.Json`

`dotnet tool install --global dotnet-ef`

`dotnet add package Microsoft.EntityFrameworkCore`

`dotnet add package Microsoft.EntityFrameworkCore.Design`

EF core migration tool

`dotnet tool install --global dotnet-ef`

***

#EF

`dotnet ef dbcontext Scaffold "workstation id=xdavidgomez13.mssql.somee.com;packet size=4096;user id=xdavidgomez13_SQLLogin_1;pwd=******;data source=xdavidgomez13.mssql.somee.com;persist security info=False;initial catalog=xdavidgomez13" Microsoft.EntityFrameworkCore.SqlServer -o Context`

## Migrations

Initial migration

`dotnet ef migrations add Initial --context ContextDal`

Update DB

`dotnet ef database update --context ContextDal1`

***

Markdown basics

https://markdown-guide.readthedocs.io/en/latest/basics.html

