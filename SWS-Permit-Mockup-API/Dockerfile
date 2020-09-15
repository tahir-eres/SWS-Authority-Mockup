#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SWS.Mockups.Permit.Api.csproj", "SWS-Permit-Mockup-API/"]

RUN dotnet restore "./SWS-Permit-Mockup-API/SWS.Mockups.Permit.Api.csproj"
WORKDIR "/src/SWS-Permit-Mockup-API/"
COPY . .
RUN dotnet build "./SWS.Mockups.Permit.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./SWS.Mockups.Permit.Api.csproj" -c Release -o /app/publish

FROM base AS final
RUN unlink /etc/localtime
RUN ln -s /usr/share/zoneinfo/Asia/Dubai /etc/localtime

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SWS.Mockups.Permit.Api.dll"]

