using System;
namespace WinFormsApp1
{
    public abstract class Question
    {

        private int id;
        private int IdExamen;
        private string EnnonceQuestion;
        

        public Question(int id, int IdExamen, string EnnonceQuestion)
        {
            this.id = id;
            this.IdExamen = IdExamen;
            this.EnnonceQuestion = EnnonceQuestion;
           

        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetIdExamen()
        {
            return this.IdExamen;
        }
        public void SetIdExamen(int IdExamen)
        {
            this.IdExamen = IdExamen;
        }
        public string GetEnnonceQuestion()
        {
            return this.EnnonceQuestion;
        }
        public void SetEnnonceQuestion(string EnnonceQuestion)
        {
            this.EnnonceQuestion = EnnonceQuestion;
        }
        
       
       
    }
}

