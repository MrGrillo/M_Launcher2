namespace M_Launcher
{
    partial class Instalacion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.Location = new Point(257, 97);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(826, 30);
            guna2ProgressBar1.TabIndex = 1;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ProgressBar1.ValueChanged += guna2ProgressBar1_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(guna2ProgressBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 497);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 188);
            panel1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.icons8_descargar_100;
            guna2Button1.ImageSize = new Size(50, 50);
            guna2Button1.Location = new Point(257, 19);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(180, 72);
            guna2Button1.TabIndex = 2;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Instalacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1131, 685);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Instalacion";
            Text = "Instalacion";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}