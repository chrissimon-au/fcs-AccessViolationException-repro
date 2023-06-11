# Reproduction Steps

1. Clone and re-open in devcontainer
2. Open FSharp file from F# Solution explorer
    1. errors are found, as dependencies have not been downloaded yet
3. Restore dependencies:
    1. cd `accessviolationexception-repro/src`
    1. dotnet restore
    1. errors are still shown
4. Reload window (cmd palette: `Developer: Reload Window`)
5. Open an FSharp file from F# Solution explorer
    1. no errors or tooltips
6. Review F# Output log
    1. see `System.AccessViolationException`