#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["e-shopBlazorApp/e-shopBlazorApp.csproj", "e-shopBlazorApp/"]
RUN dotnet restore "e-shopBlazorApp/e-shopBlazorApp.csproj"
COPY . .
WORKDIR "/src/e-shopBlazorApp"
RUN dotnet build "e-shopBlazorApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "e-shopBlazorApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "e-shopBlazorApp.dll"]