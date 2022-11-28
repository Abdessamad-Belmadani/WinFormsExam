using System;

namespace WinFormsApp1
{
public class Examen
{
       // private Question[] questions;
        private int Duree;
        private string DateDebut;
        private int IdExamen;
        Db db = new Db();

        public Examen(int IdExamen, string DateDebut, int Duree)
        {

            this.IdExamen = IdExamen;
            this.DateDebut = DateDebut;
            this.Duree = Duree;

            db.AddExam(IdExamen,Duree,DateDebut);
        }
        public int GetDuree()
        {
            return this.Duree;
        }
        public void SetDuree(int Duree)
        {
            this.Duree = Duree;
        }
        public int GetIdExamen()
        {
            return this.IdExamen;
        }
        public void SetIdExamen(int IdExamen)
        {
            this.IdExamen = IdExamen;
        }
        public string GetDateDebut()
        {
            return this.DateDebut;
        }
        public void SetDateDebut(string DateDebut)
        {
            this.DateDebut = DateDebut;
        }
    }

}
