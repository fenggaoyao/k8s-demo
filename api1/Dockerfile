FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["api1/api1.csproj", "api1/"]
RUN dotnet restore "api1/api1.csproj"
COPY . .
WORKDIR "/src/api1"
RUN dotnet build "api1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api1.dll"]
