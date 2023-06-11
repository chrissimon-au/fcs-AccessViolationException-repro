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

## Workarounds

### Still not functional, but avoid access violation errors

Not really a workaround, but it does affect the behavior:

1. Remove the fsproj from the solution:
    1. `cd accessviolationexception-repro/src && dotnet sln remove AccessviolationexceptionRepro`
    2. Reload window
    3. There are still no errors, tooltip hovers or hints, but there are also no AccessViolationException logs

### Prevent errors

Not really a workaround, but this highlight that the issue is in one of the dependencies:

1. Delete the `bin` and `obj` folders in `accessviolationexception-repro/src/AccessviolationexceptionRepro`
2. Reload window
3. It reverts to the previous state - types from dependencies are marked as unknown but otherwise the F# language features are correct