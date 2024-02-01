using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioUtenteBED4
{
    public static class Utente
    {
        public static bool freeze = true;
        public static List<string> logins = new List<string>();
        public static string Username = "";
        public static string Date = "";
        public static string Time = "";
        public static bool User = false;
        public static void Login()
        {
            Console.WriteLine("===========Procedura login============");
            Console.WriteLine("\n Inserisci il nome utente: ");
            Username = Console.ReadLine();
            User = true;
            Console.WriteLine("Inserisci la password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            if (User && password == confermaPassword)
            {
                Console.WriteLine("Autenticazione effettuata.");
                Date = DateTime.Now.ToString("dd MMMM yyyy");
                Time = DateTime.Now.ToString("hh:mm t");
                logins.Add($"{Username} il {Date} alle {Time}");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            } 
            else
            {
                Console.WriteLine("Utente o password non validi.");
                User = false;
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            }
        }
        public static void Logout()
        {
            if (User)
            {
                Console.WriteLine("===========Procedura logout============");
                Console.WriteLine("\n Logout effettuato.");
                User = false;
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            }
            else
            {
                Console.WriteLine("\n Impossibile effettuare il logout senza aver prima effettuato il login.");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            }
        }

        public static void DateTimeControl()
        {
                Console.WriteLine("===========Controllo data e ora accesso============");

            if (User)
            {
                Console.WriteLine($"\n L'utente {Username} ha effettuato il login il {Date} alle {Time}");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            } else
            {
                Console.WriteLine("\n Non è stato ancora effettuato un login in questa sessione.");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                MenuPrincipale.Continue = true;
            }
        }
            public static string[] loginsList = logins.ToArray();
        public static void LoginList()
        {

            while (freeze)
            {
                Console.Clear();
                Console.WriteLine("===========Storico login============");

                for (int i = 0; i < loginsList.Length; i++)
                {
                    Console.WriteLine($"{loginsList[i]}");
                }
                Console.WriteLine("1) Esci");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                    default: freeze = false;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
