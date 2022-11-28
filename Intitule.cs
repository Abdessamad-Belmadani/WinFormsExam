using System;

namespace WinFormsApp1
{
    public class Intitule
    {
        private int id;
        private string nom, prenom;
        private int idExamen;
        Db db = new Db();

        public Intitule(int id, string nom, string prenom, int idExamen)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.idExamen = idExamen;

            db.AddIntitule(id, nom, prenom, idExamen);
        }
        //getters 
        public int getId() { return this.id; }
        public int getIdExamen() { return this.idExamen; }
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }
        //setters
        public void setId(int id) { this.id = id; }
        public void setIdExamen(int idExamen) { this.idExamen = idExamen; }
        public void setNom(string nom) { this.nom = nom; }
        public void setPrenom(string prenom) { this.prenom = prenom; }

    }
}