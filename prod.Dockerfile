FROM microsoft/dotnet:1.1-runtime

COPY ["BasicApp/bin", "/app/"]
WORKDIR /app

ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Production"
EXPOSE 5000/tcp
ENTRYPOINT ["/usr/bin/dotnet"]
CMD ["BasicApp.dll"]
