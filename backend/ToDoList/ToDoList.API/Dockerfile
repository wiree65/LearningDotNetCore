﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ToDoList.API/ToDoList.API.csproj", "ToDoList.API/"]
RUN dotnet restore "ToDoList.API/ToDoList.API.csproj"
COPY . .
WORKDIR "/src/ToDoList.API"
RUN dotnet build "ToDoList.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToDoList.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToDoList.API.dll"]
