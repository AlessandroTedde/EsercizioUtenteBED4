using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioUtenteBED4
{
    public static class MenuPrincipale
    {
        public static bool Continue = true;
        public static void SelezioneMultipla()
        {
            while (Continue)
            {
                Console.WriteLine("===========OPERAZIONI============");
                Console.WriteLine("\n Scegli l'operazione da effettuare:");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Logout");
                Console.WriteLine("3) Controllo data e ora login");
                Console.WriteLine("4) Storico login");
                Console.WriteLine("5) Esci");
                Console.WriteLine("\n");

                string menu = Console.ReadLine();
                
                switch (menu)
                {
                    case "1":
                        if (!Utente.User)
                        {
                            Console.Clear();
                            Utente.Login();
                        } 
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Risulta già un utente loggato. Effettua il logout prima di autenticarti in questa sessione.");
                            System.Threading.Thread.Sleep(5000);
                            Console.Clear();
                        }
                    break;

                    case "2":
                        Console.Clear();
                        Utente.Logout(); 
                    break;

                    case "3":
                        Console.Clear();
                        Utente.DateTimeControl();
                        break;

                        case "4":
                            Console.Clear();
                        Utente.LoginList();
                        break;

                    case "5":
                    
                    default: Continue = false;
                    break;
                }
            }
        }
    }
}
