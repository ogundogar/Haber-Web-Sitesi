##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
#WORKDIR /src
#COPY ["SportsStore/SportsStore.csproj", "SportsStore/"]
#RUN dotnet restore "SportsStore/SportsStore.csproj"
#COPY . .
#WORKDIR "/src/SportsStore"
#RUN dotnet build "SportsStore.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "SportsStore.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "SportStore.dll"]


FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
COPY /bin/Release/netcoreapp3.1/publish .
ENTRYPOINT ["dotnet", "SportsStore.dll"]