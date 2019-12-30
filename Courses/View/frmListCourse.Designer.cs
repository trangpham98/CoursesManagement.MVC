namespace Courses.View
{
    partial class frmListCourse
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
            this.rtxLstCourse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxLstCourse
            // 
            this.rtxLstCourse.Location = new System.Drawing.Point(9, 33);
            this.rtxLstCourse.Margin = new System.Windows.Forms.Padding(2);
            this.rtxLstCourse.Name = "rtxLstCourse";
            this.rtxLstCourse.Size = new System.Drawing.Size(282, 148);
            this.rtxLstCourse.TabIndex = 0;
            this.rtxLstCourse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of all couses (order by Credit)";
            // 
            // frmListCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxLstCourse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListCourse_FormClosing);
            this.Load += new System.EventHandler(this.frmListCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxLstCourse;
        private System.Windows.Forms.Label label1;
    }
}