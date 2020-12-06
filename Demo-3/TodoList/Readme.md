[Build a Blazor todo list app](https://docs.microsoft.com/en-us/aspnet/core/tutorials/build-a-blazor-app?view=aspnetcore-3.1)

``` usefull commands 
Examples:- 

Example 1:- 

<!-- In order to  create Blazor server app  with out https  -->
dotnet new blazorserver -o BlazorApp --no-https

<!-- In order to run Blazor server app  -->
dotnet run 
```

``` Example-2
Example 2:- 
<!-- In order to  create Blazor server app  -->
dotnet new blazorserver -o TodoList

<!-- In order to  create razor component -->
dotnet new razorcomponent -n Todo -o Pages

<!-- In order to clean project -->
dotnet clean .\TodoList.csproj 

<!-- In order to build project using debug configuration -->

dotnet build .\TodoList.csproj  -c debug

<!--  In order to build project using release configuration -->

dotnet build .\TodoList.csproj  -c release

<!-- In order to add certification  -->

dotnet dev-certs https --clean
dotnet dev-certs https -t

<!--  In order to add endpoints in Appconfig.json for kestrel server  -->

dotnet dev-certs https --clean
dotnet dev-certs https -t
or 
dotnet dev-certs https --trust


```