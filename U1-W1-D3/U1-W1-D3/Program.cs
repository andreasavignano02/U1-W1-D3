using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente persona = new ContoCorrente();
            persona.metodo();

          
        }
        public class ContoCorrente
        {
            private double _saldo;
            public double Saldo
            {
                get { return _saldo; }
                set { _saldo = value; }
            }
            private string _CognomeUtente;
            public string cognomeUtente
            {
                get { return _CognomeUtente; }
                set { _CognomeUtente = value; }
            }
            private string _NomeUtente;
            public string nomeUtente
            {
                get { return _NomeUtente; }
                set { _NomeUtente = value; }
            }
            private bool _ContoEsistente;
            public bool contoEsistente 
            { 
                get{ return _ContoEsistente; }
                set { _ContoEsistente = value; } 
            }
            public ContoCorrente() 
            { 
            
            }
            public void metodo()
            {
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
                   apriConto();
                    metodo();
                }
                else if (scelta == 2)
                {
                    EffettuaVersamento();
                    metodo();
                }
                else if (scelta == 3)
                {
                    EffettuaPrelevamento();
                    metodo();
                }
                else
                {
                    Console.WriteLine("inserisci un numero");
                }
                Console.ReadLine();
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
                _saldo = 0;
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

                    if (importoPrelevato > _saldo)
                    {
                        Console.WriteLine("Prelevamento non consentito!!!");
                    }
                    else
                    {
                        Console.WriteLine("Prelevamento effettuato");
                        _saldo -= importoPrelevato;
                        Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
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
                    _saldo += importoVersato;
                    Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
                }
                
            }

        }
    }
}
