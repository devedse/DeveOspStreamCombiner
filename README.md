# DeveOspStreamCombiner
This is a Frontend application to allow for viewing multiple streams at once on OpenStreamingPlatform

## Docker-Compose.yml

```
version: '3'

services:
  deveospstreamcombiner:
    image: devedse/deveospstreamcombiner:latest
    restart: unless-stopped
    environment:
      - OspUrl=https://osp.devedse.duckdns.org/
    ports:
      - '5006:80'
```

## Build status

| GitHubActions Builds |
|:--------------------:|
| [![GitHubActions Builds](https://github.com/devedse/DeveOspStreamCombiner/workflows/GitHubActionsBuilds/badge.svg)](https://github.com/devedse/DeveOspStreamCombiner/actions/workflows/githubactionsbuilds.yml) |

## DockerHub

| Docker Hub |
|:----------:|
| [![Docker pulls](https://img.shields.io/docker/v/devedse/deveospstreamcombiner)](https://hub.docker.com/r/devedse/deveospstreamcombiner/) |

## Code Coverage Status

| CodeCov |
|:-------:|
| [![codecov](https://codecov.io/gh/devedse/DeveOspStreamCombiner/branch/master/graph/badge.svg)](https://codecov.io/gh/devedse/DeveOspStreamCombiner) |

## Code Quality Status

| SonarQube |
|:---------:|
| [![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=DeveOspStreamCombiner&metric=alert_status)](https://sonarcloud.io/dashboard?id=DeveOspStreamCombiner) |
