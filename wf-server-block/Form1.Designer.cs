using System;

namespace wf_server_block
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.hkEnable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sgEnable = new System.Windows.Forms.Button();
            this.sjEnable = new System.Windows.Forms.Button();
            this.dsEnable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "HONGKONG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hkEnable
            // 
            this.hkEnable.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkEnable.Location = new System.Drawing.Point(179, 24);
            this.hkEnable.Name = "hkEnable";
            this.hkEnable.Size = new System.Drawing.Size(75, 23);
            this.hkEnable.TabIndex = 1;
            this.hkEnable.Text = "ENABLE";
            this.hkEnable.UseVisualStyleBackColor = true;
            this.hkEnable.Click += new System.EventHandler(this.hkEnable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SINGAPORE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "SANJOSE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "DALLAS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sgEnable
            // 
            this.sgEnable.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgEnable.Location = new System.Drawing.Point(179, 61);
            this.sgEnable.Name = "sgEnable";
            this.sgEnable.Size = new System.Drawing.Size(75, 23);
            this.sgEnable.TabIndex = 5;
            this.sgEnable.Text = "ENABLE";
            this.sgEnable.UseVisualStyleBackColor = true;
            this.sgEnable.Click += new System.EventHandler(this.sgEnable_Click_1);
            // 
            // sjEnable
            // 
            this.sjEnable.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sjEnable.Location = new System.Drawing.Point(179, 100);
            this.sjEnable.Name = "sjEnable";
            this.sjEnable.Size = new System.Drawing.Size(75, 23);
            this.sjEnable.TabIndex = 6;
            this.sjEnable.Text = "ENABLE";
            this.sjEnable.UseVisualStyleBackColor = true;
            this.sjEnable.Click += new System.EventHandler(this.sjEnable_Click_1);
            // 
            // dsEnable
            // 
            this.dsEnable.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsEnable.Location = new System.Drawing.Point(179, 142);
            this.dsEnable.Name = "dsEnable";
            this.dsEnable.Size = new System.Drawing.Size(75, 23);
            this.dsEnable.TabIndex = 7;
            this.dsEnable.Text = "ENABLE";
            this.dsEnable.UseVisualStyleBackColor = true;
            this.dsEnable.Click += new System.EventHandler(this.dsEnable_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 193);
            this.Controls.Add(this.dsEnable);
            this.Controls.Add(this.sjEnable);
            this.Controls.Add(this.sgEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hkEnable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Warface Server Block Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hkEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sgEnable;
        private System.Windows.Forms.Button sjEnable;
        private System.Windows.Forms.Button dsEnable;
    }
}

