namespace StudyMate
{
    partial class CheckForUpdateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForUpdateFrm));
            this.UpdateProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bgUpdateCheck = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // UpdateProgress
            // 
            this.UpdateProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateProgress.Location = new System.Drawing.Point(10, 35);
            this.UpdateProgress.MarqueeAnimationSpeed = 10;
            this.UpdateProgress.Name = "UpdateProgress";
            this.UpdateProgress.Size = new System.Drawing.Size(269, 15);
            this.UpdateProgress.Step = 20;
            this.UpdateProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.UpdateProgress.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(201, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Checking For Updates...";
            this.lblStatus.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpdate.ForeColor = System.Drawing.Color.Orange;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(286, 28);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 25);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Cancel";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bgUpdateCheck
            // 
            this.bgUpdateCheck.WorkerSupportsCancellation = true;
            this.bgUpdateCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgUpdateCheck_DoWork);
            this.bgUpdateCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgUpdateCheck_RunWorkerCompleted);
            // 
            // CheckForUpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 61);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.UpdateProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckForUpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyMate - Update";
            this.Shown += new System.EventHandler(this.CheckForUpdateFrm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar UpdateProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker bgUpdateCheck;
    }
}