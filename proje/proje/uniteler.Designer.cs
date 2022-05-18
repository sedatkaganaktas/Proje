
namespace proje
{
    partial class uniteler
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
            this.unite1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unite1
            // 
            this.unite1.Location = new System.Drawing.Point(125, 111);
            this.unite1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unite1.Name = "unite1";
            this.unite1.Size = new System.Drawing.Size(167, 41);
            this.unite1.TabIndex = 0;
            this.unite1.Text = "unite 1";
            this.unite1.UseVisualStyleBackColor = true;
            this.unite1.Click += new System.EventHandler(this.unite1_Click);
            // 
            // uniteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.unite1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uniteler";
            this.Text = "uniteler";
            this.Load += new System.EventHandler(this.uniteler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unite1;
    }
}