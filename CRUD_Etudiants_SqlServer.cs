using GestionEtudiants.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEtudiants
{
    public partial class Etudiants : Form
    {
        //l'adaptateur 
        EtudiantTableAdapter adapter = new EtudiantTableAdapter();

        public Etudiants()
        {
            InitializeComponent();
        }

        //lister les données de DB sur le grd
        private void btnaffiche_Click(object sender, EventArgs e)
        {
             gnd.DataSource = adapter.GetData();    
        }

        //créer un nouveau enregistrement
        private void btnAjoutter_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Insert(int.Parse(textId.Text),textName.Text, int.Parse(textAge.Text));
                gnd.DataSource = adapter.GetData();
                textId.Text = "";
                textAge.Text = "";
                textName.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Ops ! il y a une erreur !");  
            }
        }
           
        //supprimer un etudiant
        private void btnsupp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=Etudiants;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Etudiant where Id=@Id ", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            textId.Text = "";
        }

        //modifier un etudiant
        private void btnmod_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=Etudiants;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Etudiant set Id=@Id, name=@name, age=@age where Id=@Id ", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textId.Text));
            cmd.Parameters.AddWithValue("@name",textName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textAge.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void gnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
