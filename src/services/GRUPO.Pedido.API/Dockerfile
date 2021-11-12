#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/services/GRUPO.Pedido.API/GRUPO.Pedido.API.csproj", "src/services/GRUPO.Pedido.API/"]
RUN dotnet restore "src/services/GRUPO.Pedido.API/GRUPO.Pedido.API.csproj"
COPY . .
WORKDIR "/src/src/services/GRUPO.Pedido.API"
RUN dotnet build "GRUPO.Pedido.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GRUPO.Pedido.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GRUPO.Pedido.API.dll"]