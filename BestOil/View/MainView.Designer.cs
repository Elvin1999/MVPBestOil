
namespace BestOil.View
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.literRadiobtn = new System.Windows.Forms.RadioButton();
            this.literMaskettxtb = new System.Windows.Forms.MaskedTextBox();
            this.aznMaskedTxtb = new System.Windows.Forms.MaskedTextBox();
            this.aznRadiobtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.aznMaskedTxtb);
            this.groupBox1.Controls.Add(this.aznRadiobtn);
            this.groupBox1.Controls.Add(this.literMaskettxtb);
            this.groupBox1.Controls.Add(this.literRadiobtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(37, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gasoline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(105, 108);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(25, 25);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "AZN";
            // 
            // literRadiobtn
            // 
            this.literRadiobtn.AutoSize = true;
            this.literRadiobtn.Location = new System.Drawing.Point(24, 178);
            this.literRadiobtn.Name = "literRadiobtn";
            this.literRadiobtn.Size = new System.Drawing.Size(77, 29);
            this.literRadiobtn.TabIndex = 5;
            this.literRadiobtn.TabStop = true;
            this.literRadiobtn.Text = "Liter";
            this.literRadiobtn.UseVisualStyleBackColor = true;
            this.literRadiobtn.CheckedChanged += new System.EventHandler(this.literRadiobtn_CheckedChanged);
            // 
            // literMaskettxtb
            // 
            this.literMaskettxtb.Enabled = false;
            this.literMaskettxtb.Location = new System.Drawing.Point(107, 178);
            this.literMaskettxtb.Mask = "00000";
            this.literMaskettxtb.Name = "literMaskettxtb";
            this.literMaskettxtb.Size = new System.Drawing.Size(100, 31);
            this.literMaskettxtb.TabIndex = 6;
            this.literMaskettxtb.ValidatingType = typeof(int);
            // 
            // aznMaskedTxtb
            // 
            this.aznMaskedTxtb.Enabled = false;
            this.aznMaskedTxtb.Location = new System.Drawing.Point(107, 215);
            this.aznMaskedTxtb.Mask = "00000";
            this.aznMaskedTxtb.Name = "aznMaskedTxtb";
            this.aznMaskedTxtb.Size = new System.Drawing.Size(100, 31);
            this.aznMaskedTxtb.TabIndex = 8;
            this.aznMaskedTxtb.ValidatingType = typeof(int);
            // 
            // aznRadiobtn
            // 
            this.aznRadiobtn.AutoSize = true;
            this.aznRadiobtn.Location = new System.Drawing.Point(24, 215);
            this.aznRadiobtn.Name = "aznRadiobtn";
            this.aznRadiobtn.Size = new System.Drawing.Size(75, 29);
            this.aznRadiobtn.TabIndex = 7;
            this.aznRadiobtn.TabStop = true;
            this.aznRadiobtn.Text = "AZN";
            this.aznRadiobtn.UseVisualStyleBackColor = true;
            this.aznRadiobtn.CheckedChanged += new System.EventHandler(this.aznRadiobtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "azn";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLbl.Location = new System.Drawing.Point(103, 286);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(37, 39);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "0";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateBtn.Location = new System.Drawing.Point(37, 437);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(309, 54);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1113, 530);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox aznMaskedTxtb;
        private System.Windows.Forms.RadioButton aznRadiobtn;
        private System.Windows.Forms.MaskedTextBox literMaskettxtb;
        private System.Windows.Forms.RadioButton literRadiobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBtn;
    }
}