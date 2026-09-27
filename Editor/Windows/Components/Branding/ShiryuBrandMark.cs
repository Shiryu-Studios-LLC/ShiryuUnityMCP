using MCPForUnity.Editor.Helpers;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace MCPForUnity.Editor.Windows.Components.Branding
{
    /// <summary>
    /// Official Shiryu Studios brand mark used by the ShiryuUnityMCP editor UI.
    /// Loads package-icon.png so the editor identity always matches the published VPM package artwork.
    /// </summary>
    public class ShiryuBrandMark : VisualElement
    {
        private static readonly Color Surface = new Color32(15, 23, 42, 255);
        private static readonly Color Accent = new Color32(96, 165, 250, 255);

        public ShiryuBrandMark()
        {
            pickingMode = PickingMode.Ignore;
            tooltip = "Shiryu Studios LLC";
            style.overflow = Overflow.Hidden;
            style.borderTopLeftRadius = 6f;
            style.borderTopRightRadius = 6f;
            style.borderBottomLeftRadius = 6f;
            style.borderBottomRightRadius = 6f;

            Texture2D texture = LoadOfficialIcon();
            if (texture != null)
            {
                style.backgroundImage = new StyleBackground(texture);
                style.unityBackgroundScaleMode = ScaleMode.ScaleToFit;
                return;
            }

            style.backgroundColor = Surface;
            var glyph = new Label("S") { pickingMode = PickingMode.Ignore };
            glyph.style.flexGrow = 1f;
            glyph.style.unityTextAlign = TextAnchor.MiddleCenter;
            glyph.style.unityFontStyleAndWeight = FontStyle.Bold;
            glyph.style.fontSize = 18f;
            glyph.style.color = Accent;
            Add(glyph);
        }

        private static Texture2D LoadOfficialIcon()
        {
            string root = AssetPathUtility.GetMcpPackageRootPath();
            if (string.IsNullOrEmpty(root))
                return null;

            return AssetDatabase.LoadAssetAtPath<Texture2D>($"{root}/package-icon.png");
        }
    }
}
