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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.errorProviderX = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderY = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRadius = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderH = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderH)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCancel.Location = new System.Drawing.Point(419, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOK.Location = new System.Drawing.Point(326, 331);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRandom.Location = new System.Drawing.Point(12, 331);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(121, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
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
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxEdit.Controls.Add(this.buttonCount);
            this.groupBoxEdit.Location = new System.Drawing.Point(13, 13);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(556, 312);
            this.groupBoxEdit.TabIndex = 6;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "EditForm";
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCount.Location = new System.Drawing.Point(209, 275);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(85, 31);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Count Volume";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(581, 379);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.buttonRandom);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FigureForm";
            this.Text = "AddFigureForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderH)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.ErrorProvider errorProviderX;
        private System.Windows.Forms.ErrorProvider errorProviderY;
        private System.Windows.Forms.ErrorProvider errorProviderZ;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.ErrorProvider errorProviderHeight;
        private System.Windows.Forms.ErrorProvider errorProviderLength;
        private System.Windows.Forms.ErrorProvider errorProviderRadius;
        private System.Windows.Forms.ErrorProvider errorProviderA;
        private System.Windows.Forms.ErrorProvider errorProviderH;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonCount;
    }
}