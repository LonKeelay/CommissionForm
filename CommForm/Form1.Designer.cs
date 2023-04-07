
namespace CommForm
{
    partial class frmSelector
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
            this.txtLinColSh = new System.Windows.Forms.ComboBox();
            this.txtHeadHalfFull = new System.Windows.Forms.ComboBox();
            this.lblExtent = new System.Windows.Forms.Label();
            this.lblBodyType = new System.Windows.Forms.Label();
            this.chkNSFW = new System.Windows.Forms.CheckBox();
            this.numHeads = new System.Windows.Forms.NumericUpDown();
            this.numHalfs = new System.Windows.Forms.NumericUpDown();
            this.numFulls = new System.Windows.Forms.NumericUpDown();
            this.lblExHead = new System.Windows.Forms.Label();
            this.lblExHalf = new System.Windows.Forms.Label();
            this.lblExBod = new System.Windows.Forms.Label();
            this.lblFinPrice = new System.Windows.Forms.Label();
            this.numBackground = new System.Windows.Forms.NumericUpDown();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblHeadMod = new System.Windows.Forms.Label();
            this.lblHalfMod = new System.Windows.Forms.Label();
            this.lblFullMod = new System.Windows.Forms.Label();
            this.lblNSFW = new System.Windows.Forms.Label();
            this.chkBackground = new System.Windows.Forms.CheckBox();
            this.lblFinPriceNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFulls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLinColSh
            // 
            this.txtLinColSh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLinColSh.FormattingEnabled = true;
            this.txtLinColSh.Items.AddRange(new object[] {
            "Lined",
            "Colored",
            "Shaded"});
            this.txtLinColSh.Location = new System.Drawing.Point(113, 12);
            this.txtLinColSh.Name = "txtLinColSh";
            this.txtLinColSh.Size = new System.Drawing.Size(88, 21);
            this.txtLinColSh.TabIndex = 1;
            this.txtLinColSh.SelectedIndexChanged += new System.EventHandler(this.txtLinColSh_SelectedIndexChanged);
            // 
            // txtHeadHalfFull
            // 
            this.txtHeadHalfFull.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHeadHalfFull.FormattingEnabled = true;
            this.txtHeadHalfFull.Items.AddRange(new object[] {
            "Headshot",
            "Half Body",
            "Full Body"});
            this.txtHeadHalfFull.Location = new System.Drawing.Point(113, 40);
            this.txtHeadHalfFull.Name = "txtHeadHalfFull";
            this.txtHeadHalfFull.Size = new System.Drawing.Size(88, 21);
            this.txtHeadHalfFull.TabIndex = 2;
            this.txtHeadHalfFull.SelectedIndexChanged += new System.EventHandler(this.updateHandler);
            // 
            // lblExtent
            // 
            this.lblExtent.Location = new System.Drawing.Point(12, 12);
            this.lblExtent.Name = "lblExtent";
            this.lblExtent.Size = new System.Drawing.Size(95, 21);
            this.lblExtent.TabIndex = 3;
            this.lblExtent.Text = "Extent:";
            this.lblExtent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBodyType
            // 
            this.lblBodyType.Location = new System.Drawing.Point(12, 39);
            this.lblBodyType.Name = "lblBodyType";
            this.lblBodyType.Size = new System.Drawing.Size(95, 21);
            this.lblBodyType.TabIndex = 4;
            this.lblBodyType.Text = "Body Type:";
            this.lblBodyType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkNSFW
            // 
            this.chkNSFW.Location = new System.Drawing.Point(15, 144);
            this.chkNSFW.Name = "chkNSFW";
            this.chkNSFW.Size = new System.Drawing.Size(92, 20);
            this.chkNSFW.TabIndex = 5;
            this.chkNSFW.Text = "NSFW (20%)";
            this.chkNSFW.UseVisualStyleBackColor = true;
            this.chkNSFW.CheckedChanged += new System.EventHandler(this.updateHandler);
            // 
            // numHeads
            // 
            this.numHeads.Location = new System.Drawing.Point(113, 66);
            this.numHeads.Name = "numHeads";
            this.numHeads.Size = new System.Drawing.Size(88, 20);
            this.numHeads.TabIndex = 6;
            this.numHeads.ValueChanged += new System.EventHandler(this.updateHandler);
            // 
            // numHalfs
            // 
            this.numHalfs.Location = new System.Drawing.Point(113, 92);
            this.numHalfs.Name = "numHalfs";
            this.numHalfs.Size = new System.Drawing.Size(88, 20);
            this.numHalfs.TabIndex = 7;
            this.numHalfs.ValueChanged += new System.EventHandler(this.updateHandler);
            // 
            // numFulls
            // 
            this.numFulls.Location = new System.Drawing.Point(113, 118);
            this.numFulls.Name = "numFulls";
            this.numFulls.Size = new System.Drawing.Size(88, 20);
            this.numFulls.TabIndex = 8;
            this.numFulls.ValueChanged += new System.EventHandler(this.updateHandler);
            // 
            // lblExHead
            // 
            this.lblExHead.Location = new System.Drawing.Point(12, 67);
            this.lblExHead.Name = "lblExHead";
            this.lblExHead.Size = new System.Drawing.Size(95, 19);
            this.lblExHead.TabIndex = 9;
            this.lblExHead.Text = "Extra Headshots:";
            this.lblExHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExHalf
            // 
            this.lblExHalf.Location = new System.Drawing.Point(12, 92);
            this.lblExHalf.Name = "lblExHalf";
            this.lblExHalf.Size = new System.Drawing.Size(95, 20);
            this.lblExHalf.TabIndex = 10;
            this.lblExHalf.Text = "Extra Half Bodies:";
            this.lblExHalf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExBod
            // 
            this.lblExBod.Location = new System.Drawing.Point(12, 118);
            this.lblExBod.Name = "lblExBod";
            this.lblExBod.Size = new System.Drawing.Size(95, 20);
            this.lblExBod.TabIndex = 11;
            this.lblExBod.Text = "Extra Full Bodies:";
            this.lblExBod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinPrice
            // 
            this.lblFinPrice.Location = new System.Drawing.Point(12, 199);
            this.lblFinPrice.Name = "lblFinPrice";
            this.lblFinPrice.Size = new System.Drawing.Size(65, 23);
            this.lblFinPrice.TabIndex = 12;
            this.lblFinPrice.Text = "Final Price: ";
            this.lblFinPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBackground
            // 
            this.numBackground.Location = new System.Drawing.Point(210, 170);
            this.numBackground.Name = "numBackground";
            this.numBackground.Size = new System.Drawing.Size(53, 20);
            this.numBackground.TabIndex = 14;
            this.numBackground.ValueChanged += new System.EventHandler(this.updateHandler);
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Location = new System.Drawing.Point(207, 38);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(56, 22);
            this.lblBasePrice.TabIndex = 15;
            this.lblBasePrice.Text = "$";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeadMod
            // 
            this.lblHeadMod.Location = new System.Drawing.Point(207, 66);
            this.lblHeadMod.Name = "lblHeadMod";
            this.lblHeadMod.Size = new System.Drawing.Size(56, 19);
            this.lblHeadMod.TabIndex = 16;
            this.lblHeadMod.Text = "+$";
            this.lblHeadMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHalfMod
            // 
            this.lblHalfMod.Location = new System.Drawing.Point(207, 92);
            this.lblHalfMod.Name = "lblHalfMod";
            this.lblHalfMod.Size = new System.Drawing.Size(56, 20);
            this.lblHalfMod.TabIndex = 17;
            this.lblHalfMod.Text = "+$";
            this.lblHalfMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullMod
            // 
            this.lblFullMod.Location = new System.Drawing.Point(207, 118);
            this.lblFullMod.Name = "lblFullMod";
            this.lblFullMod.Size = new System.Drawing.Size(56, 20);
            this.lblFullMod.TabIndex = 18;
            this.lblFullMod.Text = "+$";
            this.lblFullMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNSFW
            // 
            this.lblNSFW.Location = new System.Drawing.Point(207, 145);
            this.lblNSFW.Name = "lblNSFW";
            this.lblNSFW.Size = new System.Drawing.Size(56, 17);
            this.lblNSFW.TabIndex = 19;
            this.lblNSFW.Text = "+$";
            this.lblNSFW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkBackground
            // 
            this.chkBackground.Location = new System.Drawing.Point(15, 170);
            this.chkBackground.Name = "chkBackground";
            this.chkBackground.Size = new System.Drawing.Size(104, 17);
            this.chkBackground.TabIndex = 20;
            this.chkBackground.Text = "Background";
            this.chkBackground.UseVisualStyleBackColor = true;
            this.chkBackground.CheckedChanged += new System.EventHandler(this.chkBackground_CheckedChanged);
            // 
            // lblFinPriceNum
            // 
            this.lblFinPriceNum.Location = new System.Drawing.Point(207, 199);
            this.lblFinPriceNum.Name = "lblFinPriceNum";
            this.lblFinPriceNum.Size = new System.Drawing.Size(56, 22);
            this.lblFinPriceNum.TabIndex = 21;
            this.lblFinPriceNum.Text = "$";
            this.lblFinPriceNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 238);
            this.Controls.Add(this.lblFinPriceNum);
            this.Controls.Add(this.chkBackground);
            this.Controls.Add(this.lblNSFW);
            this.Controls.Add(this.lblFullMod);
            this.Controls.Add(this.lblHalfMod);
            this.Controls.Add(this.lblHeadMod);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.numBackground);
            this.Controls.Add(this.lblFinPrice);
            this.Controls.Add(this.lblExBod);
            this.Controls.Add(this.lblExHalf);
            this.Controls.Add(this.lblExHead);
            this.Controls.Add(this.numFulls);
            this.Controls.Add(this.numHalfs);
            this.Controls.Add(this.numHeads);
            this.Controls.Add(this.chkNSFW);
            this.Controls.Add(this.lblBodyType);
            this.Controls.Add(this.lblExtent);
            this.Controls.Add(this.txtHeadHalfFull);
            this.Controls.Add(this.txtLinColSh);
            this.Name = "frmSelector";
            this.Text = "Comm Calculator";
            this.Load += new System.EventHandler(this.frmSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFulls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtLinColSh;
        private System.Windows.Forms.ComboBox txtHeadHalfFull;
        private System.Windows.Forms.Label lblExtent;
        private System.Windows.Forms.Label lblBodyType;
        private System.Windows.Forms.CheckBox chkNSFW;
        private System.Windows.Forms.NumericUpDown numHeads;
        private System.Windows.Forms.NumericUpDown numHalfs;
        private System.Windows.Forms.NumericUpDown numFulls;
        private System.Windows.Forms.Label lblExHead;
        private System.Windows.Forms.Label lblExHalf;
        private System.Windows.Forms.Label lblExBod;
        private System.Windows.Forms.Label lblFinPrice;
        private System.Windows.Forms.NumericUpDown numBackground;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblHeadMod;
        private System.Windows.Forms.Label lblHalfMod;
        private System.Windows.Forms.Label lblFullMod;
        private System.Windows.Forms.Label lblNSFW;
        private System.Windows.Forms.CheckBox chkBackground;
        private System.Windows.Forms.Label lblFinPriceNum;
    }
}

