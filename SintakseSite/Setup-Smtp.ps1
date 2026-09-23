# Run in Developer PowerShell from the folder containing SintakseSite.csproj.
$ErrorActionPreference = 'Stop'
if (-not (Test-Path './SintakseSite.csproj')) {
    throw 'Atver projekta mapi, kura atrodas SintakseSite.csproj.'
}
$contactSecret = Read-Host 'Ievadi Inbox specialo pasta programmu paroli (ievade ir paslepta)' -AsSecureString
$contactPointer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($contactSecret)
try {
    $contactPlain = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($contactPointer)
    if ([string]::IsNullOrWhiteSpace($contactPlain)) { throw 'Parole ir tuksa.' }
    # Pass JSON via standard input: no password in command arguments or shell history.
    $contactJson = @{ 'ContactMail:Password' = $contactPlain } | ConvertTo-Json -Compress
    $contactJson | dotnet user-secrets set --project ./SintakseSite.csproj
    if ($LASTEXITCODE -ne 0) { throw 'Neizdevas saglabat lokalo SMTP konfiguraciju.' }
    Write-Host 'SMTP parole saglabata lokali. Parstarte projektu Development rezima.'
}
finally {
    [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($contactPointer)
    $contactPlain = $null
    $contactJson = $null
    $contactSecret.Dispose()
}
