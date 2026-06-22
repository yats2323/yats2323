Hardening and anti-reverse-engineering guidance for WinFormsApp1

Overview

This repository includes an optional build+publish pipeline and helpers to make reverse engineering harder. No solution makes code unrecoverable — these are defense-in-depth recommendations.

What this change adds

- Publish profile for Native AOT single-file publish (WinFormsApp1/Properties/PublishProfiles/NativeAot.pubxml)
- CSProj PostPublishProtection target that strips PDBs and can call an obfuscator CLI
- GitHub Actions workflow .github/workflows/protect-release.yml that builds, publishes, optionally obfuscates, and includes code signing placeholders
- Tools/NativeBridge/NativeBridge.cs: small managed wrapper showing how to call native DLL for sensitive logic

Recommended workflow

1. Move secrets and critical logic server-side (API) where possible. Client only holds a token.
2. Produce Release builds, publish using the NativeAot publish profile (test locally first):
   dotnet publish WinFormsApp1/WinFormsApp1.csproj -c Release -r win-x64 /p:PublishProfile=NativeAot

3. Optionally obfuscate the output with a supported obfuscator (ConfuserEx or commercial tool). Configure ObfuscatorCliPath in csproj or run manually.

4. Code sign the final artifacts using a PFX certificate. Do NOT store the PFX in the repo; configure GitHub Actions secrets (SIGNING_PFX as base64, SIGNING_PFX_PASSWORD) or use a secure signing service.

Obfuscation options

- Commercial: Dotfuscator, Eazfuscator.NET, SmartAssembly. These provide robust renaming, control flow, and string encryption.
- Open-source: ConfuserEx forks exist but may have limited .NET 10 support. Test carefully.

Code signing

- Recommended: store PFX securely and import on CI runner at build time, then call signtool.exe sign /fd SHA256 /a /f <pfx> /p <password> <file>
- GitHub Actions: upload signed artifact to release; avoid keeping PFX in plain text.

Binary restore/backups

- Backups created by the app currently store text summaries and \u003cbinary N bytes\u003e markers. If you need to restore binary registry values (SmoothMouseXCurve), extend backup format to Base64 encode binary values and decode on restore.

Testing

- Test Native AOT & trimming on a VM. Trimming can remove reflection-used types; use Runtime directives or preserve attributes if needed.
- Test obfuscated binaries in QA environment before production.

Limitations

- No method guarantees complete protection. Combine server-side, AOT, obfuscation, and signing to raise attack cost.
- Native code is harder to reverse but still analyzable with disassemblers.

Contact

If you want, I can integrate a specific obfuscator you have a license for or add a CI step to import a PFX stored in GitHub secrets and sign the executable.
