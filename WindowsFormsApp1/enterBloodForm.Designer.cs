namespace WindowsFormsApp1
{
    partial class enterBloodForm
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
            this.blood_txtbox = new System.Windows.Forms.TextBox();
            this.saveBloodPressure_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Blood Pressure";
            // 
            // blood_txtbox
            // 
            this.blood_txtbox.Location = new System.Drawing.Point(99, 100);
            this.blood_txtbox.Name = "blood_txtbox";
            this.blood_txtbox.Size = new System.Drawing.Size(100, 20);
            this.blood_txtbox.TabIndex = 2;
            // 
            // saveBloodPressure_btn
            // 
            this.saveBloodPressure_btn.Location = new System.Drawing.Point(112, 174);
            this.saveBloodPressure_btn.Name = "saveBloodPressure_btn";
            this.saveBloodPressure_btn.Size = new System.Drawing.Size(75, 23);
            this.saveBloodPressure_btn.TabIndex = 3;
            this.saveBloodPressure_btn.Text = "Save";
            this.saveBloodPressure_btn.UseVisualStyleBackColor = true;
            this.saveBloodPressure_btn.Click += new System.EventHandler(this.saveBloodPressure_btn_Click);
            // 
            // enterBloodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 245);
            this.Controls.Add(this.saveBloodPressure_btn);
            this.Controls.Add(this.blood_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "enterBloodForm";
            this.Text = "enterBloodForm";
            this.Load += new System.EventHandler(this.enterBloodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blood_txtbox;
        private System.Windows.Forms.Button saveBloodPressure_btn;
    }
}