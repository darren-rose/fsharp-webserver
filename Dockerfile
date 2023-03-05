FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c release -o ./bin/release/webserver --no-self-contained --no-restore
EXPOSE 8080
CMD ["./bin/release/webserver/fsharp-webserver"]