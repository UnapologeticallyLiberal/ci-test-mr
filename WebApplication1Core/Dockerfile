# Preparation
FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /source
COPY ["src/WebApplication1Core/WebApplication1Core.csproj", "./WebApplication1Core"]
RUN ls -lah
RUN dotnet restore "./WebApplication1Core/WebApplication1Core.csproj"
COPY . .

#Build
WORKDIR /source/src
RUN dotnet publish -c Release -o /publish

# Runtime
FROM microsoft/dotnet:2.1-aspnetcore-runtime
EXPOSE 80
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "WebApplication1Core.dll"]
