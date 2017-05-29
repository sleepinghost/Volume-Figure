namespace Figure
{
    partial class FiguresControl
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
            this.maskedTextBoxStartZ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartY = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartX = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxH = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxA = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRadius = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start coordinate";
            // 
            // maskedTextBoxStartZ
            // 
            this.maskedTextBoxStartZ.Location = new System.Drawing.Point(71, 83);
            this.maskedTextBoxStartZ.Mask = "#90.009";
            this.maskedTextBoxStartZ.Name = "maskedTextBoxStartZ";
            this.maskedTextBoxStartZ.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartZ.TabIndex = 5;
            this.maskedTextBoxStartZ.TextChanged += new System.EventHandler(this.maskedTextBoxStartZ_TextChanged);
            // 
            // maskedTextBoxStartY
            // 
            this.maskedTextBoxStartY.Location = new System.Drawing.Point(71, 56);
            this.maskedTextBoxStartY.Mask = "#90.009";
            this.maskedTextBoxStartY.Name = "maskedTextBoxStartY";
            this.maskedTextBoxStartY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartY.TabIndex = 4;
            this.maskedTextBoxStartY.TextChanged += new System.EventHandler(this.maskedTextBoxStartY_TextChanged);
            // 
            // maskedTextBoxStartX
            // 
            this.maskedTextBoxStartX.Location = new System.Drawing.Point(71, 30);
            this.maskedTextBoxStartX.Mask = "#90.009";
            this.maskedTextBoxStartX.Name = "maskedTextBoxStartX";
            this.maskedTextBoxStartX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartX.TabIndex = 3;
            this.maskedTextBoxStartX.TextChanged += new System.EventHandler(this.maskedTextBoxStartX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxH);
            this.groupBox2.Controls.Add(this.maskedTextBoxA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(187, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pyramid";
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Location = new System.Drawing.Point(81, 60);
            this.maskedTextBoxLength.Mask = "#90.009";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxLength.TabIndex = 11;
            this.maskedTextBoxLength.TextChanged += new System.EventHandler(this.maskedTextBoxLength_TextChanged);
            // 
            // maskedTextBoxHeight
            // 
            this.maskedTextBoxHeight.Location = new System.Drawing.Point(81, 34);
            this.maskedTextBoxHeight.Mask = "#90.009";
            this.maskedTextBoxHeight.Name = "maskedTextBoxHeight";
            this.maskedTextBoxHeight.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxHeight.TabIndex = 10;
            this.maskedTextBoxHeight.TextChanged += new System.EventHandler(this.maskedTextBoxHeight_TextChanged);
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(81, 8);
            this.maskedTextBoxWidth.Mask = "#90.009";
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxWidth.TabIndex = 9;
            this.maskedTextBoxWidth.TextChanged += new System.EventHandler(this.maskedTextBoxWidth_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Length";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Height";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // maskedTextBoxH
            // 
            this.maskedTextBoxH.Location = new System.Drawing.Point(34, 59);
            this.maskedTextBoxH.Mask = "#90.009";
            this.maskedTextBoxH.Name = "maskedTextBoxH";
            this.maskedTextBoxH.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxH.TabIndex = 5;
            this.maskedTextBoxH.TextChanged += new System.EventHandler(this.maskedTextBoxH_TextChanged);
            // 
            // maskedTextBoxA
            // 
            this.maskedTextBoxA.Location = new System.Drawing.Point(34, 30);
            this.maskedTextBoxA.Mask = "#90.009";
            this.maskedTextBoxA.Name = "maskedTextBoxA";
            this.maskedTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxA.TabIndex = 4;
            this.maskedTextBoxA.TextChanged += new System.EventHandler(this.maskedTextBoxA_TextChanged);
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(61, 19);
            this.maskedTextBoxRadius.Mask = "#90.009";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBoxRadius.TabIndex = 3;
            this.maskedTextBoxRadius.TextChanged += new System.EventHandler(this.maskedTextBoxRadius_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "_H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "_A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius";
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Шар",
            "Пирамида",
            "Параллелепипед"});
            this.comboBoxFigure.Location = new System.Drawing.Point(220, 17);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigure.TabIndex = 2;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigure_SelectedIndexChanged);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(339, 264);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(69, 20);
            this.textBoxVolume.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(279, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Volume";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.maskedTextBoxRadius);
            this.groupBox3.Location = new System.Drawing.Point(0, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 87);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ball";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.maskedTextBoxLength);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.maskedTextBoxWidth);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.maskedTextBoxHeight);
            this.groupBox5.Location = new System.Drawing.Point(0, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 86);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parallelepiped";
            // 
            // FiguresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FiguresControl";
            this.Size = new System.Drawing.Size(412, 305);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartZ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeight;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxH;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
