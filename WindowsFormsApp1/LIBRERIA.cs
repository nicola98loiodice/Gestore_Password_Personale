using System;
using System.Collections.Generic;
using System.IO; // Fondamentale per i file
using System.Linq;

namespace WindowsFormsApp1
{
    public class LIBRERIA
    {
        private List<Utente> listaUtenti = new List<Utente>();
        private readonly string percorsoFile = "utenti.txt";

        public LIBRERIA()
        {
            CaricaDaFile();
        }

        public void AggiungiUtente(string nome, string password)
        {
            // Aggiungiamo alla lista in memoria
            listaUtenti.Add(new Utente(nome, password));

            // Salviamo subito su file (append)
            SalvaSuFile(nome, password);
        }

        public bool Autentica(string nomeInserito, string passInserita)
        {
            return listaUtenti.Any(u => u.Username == nomeInserito && u.Password == passInserita);
        }

        // --- LOGICA DI SALVATAGGIO ---

        private void SalvaSuFile(string nome, string pass)
        {
            // Scrive una nuova riga nel file: "Nome:Password"
            string riga = $"{nome}:{pass}";
            File.AppendAllLines(percorsoFile, new[] { riga });
        }

        private void CaricaDaFile()
        {
            if (File.Exists(percorsoFile))
            {
                // Leggiamo tutte le righe del file
                string[] righe = File.ReadAllLines(percorsoFile);

                foreach (string riga in righe)
                {
                    // Dividiamo la riga dove c'è il carattere ':'
                    string[] parti = riga.Split(':');
                    if (parti.Length == 2)
                    {
                        listaUtenti.Add(new Utente(parti[0], parti[1]));
                    }
                }
            }
            else
            {
                // Se il file non esiste, creiamo un utente base e il file
                AggiungiUtente("Admin", "root");
            }
        }
    }
}