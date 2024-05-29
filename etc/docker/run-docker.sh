#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p ccd7786f-3c5e-44ca-9350-215afd4b2667 -t
    fi
    cd ../
fi

docker-compose up -d
