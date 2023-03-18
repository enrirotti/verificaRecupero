using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scuolaRecupero
{
    internal class Scuola
    {
        private string nome;
        private DateTime apertura;
        private DateTime chiusura;
        private string indirizzo;
        private List<string> elenco;

        public Scuola(string nome, DateTime apertura, DateTime chiusura, string indirizzo, List<string> elenco) { 
            this.nome = nome;
            this.apertura = apertura;
            this.chiusura = chiusura;
            this.indirizzo= indirizzo;
            this.elenco = elenco;
        }

        public void addAlunno(string nomeAl,string cognome, int eta,string classe)
        {
            string alunno = nomeAl + cognome + eta.ToString() + classe;
            elenco.Add(alunno);

        }

        public string searchCognome(string cognome)
        {
            
        }
    }
}
