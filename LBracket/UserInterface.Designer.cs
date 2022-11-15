namespace LBracket
{
    partial class Min_t
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxD = new System.Windows.Forms.Label();
            this.uxL1 = new System.Windows.Forms.Label();
            this.uxShortArmLength = new System.Windows.Forms.Label();
            this.uxSy = new System.Windows.Forms.Label();
            this.uxCompute = new System.Windows.Forms.Button();
            this.uxODText = new System.Windows.Forms.TextBox();
            this.uxL1Text = new System.Windows.Forms.TextBox();
            this.uxL2Text = new System.Windows.Forms.TextBox();
            this.uxSyText = new System.Windows.Forms.TextBox();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxFOS = new System.Windows.Forms.Label();
            this.uxFOStext = new System.Windows.Forms.TextBox();
            this.uxID = new System.Windows.Forms.Label();
            this.uxFText = new System.Windows.Forms.TextBox();
            this.uxF = new System.Windows.Forms.Label();
            this.uxIDText = new System.Windows.Forms.Label();
            this.uxMass = new System.Windows.Forms.Label();
            this.uxMassText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Design L-Bracket Calculation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxD
            // 
            this.uxD.AutoSize = true;
            this.uxD.Location = new System.Drawing.Point(0, 60);
            this.uxD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxD.Name = "uxD";
            this.uxD.Size = new System.Drawing.Size(138, 25);
            this.uxD.TabIndex = 1;
            this.uxD.Text = "Outer Diameter:";
            // 
            // uxL1
            // 
            this.uxL1.AutoSize = true;
            this.uxL1.Location = new System.Drawing.Point(6, 108);
            this.uxL1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxL1.Name = "uxL1";
            this.uxL1.Size = new System.Drawing.Size(63, 25);
            this.uxL1.TabIndex = 2;
            this.uxL1.Text = "L1 (in):";
            // 
            // uxShortArmLength
            // 
            this.uxShortArmLength.AutoSize = true;
            this.uxShortArmLength.Location = new System.Drawing.Point(6, 157);
            this.uxShortArmLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxShortArmLength.Name = "uxShortArmLength";
            this.uxShortArmLength.Size = new System.Drawing.Size(63, 25);
            this.uxShortArmLength.TabIndex = 3;
            this.uxShortArmLength.Text = "L2 (in):";
            // 
            // uxSy
            // 
            this.uxSy.AutoSize = true;
            this.uxSy.Location = new System.Drawing.Point(6, 245);
            this.uxSy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSy.Name = "uxSy";
            this.uxSy.Size = new System.Drawing.Size(72, 25);
            this.uxSy.TabIndex = 4;
            this.uxSy.Text = "Sy (psi):";
            // 
            // uxCompute
            // 
            this.uxCompute.Location = new System.Drawing.Point(40, 337);
            this.uxCompute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxCompute.Name = "uxCompute";
            this.uxCompute.Size = new System.Drawing.Size(197, 58);
            this.uxCompute.TabIndex = 5;
            this.uxCompute.Text = "Calculate";
            this.uxCompute.UseVisualStyleBackColor = true;
            this.uxCompute.Click += new System.EventHandler(this.uxCompute_Click);
            // 
            // uxODText
            // 
            this.uxODText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxODText.Location = new System.Drawing.Point(139, 47);
            this.uxODText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxODText.Name = "uxODText";
            this.uxODText.Size = new System.Drawing.Size(141, 31);
            this.uxODText.TabIndex = 6;
            // 
            // uxL1Text
            // 
            this.uxL1Text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxL1Text.Location = new System.Drawing.Point(139, 95);
            this.uxL1Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxL1Text.Name = "uxL1Text";
            this.uxL1Text.Size = new System.Drawing.Size(141, 31);
            this.uxL1Text.TabIndex = 7;
            // 
            // uxL2Text
            // 
            this.uxL2Text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxL2Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uxL2Text.Location = new System.Drawing.Point(139, 143);
            this.uxL2Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxL2Text.Name = "uxL2Text";
            this.uxL2Text.Size = new System.Drawing.Size(141, 31);
            this.uxL2Text.TabIndex = 8;
            // 
            // uxSyText
            // 
            this.uxSyText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxSyText.Location = new System.Drawing.Point(139, 240);
            this.uxSyText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSyText.Name = "uxSyText";
            this.uxSyText.Size = new System.Drawing.Size(141, 31);
            this.uxSyText.TabIndex = 9;
            this.uxSyText.Text = "5163.313";
            // 
            // uxFOS
            // 
            this.uxFOS.AutoSize = true;
            this.uxFOS.Location = new System.Drawing.Point(6, 293);
            this.uxFOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFOS.Name = "uxFOS";
            this.uxFOS.Size = new System.Drawing.Size(92, 25);
            this.uxFOS.TabIndex = 10;
            this.uxFOS.Text = "Ideal FOS:";
            // 
            // uxFOStext
            // 
            this.uxFOStext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxFOStext.Location = new System.Drawing.Point(139, 288);
            this.uxFOStext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFOStext.Name = "uxFOStext";
            this.uxFOStext.Size = new System.Drawing.Size(141, 31);
            this.uxFOStext.TabIndex = 11;
            this.uxFOStext.Text = "1.0";
            // 
            // uxID
            // 
            this.uxID.AutoSize = true;
            this.uxID.Location = new System.Drawing.Point(6, 405);
            this.uxID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxID.Name = "uxID";
            this.uxID.Size = new System.Drawing.Size(63, 25);
            this.uxID.TabIndex = 12;
            this.uxID.Text = "ID (in):";
            // 
            // uxFText
            // 
            this.uxFText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxFText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uxFText.Location = new System.Drawing.Point(139, 192);
            this.uxFText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFText.Name = "uxFText";
            this.uxFText.Size = new System.Drawing.Size(141, 31);
            this.uxFText.TabIndex = 14;
            // 
            // uxF
            // 
            this.uxF.AutoSize = true;
            this.uxF.Location = new System.Drawing.Point(6, 197);
            this.uxF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxF.Name = "uxF";
            this.uxF.Size = new System.Drawing.Size(55, 25);
            this.uxF.TabIndex = 15;
            this.uxF.Text = "F (lb):";
            // 
            // uxIDText
            // 
            this.uxIDText.AutoSize = true;
            this.uxIDText.Location = new System.Drawing.Point(139, 405);
            this.uxIDText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxIDText.Name = "uxIDText";
            this.uxIDText.Size = new System.Drawing.Size(0, 25);
            this.uxIDText.TabIndex = 16;
            // 
            // uxMass
            // 
            this.uxMass.AutoSize = true;
            this.uxMass.Location = new System.Drawing.Point(6, 450);
            this.uxMass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxMass.Name = "uxMass";
            this.uxMass.Size = new System.Drawing.Size(83, 25);
            this.uxMass.TabIndex = 17;
            this.uxMass.Text = "Mass (g):";
            // 
            // uxMassText
            // 
            this.uxMassText.AutoSize = true;
            this.uxMassText.Location = new System.Drawing.Point(139, 450);
            this.uxMassText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxMassText.Name = "uxMassText";
            this.uxMassText.Size = new System.Drawing.Size(0, 25);
            this.uxMassText.TabIndex = 18;
            // 
            // Min_t
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(304, 537);
            this.Controls.Add(this.uxMassText);
            this.Controls.Add(this.uxMass);
            this.Controls.Add(this.uxIDText);
            this.Controls.Add(this.uxF);
            this.Controls.Add(this.uxFText);
            this.Controls.Add(this.uxID);
            this.Controls.Add(this.uxFOStext);
            this.Controls.Add(this.uxFOS);
            this.Controls.Add(this.uxSyText);
            this.Controls.Add(this.uxL2Text);
            this.Controls.Add(this.uxL1Text);
            this.Controls.Add(this.uxODText);
            this.Controls.Add(this.uxCompute);
            this.Controls.Add(this.uxSy);
            this.Controls.Add(this.uxShortArmLength);
            this.Controls.Add(this.uxL1);
            this.Controls.Add(this.uxD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Min_t";
            this.Text = "min t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label uxD;
        private Label uxL1;
        private Label uxShortArmLength;
        private Label uxSy;
        private Button uxCompute;
        private TextBox uxODText;
        private TextBox uxL1Text;
        private TextBox uxL2Text; 
        private TextBox uxFText;
        private Label uxF;
        private TextBox uxSyText;
        private SaveFileDialog uxSaveFileDialog;
        private Label uxFOS;
        private TextBox uxFOStext;
        private Label uxID;
        private Label uxIDText;
        private Label uxMass;
        private Label uxMassText;
    }
}