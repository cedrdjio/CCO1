using CCO1.BO;
using CCO1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCO1.WinForms
{
    public partial class Frmetudiant : Form
    {
        private Action callback;
        private Etudiant oldEtudiant;
        private EtudiantBLO etudiantBLO;
       



        public Frmetudiant()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

        }
        private void loadData()
        {
            string value = txtSearch.Text;
            var etudiant = etudiantBLO.GetBy(
                x =>
                x.Nom.ToLower().Contains(value) ||
                x.Prenom.ToLower().Contains(value) ||
                x.DateNaissance.ToLower().Contains(value)
                ).OrderBy(x => x.Nom).ToArray();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiant;
            dataGridView1.ClearSelection();
        }
        public Frmetudiant(Action callback) : this()
        {
            this.callback = callback;
        }
        public Frmetudiant(Etudiant etudiant, Action callback) : this(callback)
        {
            this.oldEtudiant = etudiant;
            txtNom.Text = etudiant.Nom;
            txtPrenom.Text = etudiant.Prenom;
            dtpNaissance.Text = etudiant.DateNaissance.ToString();
            dtpAdmission.Text = etudiant.DateAdmission;
            txtTel.Text = etudiant.Telephone.ToString();
            txtEmail.Text = etudiant.Emails;
            txtEtablissement.Text = etudiant.Etablissement;
            txtDepartement.Text = etudiant.Departement;
            lbMatricule.Image = etudiant.Matricule != null ? Image.FromStream(new MemoryStream(etudiant.Photo)) : null;
            imgPhoto.Image = etudiant.Photo != null ? Image.FromStream(new MemoryStream(etudiant.Photo)) : null;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Picture";
            ofd.Filter = "Image files|*.jpg; *.jpeg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                imgPhoto.ImageLocation = ofd.FileName;

        }

       

        private void picRemover_Click(object sender, EventArgs e)
        {
            imgPhoto.ImageLocation = null;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click_1(sender, e);
        }
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click_1(sender, e);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Etudiant newEtudiant = new Etudiant(
                txtNom.Text,
                txtPrenom.Text,
                dtpNaissance.Text,
                dtpAdmission.Text,
                !string.IsNullOrEmpty(imgMatricule.ImageLocation) ? File.ReadAllBytes(imgMatricule.ImageLocation) : this.oldEtudiant?.Matricule,
                 int.Parse(txtTel.Text),
                txtEmail.Text,
                 txtEtablissement.Text,
                txtDepartement.Text,
                !string.IsNullOrEmpty(imgPhoto.ImageLocation) ? File.ReadAllBytes(imgPhoto.ImageLocation) : this.oldEtudiant?.Photo,
                txtSex.Text
                );
                dataGridView1.DataSource = newEtudiant;

                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtudiant == null)
                    etudiantBLO.CreateEtudiant(newEtudiant);
                else
                    etudiantBLO.EditEtudiant(oldEtudiant, newEtudiant);


                MessageBox.Show(
                    "Save Done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                loadData();

                if (callback != null)
                    callback();

                if (oldEtudiant != null)
                    Close();

                txtNom.Clear();
                txtPrenom.Clear();
                dtpNaissance.Value = DateTime.Now;
                dtpAdmission.Value = DateTime.Now;
                txtTel.Clear();
                txtEmail.Clear();
                txtEtablissement.Clear();
                txtDepartement.Clear();
                imgMatricule.ImageLocation = null;
                imgPhoto.ImageLocation = null;
                txtTel.Clear();
                txtEmail.Clear();
                txtNom.Focus();

            }
            catch (TypingException ex)
            {
                MessageBox.Show(
                ex.Message,
                "Typing error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show(
                ex.Message,
                "Duplicate error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(
                ex.Message,
                "key not found error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show(
                "An error occured please try again",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

            }
        
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this students(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    }
                    loadData();
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new Frmetudiant
                        (
                            dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                            loadData
                        );
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }
            }
            }
    } 
}

