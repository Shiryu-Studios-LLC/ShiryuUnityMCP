# Shiryu.UnityMCP

**Shiryu.UnityMCP** is the Shiryu Studios LLC Unity bridge for the Model Context Protocol (MCP). It lets supported AI clients connect to and automate the Unity Editor for scene work, assets, scripts, testing, builds, and other editor workflows.

> Published by **Shiryu Studios LLC** and distributed through the Shiryu VPM repository.

## Install with VCC / ALCOM

Add the Shiryu Studios package repository:

`https://packages.shiryu.org/official?download`

Then install **Shiryu.UnityMCP** from the package list.

The VPM package ID is:

`org.shiryu.unitymcp`

## Open the Unity window

Use:

`Window > Shiryu Studios > ShiryuUnityMCP`

Keyboard shortcut:

- macOS: `Cmd + Shift + M`
- Windows / Linux: `Ctrl + Shift + M`

## Quick start

1. Open **Window > Shiryu Studios > ShiryuUnityMCP**.
2. Run the local setup flow if prompted.
3. Install Python 3.10+ and `uv` / `uvx` if they are missing.
4. Pick a supported MCP client and configure it from the Client Configuration section.
5. Start the bridge if it is not already running.
6. Connect from your MCP client and begin using the Unity tools.

## Supported workflow areas

Shiryu.UnityMCP includes tooling for:

- Unity editor and scene automation
- GameObject and component management
- Asset and material operations
- Script creation and validation
- Build and test automation
- Screenshots and editor-state inspection
- MCP client configuration
- HTTP and stdio transport modes
- Optional asset-generation integrations

## Compatibility

- Unity 2021.3 or newer
- Windows, Linux, and macOS
- VCC / VPM and ALCOM package installation
- MCP clients supported by the included client configurators

The public VPM package name is **Shiryu.UnityMCP**. The bundled Unity bridge keeps its compatible Python MCP server version separately so the package can follow its own release numbering without breaking server compatibility.

## Package migration

The VPM manifest declares the previous `com.coplaydev.unity-mcp` package as a legacy package and also recognizes the legacy `Assets/ShiryuUnityMCP` folder. This avoids duplicate assemblies when moving an existing project to the Shiryu VPM package.

## Branding and internal compatibility

The public package name is **Shiryu.UnityMCP** and the publisher is **Shiryu Studios LLC**.

Some internal C# namespaces, assembly names, folders, and Unity menu paths still use `MCPForUnity` or `ShiryuUnityMCP`. They are intentionally preserved for compatibility with serialized references, assembly references, client configuration, and existing integrations.

## Publishing the VPM package

For each Shiryu.UnityMCP release:

1. Update the package `version` and matching release `url` in `package.json`.
2. Create a ZIP whose root contains `package.json`, `Editor`, `Runtime`, `LICENSE`, `README.md`, `CHANGELOG.md`, and `THIRD_PARTY_NOTICES.md`.
3. Publish the ZIP as `org.shiryu.unitymcp-<version>.zip` on the matching GitHub release tag.
4. Keep `Shiryu-Studios-LLC/ShiryuUnityMCP` in the `githubRepos` list in the ShiryuVPM listing repository.
5. Let the VPM listing builder generate the final repository entry, download URL, and ZIP SHA-256.

Published package versions should not be deleted once projects may depend on them.

## License and upstream attribution

Shiryu.UnityMCP is based on the open-source **MCP for Unity** project originally published by CoplayDev under the MIT License. The original copyright and MIT permission notice are preserved in `LICENSE`.

See `THIRD_PARTY_NOTICES.md` for upstream attribution and compatibility notes.

## Links

- Shiryu package repository: https://packages.shiryu.org
- Shiryu Studios: https://shiryustudios.com
- Source repository: https://github.com/Shiryu-Studios-LLC/ShiryuUnityMCP
