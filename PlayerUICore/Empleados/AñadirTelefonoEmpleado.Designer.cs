﻿namespace PlayerUI.Pacientes
{
    partial class AñadirTelefonoEmpleado
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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            txtTipo = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtNum = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(501, 276);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 38);
            button1.TabIndex = 54;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(235, 42, 83);
            label1.Location = new System.Drawing.Point(240, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(221, 25);
            label1.TabIndex = 50;
            label1.Text = "Añadir Detalle a Factura";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 42, 83);
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.LightGray;
            btnExit.Location = new System.Drawing.Point(14, 14);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(29, 29);
            btnExit.TabIndex = 48;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.SystemColors.Control;
            label7.Location = new System.Drawing.Point(97, 207);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 17);
            label7.TabIndex = 64;
            label7.Text = "Tipo de Telefono:";
            // 
            // txtTipo
            // 
            txtTipo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTipo.Location = new System.Drawing.Point(240, 198);
            txtTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTipo.MaxLength = 10;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new System.Drawing.Size(365, 26);
            txtTipo.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(80, 135);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 17);
            label10.TabIndex = 60;
            label10.Text = "Numero de telefono:";
            // 
            // txtNum
            // 
            txtNum.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNum.Location = new System.Drawing.Point(240, 126);
            txtNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNum.MaxLength = 10;
            txtNum.Name = "txtNum";
            txtNum.Size = new System.Drawing.Size(365, 26);
            txtNum.TabIndex = 58;
            // 
            // AñadirTelefonoEmpleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(700, 600);
            Controls.Add(label7);
            Controls.Add(txtTipo);
            Controls.Add(label10);
            Controls.Add(txtNum);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnExit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AñadirTelefonoEmpleado";
            Text = "ActualizarPaciente";
            Load += ActualizarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNum;
    }
}