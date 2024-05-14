namespace App_WinForms
{
    partial class FrmLlamador
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
            tbx_NumeroDestino = new TextBox();
            tbx_NumeroOrigen = new TextBox();
            btn_Llamar = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            cmb_Franja = new ComboBox();
            gbx_PanelNumerico = new GroupBox();
            btn_TeclaNumeral = new Button();
            btn_Tecla0 = new Button();
            btn_TeclaAterisco = new Button();
            btn_Tecla9 = new Button();
            btn_Tecla8 = new Button();
            btn_Tecla7 = new Button();
            btn_Tecla6 = new Button();
            btn_Tecla5 = new Button();
            btn_Tecla4 = new Button();
            btn_Tecla3 = new Button();
            buttonbtn_Tecla2 = new Button();
            btn_Tecla1 = new Button();
            gbx_PanelNumerico.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_NumeroDestino
            // 
            tbx_NumeroDestino.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_NumeroDestino.Location = new Point(31, 12);
            tbx_NumeroDestino.Name = "tbx_NumeroDestino";
            tbx_NumeroDestino.PlaceholderText = "Nro. de Destino";
            tbx_NumeroDestino.ReadOnly = true;
            tbx_NumeroDestino.Size = new Size(340, 35);
            tbx_NumeroDestino.TabIndex = 0;
            // 
            // tbx_NumeroOrigen
            // 
            tbx_NumeroOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_NumeroOrigen.Location = new Point(241, 182);
            tbx_NumeroOrigen.Name = "tbx_NumeroOrigen";
            tbx_NumeroOrigen.PlaceholderText = "Nro. de Origen";
            tbx_NumeroOrigen.ReadOnly = true;
            tbx_NumeroOrigen.Size = new Size(130, 25);
            tbx_NumeroOrigen.TabIndex = 1;
            // 
            // btn_Llamar
            // 
            btn_Llamar.Location = new Point(241, 90);
            btn_Llamar.Name = "btn_Llamar";
            btn_Llamar.Size = new Size(130, 40);
            btn_Llamar.TabIndex = 2;
            btn_Llamar.Text = "Llamar";
            btn_Llamar.UseVisualStyleBackColor = true;
            btn_Llamar.Click += btn_Llamar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(241, 136);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(130, 40);
            btn_Limpiar.TabIndex = 3;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(241, 228);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(130, 40);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // cmb_Franja
            // 
            cmb_Franja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Franja.FormattingEnabled = true;
            cmb_Franja.Location = new Point(31, 295);
            cmb_Franja.Name = "cmb_Franja";
            cmb_Franja.Size = new Size(340, 23);
            cmb_Franja.TabIndex = 5;
            cmb_Franja.SelectedIndexChanged += cmb_Franja_SelectedIndexChanged;
            // 
            // gbx_PanelNumerico
            // 
            gbx_PanelNumerico.Controls.Add(btn_TeclaNumeral);
            gbx_PanelNumerico.Controls.Add(btn_Tecla0);
            gbx_PanelNumerico.Controls.Add(btn_TeclaAterisco);
            gbx_PanelNumerico.Controls.Add(btn_Tecla9);
            gbx_PanelNumerico.Controls.Add(btn_Tecla8);
            gbx_PanelNumerico.Controls.Add(btn_Tecla7);
            gbx_PanelNumerico.Controls.Add(btn_Tecla6);
            gbx_PanelNumerico.Controls.Add(btn_Tecla5);
            gbx_PanelNumerico.Controls.Add(btn_Tecla4);
            gbx_PanelNumerico.Controls.Add(btn_Tecla3);
            gbx_PanelNumerico.Controls.Add(buttonbtn_Tecla2);
            gbx_PanelNumerico.Controls.Add(btn_Tecla1);
            gbx_PanelNumerico.Location = new Point(31, 54);
            gbx_PanelNumerico.Name = "gbx_PanelNumerico";
            gbx_PanelNumerico.Size = new Size(175, 235);
            gbx_PanelNumerico.TabIndex = 6;
            gbx_PanelNumerico.TabStop = false;
            gbx_PanelNumerico.Text = "Panel";
            // 
            // btn_TeclaNumeral
            // 
            btn_TeclaNumeral.Location = new Point(107, 174);
            btn_TeclaNumeral.Name = "btn_TeclaNumeral";
            btn_TeclaNumeral.Size = new Size(40, 40);
            btn_TeclaNumeral.TabIndex = 11;
            btn_TeclaNumeral.Text = "#";
            btn_TeclaNumeral.UseVisualStyleBackColor = true;
            btn_TeclaNumeral.Click += btn_TeclaNumeral_Click;
            // 
            // btn_Tecla0
            // 
            btn_Tecla0.Location = new Point(61, 174);
            btn_Tecla0.Name = "btn_Tecla0";
            btn_Tecla0.Size = new Size(40, 40);
            btn_Tecla0.TabIndex = 10;
            btn_Tecla0.Text = "0";
            btn_Tecla0.UseVisualStyleBackColor = true;
            btn_Tecla0.Click += btn_Tecla0_Click;
            // 
            // btn_TeclaAterisco
            // 
            btn_TeclaAterisco.Location = new Point(9, 174);
            btn_TeclaAterisco.Name = "btn_TeclaAterisco";
            btn_TeclaAterisco.Size = new Size(40, 40);
            btn_TeclaAterisco.TabIndex = 9;
            btn_TeclaAterisco.Text = "*";
            btn_TeclaAterisco.UseVisualStyleBackColor = true;
            btn_TeclaAterisco.Click += btn_TeclaAterisco_Click;
            // 
            // btn_Tecla9
            // 
            btn_Tecla9.Location = new Point(107, 128);
            btn_Tecla9.Name = "btn_Tecla9";
            btn_Tecla9.Size = new Size(40, 40);
            btn_Tecla9.TabIndex = 8;
            btn_Tecla9.Text = "9";
            btn_Tecla9.UseVisualStyleBackColor = true;
            btn_Tecla9.Click += btn_Tecla9_Click;
            // 
            // btn_Tecla8
            // 
            btn_Tecla8.Location = new Point(61, 128);
            btn_Tecla8.Name = "btn_Tecla8";
            btn_Tecla8.Size = new Size(40, 40);
            btn_Tecla8.TabIndex = 7;
            btn_Tecla8.Text = "8";
            btn_Tecla8.UseVisualStyleBackColor = true;
            btn_Tecla8.Click += btn_Tecla8_Click;
            // 
            // btn_Tecla7
            // 
            btn_Tecla7.Location = new Point(9, 128);
            btn_Tecla7.Name = "btn_Tecla7";
            btn_Tecla7.Size = new Size(40, 40);
            btn_Tecla7.TabIndex = 6;
            btn_Tecla7.Text = "7";
            btn_Tecla7.UseVisualStyleBackColor = true;
            btn_Tecla7.Click += btn_Tecla7_Click;
            // 
            // btn_Tecla6
            // 
            btn_Tecla6.Location = new Point(107, 82);
            btn_Tecla6.Name = "btn_Tecla6";
            btn_Tecla6.Size = new Size(40, 40);
            btn_Tecla6.TabIndex = 5;
            btn_Tecla6.Text = "6";
            btn_Tecla6.UseVisualStyleBackColor = true;
            btn_Tecla6.Click += btn_Tecla6_Click;
            // 
            // btn_Tecla5
            // 
            btn_Tecla5.Location = new Point(60, 82);
            btn_Tecla5.Name = "btn_Tecla5";
            btn_Tecla5.Size = new Size(40, 40);
            btn_Tecla5.TabIndex = 4;
            btn_Tecla5.Text = "5";
            btn_Tecla5.UseVisualStyleBackColor = true;
            btn_Tecla5.Click += btn_Tecla5_Click;
            // 
            // btn_Tecla4
            // 
            btn_Tecla4.Location = new Point(9, 82);
            btn_Tecla4.Name = "btn_Tecla4";
            btn_Tecla4.Size = new Size(40, 40);
            btn_Tecla4.TabIndex = 3;
            btn_Tecla4.Text = "4";
            btn_Tecla4.UseVisualStyleBackColor = true;
            btn_Tecla4.Click += btn_Tecla4_Click;
            // 
            // btn_Tecla3
            // 
            btn_Tecla3.Location = new Point(107, 36);
            btn_Tecla3.Name = "btn_Tecla3";
            btn_Tecla3.Size = new Size(40, 40);
            btn_Tecla3.TabIndex = 2;
            btn_Tecla3.Text = "3";
            btn_Tecla3.UseVisualStyleBackColor = true;
            btn_Tecla3.Click += btn_Tecla3_Click;
            // 
            // buttonbtn_Tecla2
            // 
            buttonbtn_Tecla2.Location = new Point(60, 36);
            buttonbtn_Tecla2.Name = "buttonbtn_Tecla2";
            buttonbtn_Tecla2.Size = new Size(40, 40);
            buttonbtn_Tecla2.TabIndex = 1;
            buttonbtn_Tecla2.Text = "2";
            buttonbtn_Tecla2.UseVisualStyleBackColor = true;
            buttonbtn_Tecla2.Click += buttonbtn_Tecla2_Click;
            // 
            // btn_Tecla1
            // 
            btn_Tecla1.Location = new Point(9, 36);
            btn_Tecla1.Name = "btn_Tecla1";
            btn_Tecla1.Size = new Size(40, 40);
            btn_Tecla1.TabIndex = 0;
            btn_Tecla1.Text = "1";
            btn_Tecla1.UseVisualStyleBackColor = true;
            btn_Tecla1.Click += btn_Tecla1_Click;
            // 
            // FrmLlamador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 391);
            Controls.Add(gbx_PanelNumerico);
            Controls.Add(cmb_Franja);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Llamar);
            Controls.Add(tbx_NumeroOrigen);
            Controls.Add(tbx_NumeroDestino);
            Name = "FrmLlamador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Llamador";
            FormClosing += FrmLlamador_FormClosing;
            Load += FrmLlamador_Load;
            gbx_PanelNumerico.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_NumeroDestino;
        private TextBox tbx_NumeroOrigen;
        private Button btn_Llamar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private ComboBox cmb_Franja;
        private GroupBox gbx_PanelNumerico;
        private Button btn_TeclaNumeral;
        private Button btn_Tecla0;
        private Button btn_TeclaAterisco;
        private Button btn_Tecla9;
        private Button btn_Tecla8;
        private Button btn_Tecla7;
        private Button btn_Tecla6;
        private Button btn_Tecla5;
        private Button btn_Tecla4;
        private Button btn_Tecla3;
        private Button buttonbtn_Tecla2;
        private Button btn_Tecla1;
    }
}