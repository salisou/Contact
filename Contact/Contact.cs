using Contact.Data;
using Contact.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class EContact : Form
    {
        Contatti contatti = new Contatti();
        ContactViewModel vm = new ContactViewModel();
        static string myConnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public EContact()
        {
            InitializeComponent();
        }

        private void LoadDataGrid()
        {
            DataTable dt = vm.Select();
            dataGridContatti.DataSource = dt;
        }

        
        private void EContact_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            contatti.Nome = txtNome.Text.Trim();
            contatti.Cognome = txtCognome.Text.Trim();
            contatti.Indirizzo = txtIndirizzo.Text.Trim().ToString();
            contatti.Contatto = txtContatto.Text.Trim().ToString();
            contatti.Genere = cmbGenere.Text.Trim();

            bool sucess = vm.Insert(contatti);

            if (sucess == true)
            {
                MessageBox.Show("L'inserimento del contatto è andata a buon fine!");
                LoadDataGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Attenzione! L'inserimento non è andata a buon fine. \nRiprova");
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            contatti.ContactID = int.Parse(txtContactID.Text);
            contatti.Nome      = txtNome.Text;
            contatti.Cognome   = txtCognome.Text; 
            contatti.Contatto  = txtContatto.Text;
            contatti.Indirizzo = txtIndirizzo.Text;
            contatti.Genere    = cmbGenere.Text; 

            bool sucsess = vm.Uptade(contatti);
            if (sucsess == true)
            {
                MessageBox.Show("L'aggiornamento è andata a buon fine!");
                LoadDataGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Attenzione! L'aggiornamento non è andata a buon fine. \nRiprova");
            }

        }

        private void btnCanella_Click(object sender, EventArgs e)
        {
            contatti.ContactID = int.Parse(txtContactID.Text);
            bool sucess = vm.Delete(contatti);

            if (sucess == true)
            {
                MessageBox.Show("La riga è stat cancellata con successo!");
                LoadDataGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Errore durante la cancellazione della riga!");
            }
        }

        private void btnEliminaTutto_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtContactID.Text = "" ;
            txtNome.Text = "";
            txtCognome.Text = "";
            txtContatto.Text = "";
            txtIndirizzo.Text = "";
            cmbGenere.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void dataGridContatti_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data grid view and load it to hte textbox respectively
            int rowIndex = e.RowIndex;

            txtContactID.Text = dataGridContatti.Rows[rowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridContatti.Rows[rowIndex].Cells[1].Value.ToString();
            txtCognome.Text = dataGridContatti.Rows[rowIndex].Cells[2].Value.ToString();
            txtContatto.Text = dataGridContatti.Rows[rowIndex].Cells[3].Value.ToString();
            txtIndirizzo.Text = dataGridContatti.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGenere.Text = dataGridContatti.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void txtCerca_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCerca.Text;
            SqlConnection conn = new SqlConnection(myConnection);
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tbl_Contatti Where Nome LIKE '%"+keyword+"%' OR Cognome LIKE '%"+keyword+ "%' OR Indirizzo LIKE '%" + keyword+"%' ", conn);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridContatti.DataSource = dt;
        }
    }
}
