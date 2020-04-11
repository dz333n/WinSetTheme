using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetThemeLib
{
    public class ThemesRepository
    {
        public static Theme[] Themes = {
            new Theme(null, "Supposed to be a default theming"),
            new Theme(" ", "Classic theming"),
            new Theme("Explorer", "Gives list-view control the appearance of a Windows Explorer list"),
            new Theme("DarkMode_Explorer", "Seems to be dark variation of Explorer theme"),
            new Theme("Explorer", "Explorer + apply Win32 dark theme", WindowTheming.AllowDarkMode),
            new Theme("DarkMode_Explorer", "DarkMode_Explorer + apply Win32 dark theme", WindowTheming.AllowDarkMode),
        };
    }
}
