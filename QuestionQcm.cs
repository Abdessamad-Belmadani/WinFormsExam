using System;

namespace WinFormsApp1
{
    
    public class QuestionQcm : Question
    {

        private int IdReponse;
        Db db = new Db();
        public QuestionQcm(int id, int IdExamen, string EnnonceQuestion, int IdReponse)
        {
            this.id=id;
            this.IdExamen=IdExamen;
            this.EnnonceQuestion=EnnonceQuestion;
            this.IdReponse = IdReponse;
            db.AddQcmQuestion(id, EnnonceQuestion, IdExamen, IdReponse);
        }
    }

}
