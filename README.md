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
        SAL: Data acess layer.
        Migrations EF.
    Corp.API
        API: Web API.
    Corp.WEB:
        APP: Application client.
    Corp.TEST:
        UnitTest: Unit Test project.


***

## Commands

add lib ref

`dotnet add reference lib1/originPro.csproj lib2/targetPro.cspro`

<ItemGroup>
  <ProjectReference Include="originPro.csproj" />
  <ProjectReference Include="..\lib2\lib2.csproj" />
  <ProjectReference Include="..\lib1\lib1.csproj" />
</ItemGroup>

`dotnet run --urls "http://localhost:5100"`

***

Markdown basics

https://markdown-guide.readthedocs.io/en/latest/basics.html

