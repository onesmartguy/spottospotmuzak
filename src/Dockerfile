FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.3-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.201-buster AS build
WORKDIR /src
COPY ["SpotToSpotMuzik.Server/SpotToSpotMuzik.Server.csproj", "SpotToSpotMuzik.Server/"]
COPY ["SpotToSpotMuzik.Shared/SpotToSpotMuzik.Shared.csproj", "SpotToSpotMuzik.Shared/"]
COPY ["SpotToSpotMuzik.Client/SpotToSpotMuzik.Client.csproj", "SpotToSpotMuzik.Client/"]
COPY ["SpotToSpotMuzik.CommonUI/SpotToSpotMuzik.CommonUI.csproj", "SpotToSpotMuzik.CommonUI/"]
COPY ["SpotToSpotMuzik.Storage/SpotToSpotMuzik.Storage.csproj", "SpotToSpotMuzik.Storage/"]
RUN dotnet restore "SpotToSpotMuzik.Server/SpotToSpotMuzik.Server.csproj"
COPY . .
WORKDIR "/src/SpotToSpotMuzik.Server"
ARG BUILD_CONFIG="Release_CSB"
RUN dotnet build "SpotToSpotMuzik.Server.csproj" -c $BUILD_CONFIG -o /app/build --no-restore

FROM build AS publish
ARG BUILD_CONFIG="Release_CSB"
RUN dotnet publish "SpotToSpotMuzik.Server.csproj" -c $BUILD_CONFIG -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpotToSpotMuzik.Server.dll"]