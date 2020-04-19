FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
ENV SqlConn "Server=empyserver.database.windows.net;Database=EmployeeData;User ID=emp;Password=K8s@2020"
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "EmployeeMgmt.dll"]