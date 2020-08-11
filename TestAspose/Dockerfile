FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY TestAspose.csproj .

RUN dotnet restore TestAspose.csproj

COPY . .
RUN dotnet publish TestAspose.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS run
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "TestAspose.dll"]