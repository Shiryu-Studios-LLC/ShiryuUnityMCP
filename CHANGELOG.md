# Changelog

All notable ShiryuUnityMCP changes will be documented here.

## 1.0.0 - 2026-09-27

### Added

- Initial Shiryu Studios LLC release as `org.shiryu.unitymcp`.
- VPM metadata for installation through VCC and ALCOM.
- Migration metadata for the previous `com.coplaydev.unity-mcp` package and legacy `Assets/ShiryuUnityMCP` folder.
- Shiryu Studios product identity and package documentation.
- Official ShiryuUnityMCP package icon used by the in-editor header and setup UI.
- GitHub validation and immutable VPM release workflows for the official package repository.
- Separate Python MCP server compatibility version so ShiryuUnityMCP can use independent semantic versioning.
- Upstream MIT attribution and third-party notices.

### Changed

- Public product name changed to **ShiryuUnityMCP**.
- Publisher metadata changed to **Shiryu Studios LLC**.
- Unity menu moved under `Window > Shiryu Studios > ShiryuUnityMCP`.
- Client setup/help copy now consistently identifies the product as ShiryuUnityMCP.
- Telemetry defaults to disabled for the Shiryu distribution unless explicitly enabled.

### Compatibility

- Internal `MCPForUnity` namespaces, assembly names, preference keys, and protocol identifiers remain unchanged in 1.0.0 to avoid breaking existing Unity references and integrations.
