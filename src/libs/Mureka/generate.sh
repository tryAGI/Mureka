#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Mureka \
  --clientClassName MurekaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Mureka.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Mureka.CLI \
  --sdk-project ../../libs/Mureka/Mureka.csproj \
  --targetFramework net10.0 \
  --namespace Mureka \
  --clientClassName MurekaClient \
  --package-id Mureka.CLI \
  --tool-command-name mureka \
  --user-secrets-id Mureka.CLI \
  --api-key-env-var MUREKA_API_KEY \
  --base-url-env-var MUREKA_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
