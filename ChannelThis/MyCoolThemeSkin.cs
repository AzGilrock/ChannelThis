using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace System.Windows.Forms
{
    public class MyCoolThemeSkin
        : RibbonProfesionalRendererColorTable
    {
        public MyCoolThemeSkin()
        {
            #region Fields

            OrbDropDownDarkBorder = Color.Yellow;
            OrbDropDownLightBorder = Color.FromKnownColor(KnownColor.WindowFrame);
            OrbDropDownBack = Color.FromName("Red");
            OrbDropDownNorthA = FromHex("#C2FF3D");
            OrbDropDownNorthB = Color.FromArgb(201, 100, 150);
        /*    OrbDropDownNorthC = 
            OrbDropDownNorthD = 
            OrbDropDownSouthC = 
            OrbDropDownSouthD = 
            OrbDropDownContentbg = 
            OrbDropDownContentbglight = 
            OrbDropDownSeparatorlight = 
            OrbDropDownSeparatordark = 

            Caption1 = 
            Caption2 = 
            Caption3 = 
            Caption4 = 
            Caption5 = 
            Caption6 = 
            Caption7 = 

            QuickAccessBorderDark = 
            QuickAccessBorderLight = 
            QuickAccessUpper = 
            QuickAccessLower = 

            OrbOptionBorder = 
            OrbOptionBackground = 
            OrbOptionShine = 

            Arrow = 
            ArrowLight = 
            ArrowDisabled = 
            Text = 

            RibbonBackground = 
            TabBorder = 
            TabNorth = 
            TabSouth = 
            TabGlow = 
            TabText = 
            TabActiveText = 
            TabContentNorth = 
            TabContentSouth = 
            TabSelectedGlow = 
            PanelDarkBorder = 
            PanelLightBorder = 
            PanelTextBackground = 
            PanelTextBackgroundSelected = 
            PanelText = 
            PanelBackgroundSelected = 
            PanelOverflowBackground = 
            PanelOverflowBackgroundPressed = 
            PanelOverflowBackgroundSelectedNorth = 
            PanelOverflowBackgroundSelectedSouth = 

            ButtonBgOut = 
            ButtonBgCenter = 
            ButtonBorderOut = 
            ButtonBorderIn = 
            ButtonGlossyNorth = 
            ButtonGlossySouth = 

            ButtonDisabledBgOut = 
            ButtonDisabledBgCenter = 
            ButtonDisabledBorderOut = 
            ButtonDisabledBorderIn = 
            ButtonDisabledGlossyNorth = 
            ButtonDisabledGlossySouth = 

            ButtonSelectedBgOut = 
            ButtonSelectedBgCenter = 
            ButtonSelectedBorderOut = 
            ButtonSelectedBorderIn = 
            ButtonSelectedGlossyNorth = 
            ButtonSelectedGlossySouth = 

            ButtonPressedBgOut = 
            ButtonPressedBgCenter = 
            ButtonPressedBorderOut = 
            ButtonPressedBorderIn = 
            ButtonPressedGlossyNorth = 
            ButtonPressedGlossySouth = 

            ButtonCheckedBgOut = 
            ButtonCheckedBgCenter = 
            ButtonCheckedBorderOut = 
            ButtonCheckedBorderIn = 
            ButtonCheckedGlossyNorth = 
            ButtonCheckedGlossySouth = 

            ItemGroupOuterBorder = 
            ItemGroupInnerBorder = 
            ItemGroupSeparatorLight = 
            ItemGroupSeparatorDark = 
            ItemGroupBgNorth = 
            ItemGroupBgSouth = 
            ItemGroupBgGlossy = 

            ButtonListBorder = 
            ButtonListBg = 
            ButtonListBgSelected = 

            DropDownBg = 
            DropDownImageBg = 
            DropDownImageSeparator = 
            DropDownBorder = 
            DropDownGripNorth = 
            DropDownGripSouth = 
            DropDownGripBorder = 
            DropDownGripDark = 
            DropDownGripLight = 

            SeparatorLight = 
            SeparatorDark = 
            SeparatorBg = 
            SeparatorLine = 

            TextBoxUnselectedBg = 
            TextBoxBorder = */

            #endregion
        }     

        public Color FromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }   
    }
} 