FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 22017
EXPOSE 44374

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Onion.Api/Onion.Api.csproj Onion.Api/
RUN dotnet restore Onion.Api/Onion.Api.csproj
COPY . .
WORKDIR /src/Onion.Api
RUN dotnet build Onion.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Onion.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Onion.Api.dll"]
