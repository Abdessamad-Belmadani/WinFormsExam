using System;


namespace WinFormsApp1
{
public class QuestionOuverte : Question
{


        
        private Db db = new Db();

        public QuestionOuverte(int id, int IdExamen, string EnnonceQuestion)
        {

            this.id = id;
            this.IdExamen = IdExamen;
            this.EnnonceQuestion = EnnonceQuestion;            
            db.AddOpenQuestion(id, EnnonceQuestion, IdExamen);            
               
                        
         }
}
}
