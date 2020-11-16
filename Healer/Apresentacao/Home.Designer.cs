namespace Healer.Apresentacao
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_Administracao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Agendamento = new System.Windows.Forms.Button();
            this.bt_Analise = new System.Windows.Forms.Button();
            this.bt_Atendimento = new System.Windows.Forms.Button();
            this.bt_Paciente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.bt_Atendimento);
            this.panel1.Controls.Add(this.bt_Paciente);
            this.panel1.Controls.Add(this.bt_Analise);
            this.panel1.Controls.Add(this.bt_Agendamento);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bt_Administracao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 749);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1020, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 749);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(147, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(873, 74);
            this.panel6.TabIndex = 2;
            // 
            // bt_Administracao
            // 
            this.bt_Administracao.AccessibleDescription = "Administração";
            this.bt_Administracao.AccessibleName = "Administração";
            this.bt_Administracao.AllowDrop = true;
            this.bt_Administracao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.bt_Administracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_Administracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Administracao.ForeColor = System.Drawing.Color.White;
            this.bt_Administracao.Image = ((System.Drawing.Image)(resources.GetObject("bt_Administracao.Image")));
            this.bt_Administracao.Location = new System.Drawing.Point(12, 113);
            this.bt_Administracao.Name = "bt_Administracao";
            this.bt_Administracao.Size = new System.Drawing.Size(135, 104);
            this.bt_Administracao.TabIndex = 1;
            this.bt_Administracao.UseVisualStyleBackColor = true;
            this.bt_Administracao.Click += new System.EventHandler(this.bt_Administracao_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 104);
            this.panel3.TabIndex = 2;
            // 
            // bt_Agendamento
            // 
            this.bt_Agendamento.AccessibleDescription = "Agendamento";
            this.bt_Agendamento.AccessibleName = "Agendamento";
            this.bt_Agendamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.bt_Agendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Agendamento.ForeColor = System.Drawing.Color.White;
            this.bt_Agendamento.Image = ((System.Drawing.Image)(resources.GetObject("bt_Agendamento.Image")));
            this.bt_Agendamento.Location = new System.Drawing.Point(12, 214);
            this.bt_Agendamento.Name = "bt_Agendamento";
            this.bt_Agendamento.Size = new System.Drawing.Size(135, 104);
            this.bt_Agendamento.TabIndex = 3;
            this.bt_Agendamento.UseVisualStyleBackColor = true;
            this.bt_Agendamento.Click += new System.EventHandler(this.bt_Agendamento_Click);
            // 
            // bt_Analise
            // 
            this.bt_Analise.AccessibleDescription = "Analise";
            this.bt_Analise.AccessibleName = "Analise";
            this.bt_Analise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.bt_Analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Analise.ForeColor = System.Drawing.Color.White;
            this.bt_Analise.Image = ((System.Drawing.Image)(resources.GetObject("bt_Analise.Image")));
            this.bt_Analise.Location = new System.Drawing.Point(12, 315);
            this.bt_Analise.Name = "bt_Analise";
            this.bt_Analise.Size = new System.Drawing.Size(135, 104);
            this.bt_Analise.TabIndex = 4;
            this.bt_Analise.UseVisualStyleBackColor = true;
            this.bt_Analise.Click += new System.EventHandler(this.bt_Analise_Click);
            // 
            // bt_Atendimento
            // 
            this.bt_Atendimento.AccessibleDescription = "Atendimento";
            this.bt_Atendimento.AccessibleName = "Atendimento";
            this.bt_Atendimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.bt_Atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Atendimento.ForeColor = System.Drawing.Color.White;
            this.bt_Atendimento.Image = ((System.Drawing.Image)(resources.GetObject("bt_Atendimento.Image")));
            this.bt_Atendimento.Location = new System.Drawing.Point(12, 517);
            this.bt_Atendimento.Name = "bt_Atendimento";
            this.bt_Atendimento.Size = new System.Drawing.Size(135, 104);
            this.bt_Atendimento.TabIndex = 6;
            this.bt_Atendimento.UseVisualStyleBackColor = true;
            this.bt_Atendimento.Click += new System.EventHandler(this.bt_Atendimento_Click);
            // 
            // bt_Paciente
            // 
            this.bt_Paciente.AccessibleDescription = "Paciente";
            this.bt_Paciente.AccessibleName = "Paciente";
            this.bt_Paciente.AllowDrop = true;
            this.bt_Paciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.bt_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Paciente.ForeColor = System.Drawing.Color.White;
            this.bt_Paciente.Image = ((System.Drawing.Image)(resources.GetObject("bt_Paciente.Image")));
            this.bt_Paciente.Location = new System.Drawing.Point(12, 416);
            this.bt_Paciente.Name = "bt_Paciente";
            this.bt_Paciente.Size = new System.Drawing.Size(135, 104);
            this.bt_Paciente.TabIndex = 5;
            this.bt_Paciente.UseVisualStyleBackColor = true;
            this.bt_Paciente.Click += new System.EventHandler(this.bt_Paciente_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bt_Atendimento;
        private System.Windows.Forms.Button bt_Paciente;
        private System.Windows.Forms.Button bt_Analise;
        private System.Windows.Forms.Button bt_Agendamento;
        protected System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Administracao;
    }
}