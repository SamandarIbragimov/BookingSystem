FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY BookingService/*.csproj ./BookingService/
RUN dotnet restore "BookingService/BookingService.csproj"
COPY BookingService/. ./BookingService
RUN dotnet publish "BookingService/BookingService.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:${PORT:-8080}
EXPOSE 8080
ENTRYPOINT ["dotnet", "BookingService.dll"]
