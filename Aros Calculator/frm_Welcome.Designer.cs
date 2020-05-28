namespace Aros_Calculator
{
    partial class frm_Welcome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mining = new System.Windows.Forms.Button();
            this.btn_smithing = new System.Windows.Forms.Button();
            this.btn_woodcutting = new System.Windows.Forms.Button();
            this.btn_crafting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mining
            // 
            this.btn_mining.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_mining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mining.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_mining.ForeColor = System.Drawing.Color.White;
            this.btn_mining.Location = new System.Drawing.Point(62, 12);
            this.btn_mining.Name = "btn_mining";
            this.btn_mining.Size = new System.Drawing.Size(244, 54);
            this.btn_mining.TabIndex = 0;
            this.btn_mining.Text = "Mining";
            this.btn_mining.UseVisualStyleBackColor = false;
            this.btn_mining.Click += new System.EventHandler(this.btn_mining_Click);
            // 
            // btn_smithing
            // 
            this.btn_smithing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_smithing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_smithing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_smithing.ForeColor = System.Drawing.Color.White;
            this.btn_smithing.Location = new System.Drawing.Point(62, 95);
            this.btn_smithing.Name = "btn_smithing";
            this.btn_smithing.Size = new System.Drawing.Size(244, 54);
            this.btn_smithing.TabIndex = 1;
            this.btn_smithing.Text = "Smithing";
            this.btn_smithing.UseVisualStyleBackColor = false;
            this.btn_smithing.Click += new System.EventHandler(this.btn_smithing_Click);
            // 
            // btn_woodcutting
            // 
            this.btn_woodcutting.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_woodcutting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_woodcutting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_woodcutting.ForeColor = System.Drawing.Color.White;
            this.btn_woodcutting.Location = new System.Drawing.Point(62, 179);
            this.btn_woodcutting.Name = "btn_woodcutting";
            this.btn_woodcutting.Size = new System.Drawing.Size(244, 54);
            this.btn_woodcutting.TabIndex = 2;
            this.btn_woodcutting.Text = "Woodcutting";
            this.btn_woodcutting.UseVisualStyleBackColor = false;
            this.btn_woodcutting.Click += new System.EventHandler(this.btn_woodcutting_Click);
            // 
            // btn_crafting
            // 
            this.btn_crafting.BackColor = System.Drawing.Color.DarkRed;
            this.btn_crafting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crafting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_crafting.ForeColor = System.Drawing.Color.White;
            this.btn_crafting.Location = new System.Drawing.Point(62, 265);
            this.btn_crafting.Name = "btn_crafting";
            this.btn_crafting.Size = new System.Drawing.Size(244, 54);
            this.btn_crafting.TabIndex = 3;
            this.btn_crafting.Text = "Crafting";
            this.btn_crafting.UseVisualStyleBackColor = false;
            this.btn_crafting.Click += new System.EventHandler(this.btn_crafting_Click);
            // 
            // frm_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(361, 386);
            this.Controls.Add(this.btn_crafting);
            this.Controls.Add(this.btn_woodcutting);
            this.Controls.Add(this.btn_smithing);
            this.Controls.Add(this.btn_mining);
            this.Name = "frm_Welcome";
            this.ShowIcon = false;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mining;
        private System.Windows.Forms.Button btn_smithing;
        private System.Windows.Forms.Button btn_woodcutting;
        private System.Windows.Forms.Button btn_crafting;
    }
}

