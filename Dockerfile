FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:3.1

WORKDIR /app

EXPOSE 4141/tcp

ENV ASPNETCORE_URLS http://*:4141

COPY — from=build-env /app/out .
ENTRYPOINT ["dotnet", "SchmersalSampleAppLib.dll"]
