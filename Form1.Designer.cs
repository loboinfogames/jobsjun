namespace proj_14._6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btVenda = new System.Windows.Forms.Button();
            this.btcliente = new System.Windows.Forms.Button();
            this.btFilmes = new System.Windows.Forms.Button();
            this.btBombom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVenda
            // 
            this.btVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btVenda.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.Location = new System.Drawing.Point(204, 177);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(174, 61);
            this.btVenda.TabIndex = 0;
            this.btVenda.Text = "venda";
            this.btVenda.UseVisualStyleBackColor = false;
            // 
            // btcliente
            // 
            this.btcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btcliente.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcliente.Location = new System.Drawing.Point(587, 177);
            this.btcliente.Name = "btcliente";
            this.btcliente.Size = new System.Drawing.Size(178, 61);
            this.btcliente.TabIndex = 1;
            this.btcliente.Text = "cliente\r\n";
            this.btcliente.UseVisualStyleBackColor = false;
            this.btcliente.Click += new System.EventHandler(this.btcliente_Click);
            // 
            // btFilmes
            // 
            this.btFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btFilmes.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilmes.Location = new System.Drawing.Point(204, 315);
            this.btFilmes.Name = "btFilmes";
            this.btFilmes.Size = new System.Drawing.Size(159, 58);
            this.btFilmes.TabIndex = 2;
            this.btFilmes.Text = "filmes";
            this.btFilmes.UseVisualStyleBackColor = false;
            this.btFilmes.Click += new System.EventHandler(this.btFilmes_Click_1);
            // 
            // btBombom
            // 
            this.btBombom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBombom.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBombom.Location = new System.Drawing.Point(504, 315);
            this.btBombom.Name = "btBombom";
            this.btBombom.Size = new System.Drawing.Size(261, 58);
            this.btBombom.TabIndex = 3;
            this.btBombom.Text = "bomboniere";
            this.btBombom.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proj_14._6.Properties.Resources.rolo_filme_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(78, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_14._6.Properties.Resources.bomboniere2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(406, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFilmes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btBombom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcliente);
            this.Controls.Add(this.btVenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btcliente;
        private System.Windows.Forms.Button btFilmes;
        private System.Windows.Forms.Button btBombom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

