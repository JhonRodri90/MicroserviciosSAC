# Etapa base: imagen de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar toda la solución (todo lo que está por encima del Dockerfile)
COPY ../../ ./

# Restaurar dependencias del proyecto principal
RUN dotnet restore "MicroservicioSolicitudSAC/MicroservicioSolicitudSAC.csproj"

# Construir el proyecto principal
RUN dotnet build "MicroservicioSolicitudSAC/MicroservicioSolicitudSAC.csproj" -c Release -o /app/build

# Publicar la aplicación
FROM build AS publish
RUN dotnet publish "MicroservicioSolicitudSAC/MicroservicioSolicitudSAC.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicioSolicitudSAC.dll"]
