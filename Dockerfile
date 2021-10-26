FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /src

COPY WebApp/*.csproj WebApp/
RUN dotnet restore WebApp

COPY . .
RUN dotnet publish -c Release -o /app WebApp

FROM alpine:3.14.2 as base

RUN apk update && \
    apk upgrade && \
    apk add lighttpd

ENV BLAZOR_ENVIRONMENT=Production

COPY --from=build /app/wwwroot /var/www/localhost/htdocs/

ENTRYPOINT [ "lighttpd", "-D", "-f", "/etc/lighttpd/lighttpd.conf" ]

