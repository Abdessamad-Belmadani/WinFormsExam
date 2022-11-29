using System;
namespace WinFormsApp1
{
    public abstract class Question
    {

        protected int id;
        protected int IdExamen;
        protected string EnnonceQuestion="";
        

       
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

