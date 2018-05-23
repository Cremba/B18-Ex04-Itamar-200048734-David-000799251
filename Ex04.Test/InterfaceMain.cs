using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    internal class InterfaceMain
    {
        internal static void build()
        {
            MainMenu firstMainMenu = new MainMenu("Main Menu", 0, null);
            MainMenu dateAndTimeMenu = firstMainMenu.addNewMenu("Show Data/Time", 1, firstMainMenu);
            dateAndTimeMenu.addNewItemToMenu("Show Time", firstMainMenu, new Time());
            dateAndTimeMenu.addNewItemToMenu("Show Date", firstMainMenu, new Date());
            MainMenu versionAndCapitalMenu = firstMainMenu.addNewMenu("Version and Capitals", 1, firstMainMenu);
            versionAndCapitalMenu.addNewItemToMenu("Count Capitals", versionAndCapitalMenu, new CountCapital());
            versionAndCapitalMenu.addNewItemToMenu("Display Version", versionAndCapitalMenu, new DisplayVersion());
            firstMainMenu.ToShow();
        }
    }
}