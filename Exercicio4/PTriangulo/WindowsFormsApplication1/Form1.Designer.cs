namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(336, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(222, 20);
            this.txtA.TabIndex = 4;
            this.txtA.Validated += new System.EventHandler(this.txtLadoA_Validated);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(336, 184);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(222, 20);
            this.txtC.TabIndex = 5;
            this.txtC.Validated += new System.EventHandler(this.txtC_Validated);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(336, 101);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(222, 20);
            this.txtB.TabIndex = 6;
            this.txtB.Validated += new System.EventHandler(this.txtB_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 90);
            this.button1.TabIndex = 8;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(227, 359);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(430, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 603);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTipo;
    }
}

