#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim-amd64 AS build
WORKDIR /src
COPY ["DeveOspStreamCombiner/DeveOspStreamCombiner.csproj", "DeveOspStreamCombiner/"]
RUN dotnet restore "DeveOspStreamCombiner/DeveOspStreamCombiner.csproj"
COPY . .
WORKDIR "/src/DeveOspStreamCombiner"
RUN dotnet build "DeveOspStreamCombiner.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_VERSION
ARG VER=${BUILD_VERSION:-1.0.0}
RUN dotnet publish "DeveOspStreamCombiner.csproj" -c Release -o /app/publish /p:Version=$VER /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeveOspStreamCombiner.dll"]