﻿using System;

namespace CCO1.WinForms
{
    partial class Frmetudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblAt = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.picRemover = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEtablissement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NTtxtMatricule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.imgMatricule = new System.Windows.Forms.PictureBox();
            this.lbMatricule = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMatricule)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.CustomFormat = "yyyy/MM/dd";
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNaissance.Location = new System.Drawing.Point(2, 240);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(162, 32);
            this.dtpNaissance.TabIndex = 2;
            this.dtpNaissance.Value = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.BackColor = System.Drawing.Color.Transparent;
            this.lblAt.ForeColor = System.Drawing.Color.Azure;
            this.lblAt.Location = new System.Drawing.Point(-3, 275);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(181, 26);
            this.lblAt.TabIndex = 67;
            this.lblAt.Text = "Date d admission";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.ForeColor = System.Drawing.Color.Azure;
            this.lblTel.Location = new System.Drawing.Point(-3, 344);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(53, 26);
            this.lblTel.TabIndex = 65;
            this.lblTel.Text = "Tel :";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTel.Location = new System.Drawing.Point(2, 373);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(165, 32);
            this.txtTel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(385, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 353);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.Color.Azure;
            this.lblLastName.Location = new System.Drawing.Point(2, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 26);
            this.lblLastName.TabIndex = 62;
            this.lblLastName.Text = "PRENOM :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(2, 101);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(162, 32);
            this.txtPrenom.TabIndex = 1;
            // 
            // picRemover
            // 
            this.picRemover.BackColor = System.Drawing.Color.Transparent;
            this.picRemover.FlatAppearance.BorderSize = 0;
            this.picRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picRemover.ForeColor = System.Drawing.Color.Red;
            this.picRemover.Location = new System.Drawing.Point(326, 323);
            this.picRemover.Name = "picRemover";
            this.picRemover.Size = new System.Drawing.Size(33, 33);
            this.picRemover.TabIndex = 60;
            this.picRemover.Text = "X";
            this.picRemover.UseVisualStyleBackColor = false;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoto.ForeColor = System.Drawing.Color.Azure;
            this.lblPhoto.Location = new System.Drawing.Point(189, 333);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(78, 26);
            this.lblPhoto.TabIndex = 57;
            this.lblPhoto.Text = "photo :";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1103, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.ForeColor = System.Drawing.Color.Azure;
            this.lblSearch.Location = new System.Drawing.Point(406, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 26);
            this.lblSearch.TabIndex = 55;
            this.lblSearch.Text = "SEARCH :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(529, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(568, 32);
            this.txtSearch.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Location = new System.Drawing.Point(411, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 44);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Retour";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Azure;
            this.lblEmail.Location = new System.Drawing.Point(-3, 408);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 26);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Location = new System.Drawing.Point(2, 437);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 32);
            this.txtEmail.TabIndex = 7;
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBornDate.ForeColor = System.Drawing.Color.Azure;
            this.lblBornDate.Location = new System.Drawing.Point(-3, 205);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(204, 26);
            this.lblBornDate.TabIndex = 49;
            this.lblBornDate.Text = "Date de naissance :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.Color.Azure;
            this.lblFirstName.Location = new System.Drawing.Point(2, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 26);
            this.lblFirstName.TabIndex = 48;
            this.lblFirstName.Text = "NOM :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(2, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(162, 32);
            this.txtNom.TabIndex = 0;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.Color.White;
            this.imgPhoto.Location = new System.Drawing.Point(184, 373);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(188, 96);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 46;
            this.imgPhoto.TabStop = false;
            // 
            // dtpAdmission
            // 
            this.dtpAdmission.CustomFormat = "yyyy/MM/dd";
            this.dtpAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdmission.Location = new System.Drawing.Point(2, 304);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(162, 32);
            this.dtpAdmission.TabIndex = 68;
            this.dtpAdmission.Value = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 72;
            this.label1.Text = "Etablissement :";
            // 
            // txtEtablissement
            // 
            this.txtEtablissement.Location = new System.Drawing.Point(191, 41);
            this.txtEtablissement.Name = "txtEtablissement";
            this.txtEtablissement.Size = new System.Drawing.Size(181, 32);
            this.txtEtablissement.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(2, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 71;
            this.label2.Text = "Matricule";
            // 
            // NTtxtMatricule
            // 
            this.NTtxtMatricule.Location = new System.Drawing.Point(2, 165);
            this.NTtxtMatricule.Name = "NTtxtMatricule";
            this.NTtxtMatricule.Size = new System.Drawing.Size(181, 32);
            this.NTtxtMatricule.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(189, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 74;
            this.label3.Text = "Departement :";
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(194, 105);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(181, 32);
            this.txtDepartement.TabIndex = 73;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(1037, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 44);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(713, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnEdit.Location = new System.Drawing.Point(553, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 44);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edite";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.Location = new System.Drawing.Point(877, 420);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 44);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // imgMatricule
            // 
            this.imgMatricule.BackColor = System.Drawing.Color.White;
            this.imgMatricule.Location = new System.Drawing.Point(194, 240);
            this.imgMatricule.Name = "imgMatricule";
            this.imgMatricule.Size = new System.Drawing.Size(165, 77);
            this.imgMatricule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMatricule.TabIndex = 75;
            this.imgMatricule.TabStop = false;
            // 
            // lbMatricule
            // 
            this.lbMatricule.AutoSize = true;
            this.lbMatricule.BackColor = System.Drawing.Color.Transparent;
            this.lbMatricule.ForeColor = System.Drawing.Color.Azure;
            this.lbMatricule.Location = new System.Drawing.Point(189, 205);
            this.lbMatricule.Name = "lbMatricule";
            this.lbMatricule.Size = new System.Drawing.Size(170, 26);
            this.lbMatricule.TabIndex = 76;
            this.lbMatricule.Text = "Code Matricule :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(189, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 78;
            this.label4.Text = "Sex :";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(194, 165);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(181, 32);
            this.txtSex.TabIndex = 77;
            // 
            // Frmetudiant
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1203, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.lbMatricule);
            this.Controls.Add(this.imgMatricule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtablissement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NTtxtMatricule);
            this.Controls.Add(this.dtpAdmission);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.lblAt);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.picRemover);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBornDate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.imgPhoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frmetudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMatricule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void Frmetudiant_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button picRemover;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.DateTimePicker dtpAdmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEtablissement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NTtxtMatricule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox imgMatricule;
        private System.Windows.Forms.Label lbMatricule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSex;
    }
}

