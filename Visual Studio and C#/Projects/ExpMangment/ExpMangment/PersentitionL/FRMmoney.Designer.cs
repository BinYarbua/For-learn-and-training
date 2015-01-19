namespace ExpMangment.PersentitionL
{
    partial class FRMCurrency
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
            this.txtExchangPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIsMainCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSimlpeEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSimpleAR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameOfCurrencyEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameOfCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtExchangPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbIsMainCurrency);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSimlpeEN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSimpleAR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameOfCurrencyEN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameOfCurrency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(111, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بياتان العملة ";
            // 
            // txtExchangPrice
            // 
            this.txtExchangPrice.Location = new System.Drawing.Point(84, 60);
            this.txtExchangPrice.Name = "txtExchangPrice";
            this.txtExchangPrice.Size = new System.Drawing.Size(121, 20);
            this.txtExchangPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "سعر الصرف مقابل العملة الاساسية:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(19, 95);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(186, 54);
            this.txtNote.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ملاحظة:";
            // 
            // cmbIsMainCurrency
            // 
            this.cmbIsMainCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsMainCurrency.FormattingEnabled = true;
            this.cmbIsMainCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbIsMainCurrency.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbIsMainCurrency.Location = new System.Drawing.Point(114, 26);
            this.cmbIsMainCurrency.Name = "cmbIsMainCurrency";
            this.cmbIsMainCurrency.Size = new System.Drawing.Size(91, 21);
            this.cmbIsMainCurrency.Sorted = true;
            this.cmbIsMainCurrency.TabIndex = 4;
            this.cmbIsMainCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbIsMainCurrency_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "تحديد كعملة اساسية:";
            // 
            // txtSimlpeEN
            // 
            this.txtSimlpeEN.Location = new System.Drawing.Point(430, 132);
            this.txtSimlpeEN.Name = "txtSimlpeEN";
            this.txtSimlpeEN.Size = new System.Drawing.Size(120, 20);
            this.txtSimlpeEN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "الرمز الاجنبي:";
            // 
            // txtSimpleAR
            // 
            this.txtSimpleAR.Location = new System.Drawing.Point(430, 64);
            this.txtSimpleAR.Name = "txtSimpleAR";
            this.txtSimpleAR.Size = new System.Drawing.Size(120, 20);
            this.txtSimpleAR.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "الرمز العربي:";
            // 
            // txtNameOfCurrencyEN
            // 
            this.txtNameOfCurrencyEN.Location = new System.Drawing.Point(364, 99);
            this.txtNameOfCurrencyEN.Name = "txtNameOfCurrencyEN";
            this.txtNameOfCurrencyEN.Size = new System.Drawing.Size(186, 20);
            this.txtNameOfCurrencyEN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الاسم الاجنبي:";
            // 
            // txtNameOfCurrency
            // 
            this.txtNameOfCurrency.Location = new System.Drawing.Point(364, 27);
            this.txtNameOfCurrency.Name = "txtNameOfCurrency";
            this.txtNameOfCurrency.Size = new System.Drawing.Size(186, 20);
            this.txtNameOfCurrency.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العملة :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(243, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "العملة الاساسية للبرنامج الحالية هي:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdata);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCencel);
            this.groupBox2.Location = new System.Drawing.Point(61, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 53);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::ExpMangment.Properties.Resources.Refreshicon;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(159, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "تح&ديث";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Image = global::ExpMangment.Properties.Resources.addicon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(588, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdata
            // 
            this.btnUpdata.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdata.Image = global::ExpMangment.Properties.Resources.editicon;
            this.btnUpdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdata.Location = new System.Drawing.Point(445, 12);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(135, 35);
            this.btnUpdata.TabIndex = 8;
            this.btnUpdata.Text = "&تعديل";
            this.btnUpdata.UseVisualStyleBackColor = true;
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::ExpMangment.Properties.Resources.deleteicon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(302, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCencel.Image = global::ExpMangment.Properties.Resources.ExitIcon;
            this.btnCencel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCencel.Location = new System.Drawing.Point(16, 12);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(135, 35);
            this.btnCencel.TabIndex = 11;
            this.btnCencel.Text = "&خروج";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(865, 238);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 219);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FRMCurrency
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCencel;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMCurrency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملات";
            this.Load += new System.EventHandler(this.FRMCurrency_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSimlpeEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSimpleAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameOfCurrencyEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameOfCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExchangPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIsMainCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
    }
}