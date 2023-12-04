namespace DASHBOARD
{
    partial class Dashboard
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
            this.btn_RunningGame = new System.Windows.Forms.Button();
            this.btnCarracing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RunningGame
            // 
            this.btn_RunningGame.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_RunningGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RunningGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RunningGame.Location = new System.Drawing.Point(100, 91);
            this.btn_RunningGame.Name = "btn_RunningGame";
            this.btn_RunningGame.Size = new System.Drawing.Size(191, 111);
            this.btn_RunningGame.TabIndex = 0;
            this.btn_RunningGame.Text = "Running Game";
            this.btn_RunningGame.UseVisualStyleBackColor = false;
            this.btn_RunningGame.Click += new System.EventHandler(this.btn_RunningGame_Click);
            // 
            // btnCarracing
            // 
            this.btnCarracing.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCarracing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarracing.Location = new System.Drawing.Point(483, 100);
            this.btnCarracing.Name = "btnCarracing";
            this.btnCarracing.Size = new System.Drawing.Size(191, 111);
            this.btnCarracing.TabIndex = 0;
            this.btnCarracing.Text = "Car Racing\r\n";
            this.btnCarracing.UseVisualStyleBackColor = false;
            this.btnCarracing.Click += new System.EventHandler(this.btnCarracing_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.btnCarracing);
            this.Controls.Add(this.btn_RunningGame);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RunningGame;
        private System.Windows.Forms.Button btnCarracing;
    }
}

