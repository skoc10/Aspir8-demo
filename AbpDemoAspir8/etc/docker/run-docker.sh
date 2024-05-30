#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 1c385e51-0060-4d9c-b90f-5914ebb2078b -t
    fi
    cd ../
fi

docker-compose up -d
