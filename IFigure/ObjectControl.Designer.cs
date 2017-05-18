namespace Figure
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxStartX = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartY = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartZ = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxRadius = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHeigth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxA = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxH = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxStartZ);
            this.groupBox1.Controls.Add(this.maskedTextBoxStartY);
            this.groupBox1.Controls.Add(this.maskedTextBoxStartX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start coordinate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Z";
            // 
            // maskedTextBoxStartX
            // 
            this.maskedTextBoxStartX.Location = new System.Drawing.Point(70, 20);
            this.maskedTextBoxStartX.Mask = "___.__";
            this.maskedTextBoxStartX.Name = "maskedTextBoxStartX";
            this.maskedTextBoxStartX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartX.TabIndex = 3;
            // 
            // maskedTextBoxStartY
            // 
            this.maskedTextBoxStartY.Location = new System.Drawing.Point(70, 47);
            this.maskedTextBoxStartY.Mask = "___.__";
            this.maskedTextBoxStartY.Name = "maskedTextBoxStartY";
            this.maskedTextBoxStartY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartY.TabIndex = 4;
            // 
            // maskedTextBoxStartZ
            // 
            this.maskedTextBoxStartZ.Location = new System.Drawing.Point(70, 71);
            this.maskedTextBoxStartZ.Mask = "___.__";
            this.maskedTextBoxStartZ.Name = "maskedTextBoxStartZ";
            this.maskedTextBoxStartZ.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartZ.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxH);
            this.groupBox2.Controls.Add(this.maskedTextBoxA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.maskedTextBoxLength);
            this.groupBox2.Controls.Add(this.maskedTextBoxHeigth);
            this.groupBox2.Controls.Add(this.maskedTextBoxWidth);
            this.groupBox2.Controls.Add(this.maskedTextBoxRadius);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figures data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Heigth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Length";
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(54, 20);
            this.maskedTextBoxRadius.Mask = "___.__";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRadius.TabIndex = 4;
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(54, 46);
            this.maskedTextBoxWidth.Mask = "___.__";
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxWidth.TabIndex = 5;
            // 
            // maskedTextBoxHeigth
            // 
            this.maskedTextBoxHeigth.Location = new System.Drawing.Point(54, 72);
            this.maskedTextBoxHeigth.Mask = "___.__";
            this.maskedTextBoxHeigth.Name = "maskedTextBoxHeigth";
            this.maskedTextBoxHeigth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHeigth.TabIndex = 6;
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Location = new System.Drawing.Point(54, 98);
            this.maskedTextBoxLength.Mask = "___.__";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxLength.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "_A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "_H";
            // 
            // maskedTextBoxA
            // 
            this.maskedTextBoxA.Location = new System.Drawing.Point(220, 24);
            this.maskedTextBoxA.Mask = "___.__";
            this.maskedTextBoxA.Name = "maskedTextBoxA";
            this.maskedTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxA.TabIndex = 11;
            // 
            // maskedTextBoxH
            // 
            this.maskedTextBoxH.Location = new System.Drawing.Point(220, 53);
            this.maskedTextBoxH.Mask = "___.__";
            this.maskedTextBoxH.Name = "maskedTextBoxH";
            this.maskedTextBoxH.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxH.TabIndex = 12;
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Items.AddRange(new object[] {
            "Шар",
            "Параллелипипед",
            "Пирамида"});
            this.comboBoxFigures.Location = new System.Drawing.Point(279, 3);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigures.TabIndex = 2;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(445, 272);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartZ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeigth;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxH;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxA;
        private System.Windows.Forms.ComboBox comboBoxFigures;
    }
}
