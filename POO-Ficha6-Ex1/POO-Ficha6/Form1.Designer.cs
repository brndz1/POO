namespace POO_Ficha6
{
    partial class CelConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelC = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(236, 119);
            this.labelC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(90, 30);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "Celsius:";
            this.labelC.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(448, 301);
            this.labelK.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(80, 30);
            this.labelK.TabIndex = 1;
            this.labelK.Text = "Kelvin:";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(36, 304);
            this.labelF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(127, 30);
            this.labelF.TabIndex = 2;
            this.labelF.Text = "Fahrenheit:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.SystemColors.Info;
            this.buttonConvert.Location = new System.Drawing.Point(338, 205);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(139, 46);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "CONVERT";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(540, 296);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(182, 35);
            this.textBoxK.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(338, 119);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(182, 35);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(175, 301);
            this.textBoxF.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.ReadOnly = true;
            this.textBoxF.Size = new System.Drawing.Size(182, 35);
            this.textBoxF.TabIndex = 6;
            // 
            // CelConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 431);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelC);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CelConverter";
            this.Text = "CelConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelC;
        private Label labelK;
        private Label labelF;
        private Button buttonConvert;
        private TextBox textBoxK;
        private TextBox textBoxC;
        private TextBox textBoxF;
    }
}