# This is non optimized image

FROM microsoft/dotnet:1.1-sdk

COPY BasicApp /app

WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Development"
EXPOSE 5000/tcp
ENTRYPOINT ["/usr/bin/dotnet"]
CMD ["run"]
