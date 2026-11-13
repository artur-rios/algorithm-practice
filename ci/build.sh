#!/bin/sh
# The `build` check: restore, build the solution in Release and run its xunit tests
# (ArturRios.AlgorithmPractice.Tests). Every project targets net10.0, which the pinned .NET 10 SDK image builds
# and runs.
#
# yggdrasil.yml runs it in that image from the repository's root; by hand, from that root:
#   docker run --rm -v "$PWD:/src" -w /src <image> sh ci/build.sh
# or, with the .NET 10 SDK installed, just `sh ci/build.sh`.
set -eu

# The repository's root, wherever this is run from.
cd "$(dirname "$0")/.."

export DOTNET_CLI_TELEMETRY_OPTOUT=1 DOTNET_NOLOGO=1

solution=ArturRios.AlgorithmPractice.sln
dotnet restore "$solution"
dotnet build "$solution" --no-restore --configuration Release
dotnet test "$solution" --no-build --configuration Release
