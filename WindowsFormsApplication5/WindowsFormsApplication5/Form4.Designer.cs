namespace WindowsFormsApplication5
{
    partial class Form4
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtAccomadation = new System.Windows.Forms.TextBox();
            this.txtGFee = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Billid = new System.Windows.Forms.Label();
            this.txtFid = new System.Windows.Forms.TextBox();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.btncalculate);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Location = new System.Drawing.Point(36, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 101);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "This will show total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(237, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 17);
            this.label28.TabIndex = 39;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(432, 55);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(86, 26);
            this.btncalculate.TabIndex = 31;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 17);
            this.label24.TabIndex = 27;
            this.label24.Text = "Tax+Service charge";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(30, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 17);
            this.label27.TabIndex = 30;
            this.label27.Text = "Total";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(240, 21);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(235, 22);
            this.txtTax.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtTransport);
            this.groupBox1.Controls.Add(this.txtFood);
            this.groupBox1.Controls.Add(this.txtAccomadation);
            this.groupBox1.Controls.Add(this.txtGFee);
            this.groupBox1.Controls.Add(this.txtOther);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(37, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 282);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price list";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(26, 225);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 17);
            this.label26.TabIndex = 29;
            this.label26.Text = "Other";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(236, 106);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(235, 22);
            this.txtTickets.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 190);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 26;
            this.label23.Text = "Guide";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "Accomadation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Ticket";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(236, 21);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(235, 22);
            this.txtTransport.TabIndex = 33;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(236, 65);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(235, 22);
            this.txtFood.TabIndex = 34;
            // 
            // txtAccomadation
            // 
            this.txtAccomadation.Location = new System.Drawing.Point(236, 150);
            this.txtAccomadation.Name = "txtAccomadation";
            this.txtAccomadation.Size = new System.Drawing.Size(235, 22);
            this.txtAccomadation.TabIndex = 35;
            // 
            // txtGFee
            // 
            this.txtGFee.Location = new System.Drawing.Point(236, 190);
            this.txtGFee.Name = "txtGFee";
            this.txtGFee.Size = new System.Drawing.Size(235, 22);
            this.txtGFee.TabIndex = 36;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(236, 225);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(235, 22);
            this.txtOther.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Transport";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Food";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(432, 55);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(86, 23);
            this.btncheck.TabIndex = 159;
            this.btncheck.Text = "check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(243, 16);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(235, 22);
            this.txtAdvance.TabIndex = 157;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 156;
            this.label19.Text = "balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 155;
            this.label11.Text = "Advance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btncheck);
            this.groupBox3.Controls.Add(this.txtAdvance);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(36, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 104);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 160;
            this.label3.Text = "this will show your balance";
            // 
            // Billid
            // 
            this.Billid.AutoSize = true;
            this.Billid.Location = new System.Drawing.Point(63, 40);
            this.Billid.Name = "Billid";
            this.Billid.Size = new System.Drawing.Size(79, 17);
            this.Billid.TabIndex = 176;
            this.Billid.Text = "Financial id";
            // 
            // txtFid
            // 
            this.txtFid.Location = new System.Drawing.Point(273, 40);
            this.txtFid.Name = "txtFid";
            this.txtFid.Size = new System.Drawing.Size(235, 22);
            this.txtFid.TabIndex = 175;
            this.txtFid.TextChanged += new System.EventHandler(this.txtFid_TextChanged);
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(273, 80);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(235, 22);
            this.txtTid.TabIndex = 174;
            this.txtTid.TextChanged += new System.EventHandler(this.txtTid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 173;
            this.label1.Text = "Trip id";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(601, 202);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 37);
            this.btnclear.TabIndex = 181;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 39);
            this.btnExit.TabIndex = 180;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 179;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(601, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnUpdate.TabIndex = 178;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(601, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 39);
            this.btnSave.TabIndex = 177;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(822, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 180);
            this.groupBox4.TabIndex = 182;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(90, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(143, 658);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(109, 39);
            this.btnPrevious.TabIndex = 185;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(258, 658);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 39);
            this.btnNext.TabIndex = 184;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 396);
            this.dataGridView1.TabIndex = 183;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type your Financial id";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 773);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Billid);
            this.Controls.Add(this.txtFid);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtAccomadation;
        private System.Windows.Forms.TextBox txtGFee;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Billid;
        private System.Windows.Forms.TextBox txtFid;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}