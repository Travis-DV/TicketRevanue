namespace TicketRevanue
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
            this.TicketsSoldGroup = new System.Windows.Forms.GroupBox();
            this.gradeCinTB = new System.Windows.Forms.TextBox();
            this.gradeBinTB = new System.Windows.Forms.TextBox();
            this.gradeAinTB = new System.Windows.Forms.TextBox();
            this.gradeCinLB = new System.Windows.Forms.Label();
            this.gradeBinLB = new System.Windows.Forms.Label();
            this.gradeAinLB = new System.Windows.Forms.Label();
            this.explanationLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.totalLB = new System.Windows.Forms.Label();
            this.gradeCoutTB = new System.Windows.Forms.TextBox();
            this.gradeBoutTB = new System.Windows.Forms.TextBox();
            this.gradeAoutTB = new System.Windows.Forms.TextBox();
            this.gradeCoutLB = new System.Windows.Forms.Label();
            this.gradeBoutLB = new System.Windows.Forms.Label();
            this.gradeAoutLB = new System.Windows.Forms.Label();
            this.clearBUT = new System.Windows.Forms.Button();
            this.TicketsSoldGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketsSoldGroup
            // 
            this.TicketsSoldGroup.Controls.Add(this.gradeCinTB);
            this.TicketsSoldGroup.Controls.Add(this.gradeBinTB);
            this.TicketsSoldGroup.Controls.Add(this.gradeAinTB);
            this.TicketsSoldGroup.Controls.Add(this.gradeCinLB);
            this.TicketsSoldGroup.Controls.Add(this.gradeBinLB);
            this.TicketsSoldGroup.Controls.Add(this.gradeAinLB);
            this.TicketsSoldGroup.Controls.Add(this.explanationLB);
            this.TicketsSoldGroup.Location = new System.Drawing.Point(12, 12);
            this.TicketsSoldGroup.Name = "TicketsSoldGroup";
            this.TicketsSoldGroup.Size = new System.Drawing.Size(200, 159);
            this.TicketsSoldGroup.TabIndex = 0;
            this.TicketsSoldGroup.TabStop = false;
            this.TicketsSoldGroup.Text = "Tickets Sold";
            // 
            // gradeCinTB
            // 
            this.gradeCinTB.Location = new System.Drawing.Point(76, 111);
            this.gradeCinTB.Name = "gradeCinTB";
            this.gradeCinTB.Size = new System.Drawing.Size(100, 20);
            this.gradeCinTB.TabIndex = 6;
            this.gradeCinTB.TextChanged += new System.EventHandler(this.gradeCinTB_TextChanged);
            // 
            // gradeBinTB
            // 
            this.gradeBinTB.Location = new System.Drawing.Point(76, 84);
            this.gradeBinTB.Name = "gradeBinTB";
            this.gradeBinTB.Size = new System.Drawing.Size(100, 20);
            this.gradeBinTB.TabIndex = 5;
            this.gradeBinTB.TextChanged += new System.EventHandler(this.gradeBinTB_TextChanged);
            // 
            // gradeAinTB
            // 
            this.gradeAinTB.Location = new System.Drawing.Point(76, 54);
            this.gradeAinTB.Name = "gradeAinTB";
            this.gradeAinTB.Size = new System.Drawing.Size(100, 20);
            this.gradeAinTB.TabIndex = 4;
            this.gradeAinTB.TextChanged += new System.EventHandler(this.gradeAinTB_TextChanged);
            // 
            // gradeCinLB
            // 
            this.gradeCinLB.AutoSize = true;
            this.gradeCinLB.Location = new System.Drawing.Point(18, 118);
            this.gradeCinLB.Name = "gradeCinLB";
            this.gradeCinLB.Size = new System.Drawing.Size(52, 13);
            this.gradeCinLB.TabIndex = 3;
            this.gradeCinLB.Text = "Grade C: ";
            // 
            // gradeBinLB
            // 
            this.gradeBinLB.AutoSize = true;
            this.gradeBinLB.Location = new System.Drawing.Point(18, 84);
            this.gradeBinLB.Name = "gradeBinLB";
            this.gradeBinLB.Size = new System.Drawing.Size(52, 13);
            this.gradeBinLB.TabIndex = 2;
            this.gradeBinLB.Text = "Grade B: ";
            // 
            // gradeAinLB
            // 
            this.gradeAinLB.AutoSize = true;
            this.gradeAinLB.Location = new System.Drawing.Point(18, 54);
            this.gradeAinLB.Name = "gradeAinLB";
            this.gradeAinLB.Size = new System.Drawing.Size(52, 13);
            this.gradeAinLB.TabIndex = 1;
            this.gradeAinLB.Text = "Grade A: ";
            // 
            // explanationLB
            // 
            this.explanationLB.Location = new System.Drawing.Point(6, 16);
            this.explanationLB.Name = "explanationLB";
            this.explanationLB.Size = new System.Drawing.Size(188, 34);
            this.explanationLB.TabIndex = 0;
            this.explanationLB.Text = "Input the amount of seats sold in every grade of seat.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTB);
            this.groupBox1.Controls.Add(this.totalLB);
            this.groupBox1.Controls.Add(this.gradeCoutTB);
            this.groupBox1.Controls.Add(this.gradeBoutTB);
            this.groupBox1.Controls.Add(this.gradeAoutTB);
            this.groupBox1.Controls.Add(this.gradeCoutLB);
            this.groupBox1.Controls.Add(this.gradeBoutLB);
            this.groupBox1.Controls.Add(this.gradeAoutLB);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Money Made";
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(79, 120);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 8;
            // 
            // totalLB
            // 
            this.totalLB.AutoSize = true;
            this.totalLB.Location = new System.Drawing.Point(21, 127);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(37, 13);
            this.totalLB.TabIndex = 7;
            this.totalLB.Text = "Total: ";
            // 
            // gradeCoutTB
            // 
            this.gradeCoutTB.Location = new System.Drawing.Point(79, 83);
            this.gradeCoutTB.Name = "gradeCoutTB";
            this.gradeCoutTB.Size = new System.Drawing.Size(100, 20);
            this.gradeCoutTB.TabIndex = 6;
            // 
            // gradeBoutTB
            // 
            this.gradeBoutTB.Location = new System.Drawing.Point(79, 56);
            this.gradeBoutTB.Name = "gradeBoutTB";
            this.gradeBoutTB.Size = new System.Drawing.Size(100, 20);
            this.gradeBoutTB.TabIndex = 5;
            // 
            // gradeAoutTB
            // 
            this.gradeAoutTB.Location = new System.Drawing.Point(79, 26);
            this.gradeAoutTB.Name = "gradeAoutTB";
            this.gradeAoutTB.Size = new System.Drawing.Size(100, 20);
            this.gradeAoutTB.TabIndex = 4;
            // 
            // gradeCoutLB
            // 
            this.gradeCoutLB.AutoSize = true;
            this.gradeCoutLB.Location = new System.Drawing.Point(21, 90);
            this.gradeCoutLB.Name = "gradeCoutLB";
            this.gradeCoutLB.Size = new System.Drawing.Size(52, 13);
            this.gradeCoutLB.TabIndex = 3;
            this.gradeCoutLB.Text = "Grade C: ";
            // 
            // gradeBoutLB
            // 
            this.gradeBoutLB.AutoSize = true;
            this.gradeBoutLB.Location = new System.Drawing.Point(21, 56);
            this.gradeBoutLB.Name = "gradeBoutLB";
            this.gradeBoutLB.Size = new System.Drawing.Size(52, 13);
            this.gradeBoutLB.TabIndex = 2;
            this.gradeBoutLB.Text = "Grade B: ";
            // 
            // gradeAoutLB
            // 
            this.gradeAoutLB.AutoSize = true;
            this.gradeAoutLB.Location = new System.Drawing.Point(21, 26);
            this.gradeAoutLB.Name = "gradeAoutLB";
            this.gradeAoutLB.Size = new System.Drawing.Size(52, 13);
            this.gradeAoutLB.TabIndex = 1;
            this.gradeAoutLB.Text = "Grade A: ";
            // 
            // clearBUT
            // 
            this.clearBUT.Location = new System.Drawing.Point(192, 177);
            this.clearBUT.Name = "clearBUT";
            this.clearBUT.Size = new System.Drawing.Size(75, 23);
            this.clearBUT.TabIndex = 8;
            this.clearBUT.Text = "Clear";
            this.clearBUT.UseVisualStyleBackColor = true;
            this.clearBUT.Click += new System.EventHandler(this.clearBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 245);
            this.Controls.Add(this.clearBUT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TicketsSoldGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TicketsSoldGroup.ResumeLayout(false);
            this.TicketsSoldGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TicketsSoldGroup;
        private System.Windows.Forms.TextBox gradeCinTB;
        private System.Windows.Forms.TextBox gradeBinTB;
        private System.Windows.Forms.TextBox gradeAinTB;
        private System.Windows.Forms.Label gradeCinLB;
        private System.Windows.Forms.Label gradeBinLB;
        private System.Windows.Forms.Label gradeAinLB;
        private System.Windows.Forms.Label explanationLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.TextBox gradeCoutTB;
        private System.Windows.Forms.TextBox gradeBoutTB;
        private System.Windows.Forms.TextBox gradeAoutTB;
        private System.Windows.Forms.Label gradeCoutLB;
        private System.Windows.Forms.Label gradeBoutLB;
        private System.Windows.Forms.Label gradeAoutLB;
        private System.Windows.Forms.Button clearBUT;
    }
}

