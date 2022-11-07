# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /app
RUN dotnet restore
RUN dotnet publish -o /app/published-app

# Production stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/published-app /app

EXPOSE 5000/tcp
EXPOSE 5443/tcp

ENTRYPOINT [ "dotnet", "/app/WatchYourFood.dll" ]