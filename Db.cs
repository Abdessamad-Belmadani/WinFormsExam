using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class Db
    {
        static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public Db()
        {
            string conString = "Data Source=DESKTOP-IV0DDR2;Initial Catalog=Examen;Integrated Security=True";
            con.ConnectionString = conString;
            con.Open();
            
            

        }
       

        public  DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            cmd.Connection = con;
            cmd.CommandText = sql;
            adapter.Fill(dt);
            return dt;
        }
        public  void AddExam(int id, int duree, string datedebut)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into examen values(" + id + "," + duree + ",'" + datedebut + "');";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void AddIntitule(int id,string nom,string prenom,int idExam)
        {
            cmd.Connection = con;
            cmd.CommandText="insert into intitule values("+id+",'"+nom+"','"+prenom+"',"+idExam+");";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void AddOpenQuestion(int idQ, string ennonce, int idExam)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into question_ouverte values(" + idQ + ",'" + ennonce + "'," + idExam  + ");";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void AddQcmQuestion(int idQ, string ennonce, int idExam,int idReponse)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into question_qcm values(" + idQ + ",'" + ennonce + "'," +idReponse+","+ idExam + ");";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void AddProposition(int id, string proposition, int idQuestion)
        {
            cmd.Connection = con;
            cmd.CommandText = "insert into Proposition values(" + id + ",'" + proposition + "'," + idQuestion + ");";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void UpdateExam(int id, int duree, string datedebut)
        {
            cmd.Connection = con;
            cmd.CommandText = "update examan set duree='" + duree + "',datedebut='" + datedebut + "' where id=" + id+");";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void UpdateIntitule(int id, string nom, string prenom, int idExam)
        {
            cmd.Connection = con;
            cmd.CommandText = "update intitule set nom = '" + nom + "',prenom = '" + nom + "',id_examen = " + idExam + ",where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void UpdateOpenQuestion(int idQ, string ennonce, int idExam)
        {
            cmd.Connection = con;
            cmd.CommandText = "update question_ouverte set ennonce='" + ennonce + "',idexamen='" + idExam + "where id = " + idQ + ";" ;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void UpdateQcmQuestion(int idQ, string ennonce, int idExam, int idReponse)
        {
            cmd.Connection = con;
            cmd.CommandText = "update question_ouverte set ennonce='" + ennonce + "',idexamen='" + idExam +",id_reponse ="+ idReponse +" where id = " + idQ + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void UpdateProposition(int id, string proposition, int idQuestion)
        {
            cmd.Connection = con;
            cmd.CommandText = "update proposition set id_question_qcm=" + idQuestion + ",propsition=" + proposition + " where id=" + id+";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void DeleteExam(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from examan where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void DeleteIntitule(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from intitule where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void DeleteOpenQuestion(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from question_ouverte where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void DeleteQcmQuestion(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from question_qcm where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void deleteProposition(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from proposition where id = " + id + ";";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}
