namespace M_Launcher
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(903, 60);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(990, 136);
            label2.Name = "label2";
            label2.Size = new Size(45, 37);
            label2.TabIndex = 1;
            label2.Text = "IP:";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileClipboard;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.Location = new Point(1041, 57);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 46);
            iconButton1.TabIndex = 2;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileClipboard;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.Location = new Point(1038, 135);
            iconButton2.Margin = new Padding(0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(48, 46);
            iconButton2.TabIndex = 3;
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 670);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}