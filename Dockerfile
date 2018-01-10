FROM microsoft/dotnet:1.0-sdk-projectjson

ADD ./ /usr/local/src
WORKDIR /usr/local/src/Sino.GrpcService.Host/

RUN cd /usr/local/src/
RUN dotnet restore -v https://nuget.cnblogs.com/v3/index.json
RUN dotnet build

EXPOSE 9007

CMD ["dotnet","run"]
