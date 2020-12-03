FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
FROM build AS publish
RUN dotnet publish -c Release -o /app


# build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CashLockedUpFunds.dll"]
