using System;
using System.Collections.Generic;
using System.Text;

namespace Bücherladen
{
    public class Menu
    {
        public static int MainMenuSelection()
        {
            bool fehler;
            var mainMenuSelection = 0;

            Console.WriteLine("--- Buchverwaltung ---\n");
            Console.WriteLine("Was möchten Sie verwalten?");
            Console.WriteLine("Produkte(1), Exemplare(2), Leihvorgänge(3)");

            do
            {
                try
                {
                    mainMenuSelection = Convert.ToInt32(Console.ReadLine());
                    fehler = false;
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl von 1 bis 3 ein.");
                    fehler = true;
                }
            }
            while (fehler);

            return mainMenuSelection;
        }

        public static void SubMenu1(int mainMenuSelection)
        {
            switch (mainMenuSelection)
            {
                case 1:
                    Console.WriteLine("Welche lesbaren Erzeugnisse wollen Sie sich anschauen?\n");
                    Console.WriteLine("Magazine(1), Bücher(2)");
                    mainMenuSelection = Convert.ToInt32(Console.ReadLine());

                    switch (mainMenuSelection)
                    {
                        case 1:
                            Console.WriteLine("Was möchten Sie unter \"Magazine\" tun?\n");
                            Console.WriteLine("Magazine ansehen(1), Magazin hinzufügen(2), Magazin bearbeiten(3)\n");
                            SelectOption((int)ProductSelection.Magazine);
                            break;
                        case 2:
                            Console.WriteLine("Was möchten Sie unter \"Bücher\" tun?\n");
                            Console.WriteLine("Bücher ansehen(1), Buch hinzufügen(2), Buch bearbeiten(3)\n");
                            SelectOption((int)ProductSelection.Bucher);
                            break;
                    }
                    break;
                    
                case 2:
                    Console.WriteLine("Was möchten Sie unter \"Exemplare\" tun?\n");
                    Console.WriteLine("Exemplare ansehen(1), Exemplar bearbeiten(2)\n");
                    SelectOption((int)ProductSelection.Exemplare);
                    break;
                case 3:
                    Console.WriteLine("Was möchten Sie unter \"Leihvorgänge\" tun?\n");
                    Console.WriteLine("Leihvorgänge ansehen(1), Leihvorgang hinzufügen(2), Leihvorgang löschen(3), Leihvorgang bearbeiten(4)\n");
                    SelectOption((int)ProductSelection.Leihvorgange);
                    break;
            }
        }

        public static void SelectOption(int auswahl)
        {
            var selectOptionAuswahl = 0;
            bool fehler;

            do
            {
                try
                {
                    selectOptionAuswahl = Convert.ToInt32(Console.ReadLine());
                    fehler = false;
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl von 1 bis 4 ein.\n");
                    fehler = true;
                }
            }
            while (fehler);

            switch (selectOptionAuswahl)
            {
                case 1: Options.List(auswahl); break;
                case 2: Options.Add(auswahl); break;
                case 3: Options.Del(auswahl); break;
                case 4: Options.Edit(auswahl); break;
            }
        }

        public static bool EndProgramMenu()
        {
            var stopProgram = false;
            Console.WriteLine("Programm beenden? (j/n)");
            var x = Console.ReadLine();
            if (x == "j")
            {
                stopProgram = true;
            }
            Console.Clear();

            return stopProgram;
        }
    }
}
