namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.ViewProfile_btn = new System.Windows.Forms.Button();
            this.updateProfile_btn = new System.Windows.Forms.Button();
            this.viewGraph_btn = new System.Windows.Forms.Button();
            this.viewDietPlan_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewProfile_btn
            // 
            this.ViewProfile_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProfile_btn.Location = new System.Drawing.Point(98, 70);
            this.ViewProfile_btn.Name = "ViewProfile_btn";
            this.ViewProfile_btn.Size = new System.Drawing.Size(171, 31);
            this.ViewProfile_btn.TabIndex = 0;
            this.ViewProfile_btn.Text = "ViewProfile";
            this.ViewProfile_btn.UseVisualStyleBackColor = true;
            this.ViewProfile_btn.Click += new System.EventHandler(this.ViewProfile_btn_Click);
            // 
            // updateProfile_btn
            // 
            this.updateProfile_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfile_btn.Location = new System.Drawing.Point(98, 131);
            this.updateProfile_btn.Name = "updateProfile_btn";
            this.updateProfile_btn.Size = new System.Drawing.Size(171, 31);
            this.updateProfile_btn.TabIndex = 1;
            this.updateProfile_btn.Text = "updateProfile";
            this.updateProfile_btn.UseVisualStyleBackColor = true;
            this.updateProfile_btn.Click += new System.EventHandler(this.updateProfile_btn_Click);
            // 
            // viewGraph_btn
            // 
            this.viewGraph_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGraph_btn.Location = new System.Drawing.Point(98, 193);
            this.viewGraph_btn.Name = "viewGraph_btn";
            this.viewGraph_btn.Size = new System.Drawing.Size(171, 31);
            this.viewGraph_btn.TabIndex = 2;
            this.viewGraph_btn.Text = "viewGraph";
            this.viewGraph_btn.UseVisualStyleBackColor = true;
            // 
            // viewDietPlan_btn
            // 
            this.viewDietPlan_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDietPlan_btn.Location = new System.Drawing.Point(98, 254);
            this.viewDietPlan_btn.Name = "viewDietPlan_btn";
            this.viewDietPlan_btn.Size = new System.Drawing.Size(171, 31);
            this.viewDietPlan_btn.TabIndex = 3;
            this.viewDietPlan_btn.Text = "viewDietPlan";
            this.viewDietPlan_btn.UseVisualStyleBackColor = true;
            this.viewDietPlan_btn.Click += new System.EventHandler(this.viewDietPlan_btn_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(98, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "addBloodPressure";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 395);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.viewDietPlan_btn);
            this.Controls.Add(this.viewGraph_btn);
            this.Controls.Add(this.updateProfile_btn);
            this.Controls.Add(this.ViewProfile_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewProfile_btn;
        private System.Windows.Forms.Button updateProfile_btn;
        private System.Windows.Forms.Button viewGraph_btn;
        private System.Windows.Forms.Button viewDietPlan_btn;
        private System.Windows.Forms.Button button5;
    }
}