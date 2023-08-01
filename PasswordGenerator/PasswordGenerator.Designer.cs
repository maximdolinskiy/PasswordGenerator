namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.passwordlengthSlider = new System.Windows.Forms.TrackBar();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordlengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(98, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(686, 103);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "label1";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLength.Location = new System.Drawing.Point(98, 211);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(674, 96);
            this.lblPasswordLength.TabIndex = 1;
            this.lblPasswordLength.Text = "Password Length: 5";
            this.lblPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlengthSlider
            // 
            this.passwordlengthSlider.Location = new System.Drawing.Point(252, 299);
            this.passwordlengthSlider.Name = "passwordlengthSlider";
            this.passwordlengthSlider.Size = new System.Drawing.Size(362, 45);
            this.passwordlengthSlider.TabIndex = 2;
            this.passwordlengthSlider.Scroll += new System.EventHandler(this.passwordlengthSlider_Scroll);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCopyPassword.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPassword.Location = new System.Drawing.Point(282, 361);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(304, 63);
            this.btnCopyPassword.TabIndex = 3;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 525);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.passwordlengthSlider);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordlengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.TrackBar passwordlengthSlider;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

