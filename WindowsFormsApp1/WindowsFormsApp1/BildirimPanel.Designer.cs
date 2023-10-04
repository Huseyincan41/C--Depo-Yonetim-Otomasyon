namespace WindowsFormsApp1
{
    partial class BildirimPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblıd = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblkategori = new System.Windows.Forms.Label();
            this.lblkod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1189, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bildirimler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 447);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblıd
            // 
            this.lblıd.AutoSize = true;
            this.lblıd.Location = new System.Drawing.Point(1367, 92);
            this.lblıd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblıd.Name = "lblıd";
            this.lblıd.Size = new System.Drawing.Size(56, 21);
            this.lblıd.TabIndex = 1;
            this.lblıd.Text = "label1";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(1371, 140);
            this.lblad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(58, 21);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "label2";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Location = new System.Drawing.Point(1371, 190);
            this.lblmarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(58, 21);
            this.lblmarka.TabIndex = 3;
            this.lblmarka.Text = "label3";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(1375, 238);
            this.lblmodel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(58, 21);
            this.lblmodel.TabIndex = 4;
            this.lblmodel.Text = "label4";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(1379, 277);
            this.lblkategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(58, 21);
            this.lblkategori.TabIndex = 5;
            this.lblkategori.Text = "label5";
            // 
            // lblkod
            // 
            this.lblkod.AutoSize = true;
            this.lblkod.Location = new System.Drawing.Point(1371, 331);
            this.lblkod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkod.Name = "lblkod";
            this.lblkod.Size = new System.Drawing.Size(58, 21);
            this.lblkod.TabIndex = 6;
            this.lblkod.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bildirim Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BildirimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1257, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblkod);
            this.Controls.Add(this.lblkategori);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblmarka);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblıd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BildirimPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BildirimPanel";
            this.Load += new System.EventHandler(this.BildirimPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblıd;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblmarka;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.Label lblkod;
        private System.Windows.Forms.Button button1;
    }
}