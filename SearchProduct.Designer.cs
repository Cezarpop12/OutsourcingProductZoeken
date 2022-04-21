
namespace PresentationLayer
{
    partial class SearchProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbZoeken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxMatch = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(723, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Filteren_Click);
            // 
            // tbZoeken
            // 
            this.tbZoeken.Location = new System.Drawing.Point(214, 38);
            this.tbZoeken.Multiline = true;
            this.tbZoeken.Name = "tbZoeken";
            this.tbZoeken.Size = new System.Drawing.Size(313, 24);
            this.tbZoeken.TabIndex = 1;
            this.tbZoeken.TextChanged += new System.EventHandler(this.tbZoeken_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filteren category:";
            // 
            // lbxMatch
            // 
            this.lbxMatch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxMatch.FormattingEnabled = true;
            this.lbxMatch.ItemHeight = 16;
            this.lbxMatch.Location = new System.Drawing.Point(214, 89);
            this.lbxMatch.Name = "lbxMatch";
            this.lbxMatch.Size = new System.Drawing.Size(313, 324);
            this.lbxMatch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoeken:";
            // 
            // comboBox1
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(546, 114);
            this.cbxFilter.Name = "comboBox1";
            this.cbxFilter.Size = new System.Drawing.Size(171, 24);
            this.cbxFilter.TabIndex = 5;
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZoeken);
            this.Controls.Add(this.button1);
            this.Name = "SearchProduct";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbZoeken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilter;
    }
}