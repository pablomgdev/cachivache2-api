FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY cachivache2-api.sln .
COPY Tests/*.csproj Tests/
COPY src/Api/*.csproj src/Api/
COPY src/ApiSdk/*.csproj src/ApiSdk/

COPY src/AppRequests/*.csproj src/AppRequests/
COPY src/AppRequests/Application/*.csproj src/AppRequests/Application/
COPY src/AppRequests/Domain/*.csproj src/AppRequests/Domain/
COPY src/AppRequests/Infrastructure/*.csproj src/AppRequests/Infrastructure/

COPY src/Notifications/*.csproj src/Notifications/
COPY src/Notifications/Application/*.csproj src/Notifications/Application/
COPY src/Notifications/Domain/*.csproj src/Notifications/Domain/
COPY src/Notifications/Infrastructure/*.csproj src/Notifications/Infrastructure/

COPY src/Presents/*.csproj src/Presents/
COPY src/Presents/Application/*.csproj src/Presents/Application/
COPY src/Presents/Domain/*.csproj src/Presents/Domain/
COPY src/Presents/Infrastructure/*.csproj src/Presents/Infrastructure/

COPY src/Users/*.csproj src/Users/
COPY src/Users/Application/*.csproj src/Users/Application/
COPY src/Users/Domain/*.csproj src/Users/Domain/
COPY src/Users/Infrastructure/*.csproj src/Users/Infrastructure/

COPY src/Shared/*.csproj src/Shared/
COPY src/Shared/Domain/*.csproj src/Shared/Domain/

RUN dotnet restore

COPY . .
RUN dotnet publish src/Api/Api.csproj -c Release -o out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Api.dll"]
