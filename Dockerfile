FROM microsoft/dotnet:1.0.0-core

RUN cd /usr/local/src

RUN mkdir GrpcService

COPY * ./

WORKDIR /usr/local/src/GrpcServic/Sino.GrpcService.Host

EXPOSE 9007

CMD ["dotnet","restore"]
CMD ["dotnet","run"]