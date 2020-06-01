FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.3-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.201-buster AS build
WORKDIR /src
COPY ["SpotToSpotMuzak.Server/SpotToSpotMuzak.Server.csproj", "SpotToSpotMuzak.Server/"]
COPY ["SpotToSpotMuzak.Shared/SpotToSpotMuzak.Shared.csproj", "SpotToSpotMuzak.Shared/"]
COPY ["SpotToSpotMuzak.Client/SpotToSpotMuzak.Client.csproj", "SpotToSpotMuzak.Client/"]
COPY ["SpotToSpotMuzak.CommonUI/SpotToSpotMuzak.CommonUI.csproj", "SpotToSpotMuzak.CommonUI/"]
COPY ["SpotToSpotMuzak.Storage/SpotToSpotMuzak.Storage.csproj", "SpotToSpotMuzak.Storage/"]
RUN dotnet restore "SpotToSpotMuzak.Server/SpotToSpotMuzak.Server.csproj"
COPY . .
WORKDIR "/src/SpotToSpotMuzak.Server"
ARG BUILD_CONFIG="Release_CSB"
RUN dotnet build "SpotToSpotMuzak.Server.csproj" -c $BUILD_CONFIG -o /app/build --no-restore

FROM build AS publish
ARG BUILD_CONFIG="Release_CSB"
RUN dotnet publish "SpotToSpotMuzak.Server.csproj" -c $BUILD_CONFIG -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpotToSpotMuzak.Server.dll"]