FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM base AS final
WORKDIR /app
ADD /builds/ebsone/ci-test-mr/WebApplication1Core/WebApplication1Core/bin/Debug/netcoreapp2.1 .
ENTRYPOINT ["dotnet", "netcoreapp2.1/WebApplication1Core.dll"]