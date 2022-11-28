using System;


namespace WinFormsApp1
{
public class QuestionOuverte : Question
{

        Db db = new Db();

    public QuestionOuverte(int id, int IdExamen, string EnnonceQuestion)
    {
        base.Question(id, IdExamen, EnnonceQuestion);
        db.AddOpenQuestion(id, EnnonceQuestion, IdExamen);

    }
}
}
