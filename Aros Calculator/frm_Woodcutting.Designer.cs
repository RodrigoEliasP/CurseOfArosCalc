namespace Aros_Calculator
{
    partial class frm_Woodcutting
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
            this.lsb_woods = new System.Windows.Forms.ListBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.lbl_required = new System.Windows.Forms.Label();
            this.lbl_XP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_desire = new System.Windows.Forms.TextBox();
            this.lbl_desire = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_percentage = new System.Windows.Forms.TextBox();
            this.txt_lvl = new System.Windows.Forms.TextBox();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_woods
            // 
            this.lsb_woods.BackColor = System.Drawing.Color.Black;
            this.lsb_woods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsb_woods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsb_woods.ForeColor = System.Drawing.Color.White;
            this.lsb_woods.FormattingEnabled = true;
            this.lsb_woods.ItemHeight = 16;
            this.lsb_woods.Location = new System.Drawing.Point(373, 12);
            this.lsb_woods.Name = "lsb_woods";
            this.lsb_woods.Size = new System.Drawing.Size(419, 370);
            this.lsb_woods.TabIndex = 21;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(22, 340);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(126, 41);
            this.btn_return.TabIndex = 20;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lbl_required
            // 
            this.lbl_required.AutoSize = true;
            this.lbl_required.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_required.ForeColor = System.Drawing.Color.White;
            this.lbl_required.Location = new System.Drawing.Point(16, 277);
            this.lbl_required.Name = "lbl_required";
            this.lbl_required.Size = new System.Drawing.Size(161, 31);
            this.lbl_required.TabIndex = 19;
            this.lbl_required.Text = "Xp required:";
            // 
            // lbl_XP
            // 
            this.lbl_XP.AutoSize = true;
            this.lbl_XP.BackColor = System.Drawing.Color.Black;
            this.lbl_XP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_XP.ForeColor = System.Drawing.Color.White;
            this.lbl_XP.Location = new System.Drawing.Point(12, 206);
            this.lbl_XP.Name = "lbl_XP";
            this.lbl_XP.Size = new System.Drawing.Size(114, 31);
            this.lbl_XP.TabIndex = 18;
            this.lbl_XP.Text = "Your xp:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.txt_desire);
            this.groupBox1.Controls.Add(this.lbl_desire);
            this.groupBox1.Controls.Add(this.btn_calc);
            this.groupBox1.Controls.Add(this.txt_percentage);
            this.groupBox1.Controls.Add(this.txt_lvl);
            this.groupBox1.Controls.Add(this.lbl_percent);
            this.groupBox1.Controls.Add(this.lbl_level);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 191);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // txt_desire
            // 
            this.txt_desire.Location = new System.Drawing.Point(127, 101);
            this.txt_desire.Name = "txt_desire";
            this.txt_desire.Size = new System.Drawing.Size(222, 20);
            this.txt_desire.TabIndex = 8;
            // 
            // lbl_desire
            // 
            this.lbl_desire.AutoSize = true;
            this.lbl_desire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_desire.ForeColor = System.Drawing.Color.White;
            this.lbl_desire.Location = new System.Drawing.Point(7, 101);
            this.lbl_desire.Name = "lbl_desire";
            this.lbl_desire.Size = new System.Drawing.Size(78, 17);
            this.lbl_desire.TabIndex = 7;
            this.lbl_desire.Text = "Desired lvl:";
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.ForeColor = System.Drawing.Color.White;
            this.btn_calc.Location = new System.Drawing.Point(6, 139);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(343, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Calculate experience";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_percentage
            // 
            this.txt_percentage.Location = new System.Drawing.Point(127, 61);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(222, 20);
            this.txt_percentage.TabIndex = 5;
            // 
            // txt_lvl
            // 
            this.txt_lvl.BackColor = System.Drawing.Color.White;
            this.txt_lvl.Location = new System.Drawing.Point(127, 19);
            this.txt_lvl.Name = "txt_lvl";
            this.txt_lvl.Size = new System.Drawing.Size(222, 20);
            this.txt_lvl.TabIndex = 4;
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_percent.ForeColor = System.Drawing.Color.White;
            this.lbl_percent.Location = new System.Drawing.Point(7, 61);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(85, 17);
            this.lbl_percent.TabIndex = 2;
            this.lbl_percent.Text = "Percentage:";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_level.ForeColor = System.Drawing.Color.White;
            this.lbl_level.Location = new System.Drawing.Point(7, 20);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(108, 17);
            this.lbl_level.TabIndex = 1;
            this.lbl_level.Text = "Woodcutting lvl:";
            // 
            // frm_Woodcutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsb_woods);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_required);
            this.Controls.Add(this.lbl_XP);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Woodcutting";
            this.ShowIcon = false;
            this.Text = "Woodcutting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_woods;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lbl_required;
        private System.Windows.Forms.Label lbl_XP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_desire;
        private System.Windows.Forms.Label lbl_desire;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_percentage;
        private System.Windows.Forms.TextBox txt_lvl;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Label lbl_level;
    }
}