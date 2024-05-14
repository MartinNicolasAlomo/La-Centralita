namespace App_WinForms
{
    partial class FrmMostrar
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
            rtb_MostrarDatos = new RichTextBox();
            SuspendLayout();
            // 
            // rtb_MostrarDatos
            // 
            rtb_MostrarDatos.Dock = DockStyle.Fill;
            rtb_MostrarDatos.Location = new Point(0, 0);
            rtb_MostrarDatos.Name = "rtb_MostrarDatos";
            rtb_MostrarDatos.Size = new Size(414, 261);
            rtb_MostrarDatos.TabIndex = 0;
            rtb_MostrarDatos.Text = "";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 261);
            Controls.Add(rtb_MostrarDatos);
            Name = "FrmMostrar";
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += FrmMostrar_FormClosing;
            Load += FrmMostrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_MostrarDatos;
    }
}