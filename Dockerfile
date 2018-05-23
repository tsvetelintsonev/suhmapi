FROM microsoft/aspnetcore:2.0
LABEL Name=suhmapi Version=0.0.1
ARG source=.
WORKDIR /app
EXPOSE 6000
COPY $source .
ENTRYPOINT dotnet webapi.dll
