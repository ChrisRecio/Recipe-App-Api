#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Recipe App Api/Recipe App Api.csproj", "Recipe App Api/"]
RUN dotnet restore "Recipe App Api/Recipe App Api.csproj"
COPY . .
WORKDIR "/src/Recipe App Api"
RUN dotnet build "Recipe App Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Recipe App Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Recipe App Api.dll"]