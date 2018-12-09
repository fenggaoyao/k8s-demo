FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["api2/api2.csproj", "api2/"]
RUN dotnet restore "api2/api2.csproj"
COPY . .
WORKDIR "/src/api2"
RUN dotnet build "api2.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api2.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api2.dll"]
