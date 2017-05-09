namespace Figure
{
    partial class FigureForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxStart_coordinate = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxStartZ = new System.Windows.Forms.MaskedTextBox();
            this.labelStart_Z = new System.Windows.Forms.Label();
            this.maskedTextBoxStartY = new System.Windows.Forms.MaskedTextBox();
            this.labelStart_Y = new System.Windows.Forms.Label();
            this.maskedTextBoxStartX = new System.Windows.Forms.MaskedTextBox();
            this.labelStart_X = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxRadius = new System.Windows.Forms.MaskedTextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.maskedTextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.labelheight = new System.Windows.Forms.Label();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxH = new System.Windows.Forms.MaskedTextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.maskedTextBoxA = new System.Windows.Forms.MaskedTextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.errorProviderX = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderY = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRadius = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderH = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxCountVolume = new System.Windows.Forms.TextBox();
            this.buttonCount_Volume = new System.Windows.Forms.Button();
            this.groupBoxStart_coordinate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderH)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStart_coordinate
            // 
            this.groupBoxStart_coordinate.Controls.Add(this.maskedTextBoxStartZ);
            this.groupBoxStart_coordinate.Controls.Add(this.labelStart_Z);
            this.groupBoxStart_coordinate.Controls.Add(this.maskedTextBoxStartY);
            this.groupBoxStart_coordinate.Controls.Add(this.labelStart_Y);
            this.groupBoxStart_coordinate.Controls.Add(this.maskedTextBoxStartX);
            this.groupBoxStart_coordinate.Controls.Add(this.labelStart_X);
            this.groupBoxStart_coordinate.Location = new System.Drawing.Point(27, 26);
            this.groupBoxStart_coordinate.Name = "groupBoxStart_coordinate";
            this.groupBoxStart_coordinate.Size = new System.Drawing.Size(184, 135);
            this.groupBoxStart_coordinate.TabIndex = 1;
            this.groupBoxStart_coordinate.TabStop = false;
            this.groupBoxStart_coordinate.Text = "Start coordinate";
            // 
            // maskedTextBoxStartZ
            // 
            this.maskedTextBoxStartZ.Location = new System.Drawing.Point(66, 104);
            this.maskedTextBoxStartZ.Mask = "099.0";
            this.maskedTextBoxStartZ.Name = "maskedTextBoxStartZ";
            this.maskedTextBoxStartZ.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartZ.TabIndex = 5;
            this.maskedTextBoxStartZ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxStartZ_MouseClick);
            this.maskedTextBoxStartZ.Leave += new System.EventHandler(this.maskedTextBoxStartZ_Leave);
            // 
            // labelStart_Z
            // 
            this.labelStart_Z.AutoSize = true;
            this.labelStart_Z.Location = new System.Drawing.Point(6, 104);
            this.labelStart_Z.Name = "labelStart_Z";
            this.labelStart_Z.Size = new System.Drawing.Size(39, 13);
            this.labelStart_Z.TabIndex = 4;
            this.labelStart_Z.Text = "Start Z";
            // 
            // maskedTextBoxStartY
            // 
            this.maskedTextBoxStartY.Location = new System.Drawing.Point(66, 66);
            this.maskedTextBoxStartY.Mask = "099.0";
            this.maskedTextBoxStartY.Name = "maskedTextBoxStartY";
            this.maskedTextBoxStartY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartY.TabIndex = 3;
            this.maskedTextBoxStartY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxStartY_MouseClick);
            this.maskedTextBoxStartY.Leave += new System.EventHandler(this.maskedTextBoxStartY_Leave);
            // 
            // labelStart_Y
            // 
            this.labelStart_Y.AutoSize = true;
            this.labelStart_Y.Location = new System.Drawing.Point(6, 66);
            this.labelStart_Y.Name = "labelStart_Y";
            this.labelStart_Y.Size = new System.Drawing.Size(39, 13);
            this.labelStart_Y.TabIndex = 2;
            this.labelStart_Y.Text = "Start Y";
            // 
            // maskedTextBoxStartX
            // 
            this.maskedTextBoxStartX.Location = new System.Drawing.Point(66, 30);
            this.maskedTextBoxStartX.Mask = "099.0";
            this.maskedTextBoxStartX.Name = "maskedTextBoxStartX";
            this.maskedTextBoxStartX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartX.TabIndex = 1;
            this.maskedTextBoxStartX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxStartX_MouseClick);
            this.maskedTextBoxStartX.Leave += new System.EventHandler(this.maskedTextBoxStartX_Leave);
            // 
            // labelStart_X
            // 
            this.labelStart_X.AutoSize = true;
            this.labelStart_X.Location = new System.Drawing.Point(6, 30);
            this.labelStart_X.Name = "labelStart_X";
            this.labelStart_X.Size = new System.Drawing.Size(39, 13);
            this.labelStart_X.TabIndex = 0;
            this.labelStart_X.Text = "Start X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxRadius);
            this.groupBox1.Controls.Add(this.labelRadius);
            this.groupBox1.Location = new System.Drawing.Point(246, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ball";
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(59, 27);
            this.maskedTextBoxRadius.Mask = "099.0";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRadius.TabIndex = 1;
            this.maskedTextBoxRadius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxRadius_MouseClick_1);
            this.maskedTextBoxRadius.Leave += new System.EventHandler(this.maskedTextBoxRadius_Leave_1);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(6, 27);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(40, 13);
            this.labelRadius.TabIndex = 0;
            this.labelRadius.Text = "Radius";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBoxLength);
            this.groupBox2.Controls.Add(this.labelLength);
            this.groupBox2.Controls.Add(this.maskedTextBoxHeight);
            this.groupBox2.Controls.Add(this.labelheight);
            this.groupBox2.Controls.Add(this.maskedTextBoxWidth);
            this.groupBox2.Controls.Add(this.labelWidth);
            this.groupBox2.Location = new System.Drawing.Point(27, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parallelepiped";
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Location = new System.Drawing.Point(66, 98);
            this.maskedTextBoxLength.Mask = "099.0";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxLength.TabIndex = 5;
            this.maskedTextBoxLength.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxLength_MouseClick_1);
            this.maskedTextBoxLength.Leave += new System.EventHandler(this.maskedTextBoxLength_Leave_1);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(6, 98);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 13);
            this.labelLength.TabIndex = 4;
            this.labelLength.Text = "Length";
            // 
            // maskedTextBoxHeight
            // 
            this.maskedTextBoxHeight.Location = new System.Drawing.Point(66, 69);
            this.maskedTextBoxHeight.Mask = "099.0";
            this.maskedTextBoxHeight.Name = "maskedTextBoxHeight";
            this.maskedTextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHeight.TabIndex = 3;
            this.maskedTextBoxHeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxHeight_MouseClick_1);
            this.maskedTextBoxHeight.Leave += new System.EventHandler(this.maskedTextBoxHeight_Leave_1);
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Location = new System.Drawing.Point(6, 69);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(38, 13);
            this.labelheight.TabIndex = 2;
            this.labelheight.Text = "Height";
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(66, 35);
            this.maskedTextBoxWidth.Mask = "099.0";
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxWidth.TabIndex = 1;
            this.maskedTextBoxWidth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxWidth_MouseClick_1);
            this.maskedTextBoxWidth.Leave += new System.EventHandler(this.maskedTextBoxWidth_Leave_1);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(9, 35);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBoxH);
            this.groupBox3.Controls.Add(this.labelH);
            this.groupBox3.Controls.Add(this.maskedTextBoxA);
            this.groupBox3.Controls.Add(this.labelA);
            this.groupBox3.Location = new System.Drawing.Point(246, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 89);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pyramid";
            // 
            // maskedTextBoxH
            // 
            this.maskedTextBoxH.Location = new System.Drawing.Point(51, 43);
            this.maskedTextBoxH.Mask = "099.0";
            this.maskedTextBoxH.Name = "maskedTextBoxH";
            this.maskedTextBoxH.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxH.TabIndex = 3;
            this.maskedTextBoxH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxH_MouseClick_1);
            this.maskedTextBoxH.Leave += new System.EventHandler(this.maskedTextBoxH_Leave_1);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(6, 51);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(21, 13);
            this.labelH.TabIndex = 2;
            this.labelH.Text = "_H";
            // 
            // maskedTextBoxA
            // 
            this.maskedTextBoxA.Location = new System.Drawing.Point(51, 13);
            this.maskedTextBoxA.Mask = "999.0";
            this.maskedTextBoxA.Name = "maskedTextBoxA";
            this.maskedTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxA.TabIndex = 1;
            this.maskedTextBoxA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxA_MouseClick_1);
            this.maskedTextBoxA.Leave += new System.EventHandler(this.maskedTextBoxA_Leave_1);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(7, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "_A";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCancel);
            this.groupBox4.Controls.Add(this.buttonOK);
            this.groupBox4.Controls.Add(this.buttonRandom);
            this.groupBox4.Location = new System.Drawing.Point(27, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 49);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Button";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(327, 17);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(228, 17);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(12, 20);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(121, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Items.AddRange(new object[] {
            "Шар",
            "Параллелипипед",
            "Пирамида"});
            this.comboBoxFigures.Location = new System.Drawing.Point(439, 26);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigures.TabIndex = 6;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigures_SelectedIndexChanged);
            // 
            // errorProviderX
            // 
            this.errorProviderX.ContainerControl = this;
            // 
            // errorProviderY
            // 
            this.errorProviderY.ContainerControl = this;
            // 
            // errorProviderZ
            // 
            this.errorProviderZ.ContainerControl = this;
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this;
            // 
            // errorProviderHeight
            // 
            this.errorProviderHeight.ContainerControl = this;
            // 
            // errorProviderLength
            // 
            this.errorProviderLength.ContainerControl = this;
            // 
            // errorProviderRadius
            // 
            this.errorProviderRadius.ContainerControl = this;
            // 
            // errorProviderA
            // 
            this.errorProviderA.ContainerControl = this;
            // 
            // errorProviderH
            // 
            this.errorProviderH.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxCountVolume);
            this.groupBox5.Controls.Add(this.buttonCount_Volume);
            this.groupBox5.Location = new System.Drawing.Point(246, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 48);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Count Volume";
            // 
            // textBoxCountVolume
            // 
            this.textBoxCountVolume.Location = new System.Drawing.Point(106, 19);
            this.textBoxCountVolume.Name = "textBoxCountVolume";
            this.textBoxCountVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountVolume.TabIndex = 1;
            // 
            // buttonCount_Volume
            // 
            this.buttonCount_Volume.Location = new System.Drawing.Point(6, 19);
            this.buttonCount_Volume.Name = "buttonCount_Volume";
            this.buttonCount_Volume.Size = new System.Drawing.Size(94, 23);
            this.buttonCount_Volume.TabIndex = 0;
            this.buttonCount_Volume.Text = "Count Volume";
            this.buttonCount_Volume.UseVisualStyleBackColor = true;
            this.buttonCount_Volume.Click += new System.EventHandler(this.buttonCount_Volume_Click);
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(581, 379);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStart_coordinate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.groupBoxStart_coordinate.ResumeLayout(false);
            this.groupBoxStart_coordinate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderH)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStart_coordinate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartZ;
        private System.Windows.Forms.Label labelStart_Z;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartY;
        private System.Windows.Forms.Label labelStart_Y;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartX;
        private System.Windows.Forms.Label labelStart_X;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeight;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.ErrorProvider errorProviderX;
        private System.Windows.Forms.ErrorProvider errorProviderY;
        private System.Windows.Forms.ErrorProvider errorProviderZ;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.ErrorProvider errorProviderHeight;
        private System.Windows.Forms.ErrorProvider errorProviderLength;
        private System.Windows.Forms.ErrorProvider errorProviderRadius;
        private System.Windows.Forms.ErrorProvider errorProviderA;
        private System.Windows.Forms.ErrorProvider errorProviderH;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCount_Volume;
        private System.Windows.Forms.TextBox textBoxCountVolume;
    }
}