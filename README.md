# Docker Printer Reproduction

### Steps:
1. Clone and open this git repo
1. Build the PrintTest-Solution as Release
1. `docker build -t test-printer .`
1. `docker run -it test-printer`
1. Then inside the container: `.\PrintTest.exe` **<-- Here it fails**
1. The Event Log `Get-WinEvent -FilterHashTable @{ LogName = "Microsoft-Windows-PrintService/Admin"; }` shows this:

```
"The print spooler failed to regenerate the printer driver information for driver Microsoft enhanced Point and Print compatibility driver for environment Windows x64. Win32 system error code
87 (0x57). This can occur after an operating system upgrade or because of data loss on the hard drive."
```

```
Installing printer driver Microsoft enhanced Point and Print compatibility driver failed, error code 0x490, HRESULT 0x80070057. See the event user data for context information.
```
