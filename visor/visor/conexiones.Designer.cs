namespace visor
{
    partial class conexiones
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
            this.components = new System.ComponentModel.Container();
            this.lblConexion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtpuerto = new System.Windows.Forms.TextBox();
            this.btScreen = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblConexion.Location = new System.Drawing.Point(86, 153);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(31, 24);
            this.lblConexion.TabIndex = 0;
            this.lblConexion.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUERTO:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(113, 158);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(228, 20);
            this.txtIp.TabIndex = 2;
            // 
            // txtpuerto
            // 
            this.txtpuerto.Location = new System.Drawing.Point(113, 120);
            this.txtpuerto.Name = "txtpuerto";
            this.txtpuerto.Size = new System.Drawing.Size(228, 20);
            this.txtpuerto.TabIndex = 3;
            // 
            // btScreen
            // 
            this.btScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btScreen.Location = new System.Drawing.Point(28, 213);
            this.btScreen.Name = "btScreen";
            this.btScreen.Size = new System.Drawing.Size(313, 33);
            this.btScreen.TabIndex = 4;
            this.btScreen.Text = "MOSTRAR PANTALLA";
            this.btScreen.UseVisualStyleBackColor = true;
            this.btScreen.Click += new System.EventHandler(this.btScreen_Click);
            // 
            // btConectar
            // 
            this.btConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btConectar.Location = new System.Drawing.Point(28, 268);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(313, 33);
            this.btConectar.TabIndex = 5;
            this.btConectar.Text = "CONECTAR";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // conexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btScreen);
            this.Controls.Add(this.txtpuerto);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConexion);
            this.Name = "conexiones";
            this.Text = "conexion";
            this.Load += new System.EventHandler(this.conexiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtpuerto;
        private System.Windows.Forms.Button btScreen;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Timer timer1;
    }
}