# Etapa base: imagen de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar y restaurar dependencias
COPY ["MicroservicioSolicitudSAC.csproj", "./"]
RUN dotnet restore "MicroservicioSolicitudSAC.csproj"

# Copiar el resto del código y compilar
COPY . .
WORKDIR /src
RUN dotnet build "MicroservicioSolicitudSAC.csproj" -c Release -o /app/build


# Etapa de publicación
FROM build AS publish
RUN dotnet publish "MicroservicioSolicitudSAC.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa final: imagen de ejecución
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicioSolicitudSAC.dll"]
