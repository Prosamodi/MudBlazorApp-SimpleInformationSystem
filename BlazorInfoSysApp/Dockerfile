FROM mcr.microsoft.com/dotnet/aspnet:7.0

COPY /bin/Release/net7.0/publish/ BlazorInfoSysApp/

ENV ASPNETCORE_ENVIRONMENT Production
ENV Logging__Console__FormatterName=Simple

EXPOSE 5000
WORKDIR /BlazorInfoSysApp
ENTRYPOINT ["dotnet", "BlazorInfoSysApp.dll", "--urls=http://0.0.0.0:5000"]