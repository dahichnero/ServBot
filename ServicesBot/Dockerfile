#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 88
EXPOSE 88

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ENV BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ServicesBot.csproj", "ServicesBot/"]
RUN dotnet restore "./ServicesBot/./ServicesBot.csproj"
WORKDIR "/src/ServicesBot"
COPY . .
RUN dotnet build "./ServicesBot.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ServicesBot.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServicesBot.dll"]