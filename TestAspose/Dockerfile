FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY TestAspose.csproj .

RUN dotnet restore TestAspose.csproj

COPY . .
RUN dotnet publish TestAspose.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS run

# Install fonts
# SOLUTION 1
#WORKDIR /fonts
#COPY Fonts .

# SOLUTION 2
#RUN echo "deb http://us-west-2.ec2.archive.ubuntu.com/ubuntu/ trusty multiverse\ndeb http://us-west-2.ec2.archive.ubuntu.com/ubuntu/ trusty-updates multiverse\ndeb http://us-west-2.ec2.archive.ubuntu.com/ubuntu/ trusty-backports main restricted universe multiverse" | tee /etc/apt/sources.list.d/multiverse.list
#RUN apt-get update && apt-get install ttf-mscorefonts-installer

# SOLUTION 3
#RUN apt-get update && apt-get install -y apt-utils
#RUN apt-get install -y fonts-liberation

# SOLUTION 4
#RUN apt-get update && apt-get install -y apt-utils
#RUN apt-get install -y ttf-liberation

# SOLUTION 5
#RUN apt-get update && apt-get install -y libfontconfig1


WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "TestAspose.dll"]