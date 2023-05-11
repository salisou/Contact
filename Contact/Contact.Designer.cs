namespace Contact
{
    partial class EContact
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EContact));
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.ContactID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.lblGenere = new System.Windows.Forms.Label();
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCanella = new System.Windows.Forms.Button();
            this.btnEliminaTutto = new System.Windows.Forms.Button();
            this.dataGridContatti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContatto = new System.Windows.Forms.TextBox();
            this.lblContatto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblContact.Location = new System.Drawing.Point(319, 20);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(132, 32);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contatti";
            // 
            // txtContactID
            // 
            this.txtContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactID.Location = new System.Drawing.Point(152, 71);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(163, 26);
            this.txtContactID.TabIndex = 5;
            // 
            // ContactID
            // 
            this.ContactID.AutoSize = true;
            this.ContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactID.Location = new System.Drawing.Point(33, 77);
            this.ContactID.Name = "ContactID";
            this.ContactID.Size = new System.Drawing.Size(96, 20);
            this.ContactID.TabIndex = 4;
            this.ContactID.Text = "Contact ID";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(152, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 26);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognome.Location = new System.Drawing.Point(152, 150);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(163, 26);
            this.txtCognome.TabIndex = 9;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(33, 156);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(85, 20);
            this.lblCognome.TabIndex = 8;
            this.lblCognome.Text = "Cognome";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndirizzo.Location = new System.Drawing.Point(152, 231);
            this.txtIndirizzo.Multiline = true;
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(163, 85);
            this.txtIndirizzo.TabIndex = 11;
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndirizzo.Location = new System.Drawing.Point(33, 237);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(77, 20);
            this.lblIndirizzo.TabIndex = 10;
            this.lblIndirizzo.Text = "Indirizzo";
            // 
            // cmbGenere
            // 
            this.cmbGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGenere.Location = new System.Drawing.Point(152, 338);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(163, 28);
            this.cmbGenere.TabIndex = 12;
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere.Location = new System.Drawing.Point(33, 339);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(69, 20);
            this.lblGenere.TabIndex = 13;
            this.lblGenere.Text = "Genere";
            // 
            // btnAgg
            // 
            this.btnAgg.BackColor = System.Drawing.Color.Lime;
            this.btnAgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgg.ForeColor = System.Drawing.Color.White;
            this.btnAgg.Location = new System.Drawing.Point(152, 384);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(120, 33);
            this.btnAgg.TabIndex = 14;
            this.btnAgg.Text = "Aggiungi";
            this.btnAgg.UseVisualStyleBackColor = false;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(324, 384);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(120, 33);
            this.btnModifica.TabIndex = 15;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCanella
            // 
            this.btnCanella.BackColor = System.Drawing.Color.Crimson;
            this.btnCanella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanella.ForeColor = System.Drawing.Color.White;
            this.btnCanella.Location = new System.Drawing.Point(500, 384);
            this.btnCanella.Name = "btnCanella";
            this.btnCanella.Size = new System.Drawing.Size(120, 33);
            this.btnCanella.TabIndex = 16;
            this.btnCanella.Text = "Cancella";
            this.btnCanella.UseVisualStyleBackColor = false;
            this.btnCanella.Click += new System.EventHandler(this.btnCanella_Click);
            // 
            // btnEliminaTutto
            // 
            this.btnEliminaTutto.BackColor = System.Drawing.Color.Orange;
            this.btnEliminaTutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaTutto.ForeColor = System.Drawing.Color.White;
            this.btnEliminaTutto.Location = new System.Drawing.Point(668, 384);
            this.btnEliminaTutto.Name = "btnEliminaTutto";
            this.btnEliminaTutto.Size = new System.Drawing.Size(120, 33);
            this.btnEliminaTutto.TabIndex = 17;
            this.btnEliminaTutto.Text = "Elimina Tutto";
            this.btnEliminaTutto.UseVisualStyleBackColor = false;
            this.btnEliminaTutto.Click += new System.EventHandler(this.btnEliminaTutto_Click);
            // 
            // dataGridContatti
            // 
            this.dataGridContatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContatti.Location = new System.Drawing.Point(340, 113);
            this.dataGridContatti.Name = "dataGridContatti";
            this.dataGridContatti.Size = new System.Drawing.Size(447, 253);
            this.dataGridContatti.TabIndex = 18;
            this.dataGridContatti.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridContatti_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cerca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCerca
            // 
            this.txtCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerca.Location = new System.Drawing.Point(414, 74);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(373, 26);
            this.txtCerca.TabIndex = 20;
            this.txtCerca.TextChanged += new System.EventHandler(this.txtCerca_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtContatto
            // 
            this.txtContatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatto.Location = new System.Drawing.Point(152, 191);
            this.txtContatto.Name = "txtContatto";
            this.txtContatto.Size = new System.Drawing.Size(163, 26);
            this.txtContatto.TabIndex = 23;
            // 
            // lblContatto
            // 
            this.lblContatto.AutoSize = true;
            this.lblContatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatto.Location = new System.Drawing.Point(33, 197);
            this.lblContatto.Name = "lblContatto";
            this.lblContatto.Size = new System.Drawing.Size(79, 20);
            this.lblContatto.TabIndex = 22;
            this.lblContatto.Text = "Contatto";
            // 
            // EContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContatto);
            this.Controls.Add(this.lblContatto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridContatti);
            this.Controls.Add(this.btnEliminaTutto);
            this.Controls.Add(this.btnCanella);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.cmbGenere);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.ContactID);
            this.Controls.Add(this.lblContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EContact";
            this.Text = "EContact";
            this.Load += new System.EventHandler(this.EContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label ContactID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCanella;
        private System.Windows.Forms.Button btnEliminaTutto;
        private System.Windows.Forms.DataGridView dataGridContatti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtContatto;
        private System.Windows.Forms.Label lblContatto;
    }
}

