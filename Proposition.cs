using System;

namespace WinFormsApp1
{
public class Propostion
{
	int id,idQuestion;
	string propostion;
	Db db = new Db();
	public Proposition(int id,int idQuestion,string propsition)
	{
		this.id = id;
		this.idQuestion = idQuestion;
		this.propostion = propostion;

		db.AddProposition(id,propostion,idQuestion);
	}
}
}

