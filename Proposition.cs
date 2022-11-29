using System;

namespace WinFormsApp1
{
public class Proposition
{
	int id,idQuestion;
	string proposition;
	Db db = new Db();
	public Proposition(int id,int idQuestion,string proposition)
	{
		this.id = id;
		this.idQuestion = idQuestion;
		this.proposition = proposition;

		db.AddProposition(id,proposition,idQuestion);
	}
}
}

