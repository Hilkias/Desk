
namespace MegaDesk_Nakkapalli
{
    partial class MainMenu
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
            this.AddQ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchQ = new System.Windows.Forms.Button();
            this.ViewQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQ
            // 
            this.AddQ.AutoSize = true;
            this.AddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQ.Location = new System.Drawing.Point(55, 40);
            this.AddQ.Name = "AddQ";
            this.AddQ.Size = new System.Drawing.Size(232, 74);
            this.AddQ.TabIndex = 0;
            this.AddQ.Text = "Add New Quote";
            this.AddQ.UseVisualStyleBackColor = true;
            this.AddQ.Click += new System.EventHandler(this.AddQ_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQ
            // 
            this.SearchQ.AutoSize = true;
            this.SearchQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQ.Location = new System.Drawing.Point(55, 221);
            this.SearchQ.Name = "SearchQ";
            this.SearchQ.Size = new System.Drawing.Size(232, 74);
            this.SearchQ.TabIndex = 2;
            this.SearchQ.Text = "Search Quote";
            this.SearchQ.UseVisualStyleBackColor = true;
            this.SearchQ.Click += new System.EventHandler(this.SearchQ_Click);
            // 
            // ViewQ
            // 
            this.ViewQ.AutoSize = true;
            this.ViewQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQ.Location = new System.Drawing.Point(55, 129);
            this.ViewQ.Name = "ViewQ";
            this.ViewQ.Size = new System.Drawing.Size(232, 74);
            this.ViewQ.TabIndex = 3;
            this.ViewQ.Text = "View Quote";
            this.ViewQ.UseVisualStyleBackColor = true;
            this.ViewQ.Click += new System.EventHandler(this.ViewQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewQ);
            this.Controls.Add(this.SearchQ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchQ;
        private System.Windows.Forms.Button ViewQ;
    }
}

