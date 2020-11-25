using System;
using CCO1.BLL;
using CCO1.BO;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCO1.Winforms
{
    public partial class frmEtblissement : Form
    {
        Etablissement oldEtablissement;
        EtablissementBLO EtablissementBLO;
        private Action callback;

        public frmEtblissement()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            EtablissementBLO = new EtablissementBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
       
        private void frmEtblissement_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public frmEtblissement(Action callback) : this()
        {
            this.callback = callback;
        }

        public frmEtblissement(Etablissement etablissement , Action callback) : this(callback)
        {
            this.oldEtablissement  = etablissement;
            txtName.Text = etablissement.NomEtablissement;
            txtTel.Text = etablissement.Telephone.ToString();
            pictureBox1.Image = etablissement.Logo != null ? Image.FromStream(new MemoryStream(etablissement.Logo)) : null;
            txtEmail.Text = etablissement.AddresMail;

        }



        private void loadData()
        {
            string value = txtSearch.Text;
           
            var universities = EtablissementBLO.GetBy(
                x =>
                x.NomEtablissement.ToLower().Contains(value) ||
                x.Telephone.ToString().Contains(value)
                ).OrderBy(x => x.NomEtablissement).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = universities;
            dataGridView1.ClearSelection();
        }


        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Etablissement newEtablissement = new Etablissement(

                txtName.Text,
                textBox1.Text,
                txtEmail.Text, 
                !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtablissement.Logo,
                int.Parse(txtTel.Text),
                textBP.Text             
                );

                EtablissementBLO universityBLO = new EtablissementBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtablissement == null)
                    universityBLO.CreateEtablissement(newEtablissement);
                else
                    universityBLO.EditEtablissement(oldEtablissement, newEtablissement);

                MessageBox.Show(
                    "Save done!",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                txtEmail.Clear();
                txtName.Clear();
                txtTel.Clear();
                pictureBox1.ImageLocation = null;
                loadData();

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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Picture";
            ofd.Filter = "Image files|*.jpg; *.jpeg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = ofd.FileName;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new frmEtblissement
                        (
                            dataGridView1.SelectedRows[i].DataBoundItem as Etablissement,
                            loadData
                        );
                    this.Close();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Confirmation ? ",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        EtablissementBLO.DeleteUniversity(dataGridView1.SelectedRows[i].DataBoundItem as Etablissement);
                    }
                    loadData();


                }

            }

        }
        private void checkForm()
        {
            string text = string.Empty;
            txtName.BackColor = Color.White;
            txtTel.BackColor = Color.White;
            txtEmail.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                text += "- University Name can't be empty !\n";
                txtName.BackColor = Color.LightPink;

            }

            if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                text += "- University telephone can't be empty !\n";

            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                text += "- Email can't be empty !\n";
                txtTel.BackColor = Color.LightPink;

            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }
    }
}

