using System;

namespace MCPForUnity.Editor.Windows.Components.Branding
{
    /// <summary>
    /// Legacy type alias retained for source/binary compatibility with integrations that referenced
    /// the pre-Shiryu brand-mark class. New code should use <see cref="ShiryuBrandMark"/>.
    /// </summary>
    [Obsolete("Use ShiryuBrandMark instead.")]
    public sealed class OceanMark : ShiryuBrandMark
    {
    }
}
