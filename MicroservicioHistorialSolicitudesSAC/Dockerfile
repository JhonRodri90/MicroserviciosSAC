# Etapa base: imagen de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar los archivos de proyecto y restaurar dependencias
COPY ["MicroservicioHistorialSolicitudesSAC/MicroservicioHistorialSolicitudesSAC.csproj", "MicroservicioHistorialSolicitudesSAC/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Core/Core.csproj", "Core/"]

RUN dotnet restore "MicroservicioHistorialSolicitudesSAC/MicroservicioHistorialSolicitudesSAC.csproj"

# Copiar el resto del código
COPY . .

# Construir el proyecto principal
RUN dotnet build "MicroservicioHistorialSolicitudesSAC/MicroservicioHistorialSolicitudesSAC.csproj" -c Release -o /app/build

# Publicar la aplicación
FROM build AS publish
RUN dotnet publish "MicroservicioHistorialSolicitudesSAC/MicroservicioHistorialSolicitudesSAC.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicioHistorialSolicitudesSAC.dll"]
