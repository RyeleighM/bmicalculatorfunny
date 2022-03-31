namespace bmicalculatorfunny
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.weightEntry = new System.Windows.Forms.TextBox();
            this.heightEntry = new System.Windows.Forms.TextBox();
            this.ageEntry = new System.Windows.Forms.TextBox();
            this.targetEntry = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.genderMale = new System.Windows.Forms.CheckBox();
            this.genderFemale = new System.Windows.Forms.CheckBox();
            this.genderOther = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.weightMeasureKgTrue = new System.Windows.Forms.RadioButton();
            this.weightMeasureLbsTrue = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heightMeasureCmTrue = new System.Windows.Forms.RadioButton();
            this.heightMeasureInchTrue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(211, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(208, 45);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight";
            this.weightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(211, 71);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height";
            this.heightLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(223, 97);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            this.ageLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(207, 123);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "Gender";
            this.genderLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(186, 149);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(60, 13);
            this.targetLabel.TabIndex = 3;
            this.targetLabel.Text = "Target BMI";
            this.targetLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // weightEntry
            // 
            this.weightEntry.Location = new System.Drawing.Point(255, 42);
            this.weightEntry.Name = "weightEntry";
            this.weightEntry.Size = new System.Drawing.Size(100, 20);
            this.weightEntry.TabIndex = 7;
            this.weightEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // heightEntry
            // 
            this.heightEntry.Location = new System.Drawing.Point(255, 68);
            this.heightEntry.Name = "heightEntry";
            this.heightEntry.Size = new System.Drawing.Size(100, 20);
            this.heightEntry.TabIndex = 8;
            this.heightEntry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ageEntry
            // 
            this.ageEntry.Location = new System.Drawing.Point(255, 94);
            this.ageEntry.Name = "ageEntry";
            this.ageEntry.Size = new System.Drawing.Size(132, 20);
            this.ageEntry.TabIndex = 9;
            this.ageEntry.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // targetEntry
            // 
            this.targetEntry.Location = new System.Drawing.Point(255, 146);
            this.targetEntry.Name = "targetEntry";
            this.targetEntry.Size = new System.Drawing.Size(100, 20);
            this.targetEntry.TabIndex = 11;
            this.targetEntry.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(300, 172);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(77, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(217, 172);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save Entry";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.Location = new System.Drawing.Point(255, 122);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(49, 17);
            this.genderMale.TabIndex = 20;
            this.genderMale.Text = "Male";
            this.genderMale.UseVisualStyleBackColor = true;
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.Location = new System.Drawing.Point(310, 122);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(60, 17);
            this.genderFemale.TabIndex = 19;
            this.genderFemale.Text = "Female";
            this.genderFemale.UseVisualStyleBackColor = true;
            // 
            // genderOther
            // 
            this.genderOther.AutoSize = true;
            this.genderOther.Location = new System.Drawing.Point(376, 122);
            this.genderOther.Name = "genderOther";
            this.genderOther.Size = new System.Drawing.Size(52, 17);
            this.genderOther.TabIndex = 18;
            this.genderOther.Text = "Other";
            this.genderOther.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(459, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 183);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(236, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(255, 279);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(236, 20);
            this.textBox4.TabIndex = 27;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(255, 305);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(236, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(255, 332);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(236, 20);
            this.textBox6.TabIndex = 25;
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(255, 15);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(100, 20);
            this.nameEntry.TabIndex = 28;
            this.nameEntry.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Load History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightMeasureKgTrue
            // 
            this.weightMeasureKgTrue.AutoSize = true;
            this.weightMeasureKgTrue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.weightMeasureKgTrue.Checked = true;
            this.weightMeasureKgTrue.Location = new System.Drawing.Point(0, 1);
            this.weightMeasureKgTrue.Name = "weightMeasureKgTrue";
            this.weightMeasureKgTrue.Size = new System.Drawing.Size(37, 17);
            this.weightMeasureKgTrue.TabIndex = 30;
            this.weightMeasureKgTrue.TabStop = true;
            this.weightMeasureKgTrue.Text = "kg";
            this.weightMeasureKgTrue.UseVisualStyleBackColor = true;
            this.weightMeasureKgTrue.CheckedChanged += new System.EventHandler(this.weightMeasureKgTrue_CheckedChanged);
            // 
            // weightMeasureLbsTrue
            // 
            this.weightMeasureLbsTrue.AutoSize = true;
            this.weightMeasureLbsTrue.Location = new System.Drawing.Point(41, 1);
            this.weightMeasureLbsTrue.Name = "weightMeasureLbsTrue";
            this.weightMeasureLbsTrue.Size = new System.Drawing.Size(38, 17);
            this.weightMeasureLbsTrue.TabIndex = 31;
            this.weightMeasureLbsTrue.Text = "lbs";
            this.weightMeasureLbsTrue.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightMeasureKgTrue);
            this.groupBox1.Controls.Add(this.weightMeasureLbsTrue);
            this.groupBox1.Location = new System.Drawing.Point(361, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 21);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // heightMeasureCmTrue
            // 
            this.heightMeasureCmTrue.AutoSize = true;
            this.heightMeasureCmTrue.Location = new System.Drawing.Point(1, 1);
            this.heightMeasureCmTrue.Name = "heightMeasureCmTrue";
            this.heightMeasureCmTrue.Size = new System.Drawing.Size(39, 17);
            this.heightMeasureCmTrue.TabIndex = 32;
            this.heightMeasureCmTrue.Text = "cm";
            this.heightMeasureCmTrue.UseVisualStyleBackColor = true;
            // 
            // heightMeasureInchTrue
            // 
            this.heightMeasureInchTrue.AutoSize = true;
            this.heightMeasureInchTrue.Location = new System.Drawing.Point(44, 1);
            this.heightMeasureInchTrue.Name = "heightMeasureInchTrue";
            this.heightMeasureInchTrue.Size = new System.Drawing.Size(45, 17);
            this.heightMeasureInchTrue.TabIndex = 33;
            this.heightMeasureInchTrue.Text = "inch";
            this.heightMeasureInchTrue.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.heightMeasureInchTrue);
            this.groupBox2.Controls.Add(this.heightMeasureCmTrue);
            this.groupBox2.Location = new System.Drawing.Point(361, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 17);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Distance of weight to reach target BMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Distance of weight from healthy range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "BMI Classification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.genderMale);
            this.Controls.Add(this.genderFemale);
            this.Controls.Add(this.genderOther);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.targetEntry);
            this.Controls.Add(this.ageEntry);
            this.Controls.Add(this.heightEntry);
            this.Controls.Add(this.weightEntry);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox weightEntry;
        private System.Windows.Forms.TextBox heightEntry;
        private System.Windows.Forms.TextBox ageEntry;
        private System.Windows.Forms.TextBox targetEntry;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox genderMale;
        private System.Windows.Forms.CheckBox genderFemale;
        private System.Windows.Forms.CheckBox genderOther;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton weightMeasureKgTrue;
        private System.Windows.Forms.RadioButton weightMeasureLbsTrue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton heightMeasureCmTrue;
        private System.Windows.Forms.RadioButton heightMeasureInchTrue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

