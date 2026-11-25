namespace garage
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSinistra = new System.Windows.Forms.Panel();
            this.lstMoto = new System.Windows.Forms.ListBox();
            this.labelTitolo = new System.Windows.Forms.Label();
            this.labelModello = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelManutenzioni = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.dtpUltimaData = new System.Windows.Forms.DateTimePicker();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelTarga = new System.Windows.Forms.Label();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.numKmAttuali = new System.Windows.Forms.NumericUpDown();
            this.gridManutenzioni = new System.Windows.Forms.DataGridView();
            this.labelKm = new System.Windows.Forms.Label();
            this.panelPrincipale = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSinistra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmAttuali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManutenzioni)).BeginInit();
            this.panelPrincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSinistra
            // 
            this.panelSinistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelSinistra.Controls.Add(this.lstMoto);
            this.panelSinistra.Controls.Add(this.labelTitolo);
            this.panelSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSinistra.Location = new System.Drawing.Point(0, 0);
            this.panelSinistra.Name = "panelSinistra";
            this.panelSinistra.Padding = new System.Windows.Forms.Padding(12);
            this.panelSinistra.Size = new System.Drawing.Size(513, 722);
            this.panelSinistra.TabIndex = 0;
            // 
            // lstMoto
            // 
            this.lstMoto.BackColor = System.Drawing.Color.White;
            this.lstMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMoto.FormattingEnabled = true;
            this.lstMoto.ItemHeight = 16;
            this.lstMoto.Location = new System.Drawing.Point(15, 47);
            this.lstMoto.Name = "lstMoto";
            this.lstMoto.Size = new System.Drawing.Size(466, 658);
            this.lstMoto.TabIndex = 1;
            this.lstMoto.SelectedIndexChanged += new System.EventHandler(this.lstMoto_SelectedIndexChanged);
            // 
            // labelTitolo
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.labelTitolo.Location = new System.Drawing.Point(12, 9);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Size = new System.Drawing.Size(265, 25);
            this.labelTitolo.TabIndex = 0;
            this.labelTitolo.Text = "Ecco l\'elenco delle tue moto:";
            // 
            // labelModello
            // 
            this.labelModello.AutoSize = true;
            this.labelModello.Location = new System.Drawing.Point(33, 131);
            this.labelModello.Name = "labelModello";
            this.labelModello.Size = new System.Drawing.Size(59, 16);
            this.labelModello.TabIndex = 2;
            this.labelModello.Text = "Modello:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(33, 260);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(39, 16);
            this.labelData.TabIndex = 10;
            this.labelData.Text = "Data:";
            // 
            // labelManutenzioni
            // 
            this.labelManutenzioni.AutoSize = true;
            this.labelManutenzioni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelManutenzioni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.labelManutenzioni.Location = new System.Drawing.Point(521, 12);
            this.labelManutenzioni.Name = "labelManutenzioni";
            this.labelManutenzioni.Size = new System.Drawing.Size(234, 25);
            this.labelManutenzioni.TabIndex = 11;
            this.labelManutenzioni.Text = "Stato delle manutenzioni";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(179, 320);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 36);
            this.btnElimina.TabIndex = 8;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(45, 320);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(86, 36);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(131, 80);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(145, 22);
            this.txtMarca.TabIndex = 0;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(131, 125);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(145, 22);
            this.txtModello.TabIndex = 3;
            // 
            // dtpUltimaData
            // 
            this.dtpUltimaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimaData.Location = new System.Drawing.Point(131, 254);
            this.dtpUltimaData.Name = "dtpUltimaData";
            this.dtpUltimaData.Size = new System.Drawing.Size(145, 22);
            this.dtpUltimaData.TabIndex = 4;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(33, 86);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(48, 16);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca:";
            // 
            // labelTarga
            // 
            this.labelTarga.AutoSize = true;
            this.labelTarga.Location = new System.Drawing.Point(33, 172);
            this.labelTarga.Name = "labelTarga";
            this.labelTarga.Size = new System.Drawing.Size(47, 16);
            this.labelTarga.TabIndex = 3;
            this.labelTarga.Text = "Targa:";
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(131, 166);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(145, 22);
            this.txtTarga.TabIndex = 5;
            // 
            // numKmAttuali
            // 
            this.numKmAttuali.Location = new System.Drawing.Point(131, 210);
            this.numKmAttuali.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKmAttuali.Name = "numKmAttuali";
            this.numKmAttuali.Size = new System.Drawing.Size(145, 22);
            this.numKmAttuali.TabIndex = 6;
            // 
            // gridManutenzioni
            // 
            this.gridManutenzioni.AllowUserToAddRows = false;
            this.gridManutenzioni.AllowUserToDeleteRows = false;
            this.gridManutenzioni.AllowUserToOrderColumns = true;
            this.gridManutenzioni.AllowUserToResizeRows = false;
            this.gridManutenzioni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridManutenzioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridManutenzioni.BackgroundColor = System.Drawing.Color.White;
            this.gridManutenzioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridManutenzioni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridManutenzioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManutenzioni.EnableHeadersVisualStyles = false;
            this.gridManutenzioni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.gridManutenzioni.Location = new System.Drawing.Point(402, 40);
            this.gridManutenzioni.Name = "gridManutenzioni";
            this.gridManutenzioni.ReadOnly = true;
            this.gridManutenzioni.RowHeadersVisible = false;
            this.gridManutenzioni.RowHeadersWidth = 51;
            this.gridManutenzioni.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.gridManutenzioni.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridManutenzioni.RowTemplate.Height = 24;
            this.gridManutenzioni.Size = new System.Drawing.Size(628, 650);
            this.gridManutenzioni.TabIndex = 8;
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(33, 216);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(29, 16);
            this.labelKm.TabIndex = 9;
            this.labelKm.Text = "Km:";
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.BackColor = System.Drawing.Color.White;
            this.panelPrincipale.Controls.Add(this.label1);
            this.panelPrincipale.Controls.Add(this.btnElimina);
            this.panelPrincipale.Controls.Add(this.labelKm);
            this.panelPrincipale.Controls.Add(this.gridManutenzioni);
            this.panelPrincipale.Controls.Add(this.labelManutenzioni);
            this.panelPrincipale.Controls.Add(this.numKmAttuali);
            this.panelPrincipale.Controls.Add(this.btnAggiungi);
            this.panelPrincipale.Controls.Add(this.txtTarga);
            this.panelPrincipale.Controls.Add(this.labelTarga);
            this.panelPrincipale.Controls.Add(this.txtModello);
            this.panelPrincipale.Controls.Add(this.labelModello);
            this.panelPrincipale.Controls.Add(this.dtpUltimaData);
            this.panelPrincipale.Controls.Add(this.labelData);
            this.panelPrincipale.Controls.Add(this.labelMarca);
            this.panelPrincipale.Controls.Add(this.txtMarca);
            this.panelPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipale.Location = new System.Drawing.Point(513, 0);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(1046, 722);
            this.panelPrincipale.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aggiungi una moto alla tua lista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 722);
            this.Controls.Add(this.panelPrincipale);
            this.Controls.Add(this.panelSinistra);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Garage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSinistra.ResumeLayout(false);
            this.panelSinistra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKmAttuali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManutenzioni)).EndInit();
            this.panelPrincipale.ResumeLayout(false);
            this.panelPrincipale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSinistra;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.ListBox lstMoto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModello;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelManutenzioni;
        private System.Windows.Forms.Label labelTarga;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.DateTimePicker dtpUltimaData;
        private System.Windows.Forms.NumericUpDown numKmAttuali;
        private System.Windows.Forms.DataGridView gridManutenzioni;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Panel panelPrincipale;
        private System.Windows.Forms.Label label1;
    }
}

