#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Configurator_PC/Configurator_PC.csproj", "Configurator_PC/"]
RUN dotnet restore "Configurator_PC/Configurator_PC.csproj"
COPY . .
WORKDIR "/src/Configurator_PC"
RUN dotnet build "Configurator_PC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Configurator_PC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Configurator_PC.dll"]