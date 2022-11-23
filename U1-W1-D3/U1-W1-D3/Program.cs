using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente persona = new ContoCorrente();
            persona._ContoEsistente = false;



            int scelta = 0;
            do
            {
                Console.WriteLine("Cosa vuoi fare ?");
                Console.WriteLine("1. Aprire un conto");
                Console.WriteLine("2. Fare un versamento");
                Console.WriteLine("3. Fare un prelievo");
                scelta = int.Parse(Console.ReadLine());
            } while (scelta > 4);

            if (scelta == 1)
            {
                persona.apriConto();
            }
            else if (scelta == 2)
            {
                persona.EffettuaVersamento();
            }
            else if (scelta == 3)
            {
                persona.EffettuaPrelevamento();
            }
            else 
            {
                Console.WriteLine("inserisci un numero");
            }
            Console.ReadLine();
            

           
        }
        public class ContoCorrente
        {
            public double _Saldo
            {
                get { return _Saldo; }
                set { _Saldo = value; }
            }
            public string _CognomeUtente
            {
                get { return _CognomeUtente; }
                set { _CognomeUtente = value; }
            }
            public string _NomeUtente
            {
                get { return _NomeUtente; }
                set { _NomeUtente = value; }
            }
            public bool _ContoEsistente 
            { 
                get{ return _ContoEsistente; }
                set { _ContoEsistente = value; } 
            }
            public ContoCorrente() 
            { 
            
            }

            public void apriConto()
            {
                Console.WriteLine("Cognome Utente: ");
                string Cognome = Console.ReadLine();

                Console.WriteLine("Nome Utente:");
                string Nome = Console.ReadLine();

                ContoCorrente conto = new ContoCorrente();
                _CognomeUtente = Cognome;
                _NomeUtente = Nome;
                _Saldo = 0;
                _ContoEsistente = true;
                Console.WriteLine($"Il conto corrente è stato creato a nome : {_CognomeUtente} {_NomeUtente}");
            }
            public void EffettuaPrelevamento()
            {
                if (_ContoEsistente == false)
                {
                    Console.WriteLine("E' necessario aprire un conto prima di effettuare un prelevamento");
                }
                else
                {
                    Console.WriteLine("Inserisci l'importo del prelevamento da effettuare: ");
                    double importoPrelevato = double.Parse(Console.ReadLine());

                    if (importoPrelevato > _Saldo)
                    {
                        Console.WriteLine("Prelevamento non consentito!!!");
                    }
                    else
                    {
                        Console.WriteLine("Prelevamento effettuato");
                        _Saldo -= importoPrelevato;
                        Console.WriteLine($"Nuovo saldo del CC odierno: {_Saldo.ToString("N")}");
                    }
                }
                
            }
            public void EffettuaVersamento()
            {
                if (_ContoEsistente == false)
                {
                    Console.WriteLine("E' necessario aprire un conto prima di effettuare un versamento");
                }
                else
                {
                    Console.WriteLine("Inserisci l'importo del versamento da effettuare: ");
                    double importoVersato = double.Parse(Console.ReadLine());

                    Console.WriteLine("Versamento effettuato");
                    _Saldo += importoVersato;
                    Console.WriteLine($"Nuovo saldo del CC odierno: {_Saldo.ToString("N")}");
                }
                
            }

        }
    }
}
