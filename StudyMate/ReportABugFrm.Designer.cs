namespace StudyMate
{
    partial class ReportABugFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportABugFrm));
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnOther = new System.Windows.Forms.RadioButton();
            this.btnApplication = new System.Windows.Forms.RadioButton();
            this.btnContent = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(13, 49);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancel.ForeColor = System.Drawing.Color.Orange;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(164, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSend.ForeColor = System.Drawing.Color.Orange;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(76, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 25);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategory.Location = new System.Drawing.Point(13, 7);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
            // 
            // btnOther
            // 
            this.btnOther.AutoSize = true;
            this.btnOther.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOther.Location = new System.Drawing.Point(224, 26);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(63, 20);
            this.btnOther.TabIndex = 23;
            this.btnOther.TabStop = true;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.CheckedChanged += new System.EventHandler(this.btnOther_CheckedChanged);
            // 
            // btnApplication
            // 
            this.btnApplication.AutoSize = true;
            this.btnApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApplication.Location = new System.Drawing.Point(35, 26);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(98, 20);
            this.btnApplication.TabIndex = 22;
            this.btnApplication.TabStop = true;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.CheckedChanged += new System.EventHandler(this.btnOther_CheckedChanged);
            // 
            // btnContent
            // 
            this.btnContent.AutoSize = true;
            this.btnContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnContent.Location = new System.Drawing.Point(139, 26);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(79, 20);
            this.btnContent.TabIndex = 21;
            this.btnContent.TabStop = true;
            this.btnContent.Text = "Content";
            this.btnContent.UseVisualStyleBackColor = true;
            this.btnContent.CheckedChanged += new System.EventHandler(this.btnOther_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 68);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(293, 81);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // bg
            // 
            this.bg.WorkerSupportsCancellation = true;
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            // 
            // ReportABugFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 186);
            this.ControlBox = false;
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnContent);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCategory);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportABugFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyMate - Report A Bug";
            this.Load += new System.EventHandler(this.BugsFrm_Load);
            this.Shown += new System.EventHandler(this.BugsFrm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton btnOther;
        private System.Windows.Forms.RadioButton btnApplication;
        private System.Windows.Forms.RadioButton btnContent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.ComponentModel.BackgroundWorker bg;

    }
}