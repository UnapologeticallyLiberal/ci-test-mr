FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WebApplication1Core/WebApplication1Core.csproj", "WebApplication1Core/"]
RUN dotnet restore "WebApplication1Core/WebApplication1Core.csproj"
COPY . .
WORKDIR "/src/WebApplication1Core"
RUN dotnet build "WebApplication1Core.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApplication1Core.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApplication1Core.dll"]