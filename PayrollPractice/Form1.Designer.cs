namespace PayrollPractice
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxWrk = new System.Windows.Forms.TextBox();
            this.txtBxDpd = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.lblAgency = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtFed = new System.Windows.Forms.TextBox();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lading Holdings";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(106, 88);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(106, 152);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(195, 24);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "No. Hours Worked: ";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ForeColor = System.Drawing.Color.White;
            this.lblDep.Location = new System.Drawing.Point(106, 217);
            this.lblDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(197, 24);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "No. of Dependents: ";
            // 
            // btnCompute
            // 
            this.btnCompute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(188)))));
            this.btnCompute.Location = new System.Drawing.Point(160, 282);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(129, 70);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Calculate Take Home Pay";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(188)))));
            this.btnReset.Location = new System.Drawing.Point(408, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 37);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(241, 86);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(280, 26);
            this.txtBxName.TabIndex = 6;
            // 
            // txtBxWrk
            // 
            this.txtBxWrk.Location = new System.Drawing.Point(324, 150);
            this.txtBxWrk.Name = "txtBxWrk";
            this.txtBxWrk.Size = new System.Drawing.Size(195, 26);
            this.txtBxWrk.TabIndex = 7;
            // 
            // txtBxDpd
            // 
            this.txtBxDpd.Location = new System.Drawing.Point(324, 217);
            this.txtBxDpd.Name = "txtBxDpd";
            this.txtBxDpd.Size = new System.Drawing.Size(195, 26);
            this.txtBxDpd.TabIndex = 8;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(197, 427);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(101, 20);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross Pay: ";
            this.lblGross.Visible = false;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFed.Location = new System.Drawing.Point(178, 485);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(123, 20);
            this.lblFed.TabIndex = 10;
            this.lblFed.Text = "Federal Ded.: ";
            this.lblFed.Visible = false;
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoc.Location = new System.Drawing.Point(164, 545);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(124, 20);
            this.lblSoc.TabIndex = 11;
            this.lblSoc.Text = "Soc Sec Ded.:";
            this.lblSoc.Visible = false;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgency.Location = new System.Drawing.Point(176, 605);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(114, 20);
            this.lblAgency.TabIndex = 12;
            this.lblAgency.Text = "Agency Fee: ";
            this.lblAgency.Visible = false;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(208, 664);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(81, 20);
            this.lblNet.TabIndex = 13;
            this.lblNet.Text = "Net Pay: ";
            this.lblNet.Visible = false;
            // 
            // txtGross
            // 
            this.txtGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(352, 431);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(128, 26);
            this.txtGross.TabIndex = 14;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGross.Visible = false;
            this.txtGross.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFed
            // 
            this.txtFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFed.Location = new System.Drawing.Point(352, 485);
            this.txtFed.Name = "txtFed";
            this.txtFed.Size = new System.Drawing.Size(128, 26);
            this.txtFed.TabIndex = 15;
            this.txtFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFed.Visible = false;
            // 
            // txtSoc
            // 
            this.txtSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoc.Location = new System.Drawing.Point(352, 545);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(128, 26);
            this.txtSoc.TabIndex = 16;
            this.txtSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoc.Visible = false;
            // 
            // txtAgency
            // 
            this.txtAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgency.Location = new System.Drawing.Point(352, 605);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(128, 26);
            this.txtAgency.TabIndex = 17;
            this.txtAgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAgency.Visible = false;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(352, 664);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(128, 26);
            this.txtNet.TabIndex = 18;
            this.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(697, 750);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.txtSoc);
            this.Controls.Add(this.txtFed);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.lblSoc);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtBxDpd);
            this.Controls.Add(this.txtBxWrk);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxWrk;
        private System.Windows.Forms.TextBox txtBxDpd;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtFed;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.TextBox txtNet;
    }
}

