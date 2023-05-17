
namespace PassingTests
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.variant1 = new System.Windows.Forms.Label();
            this.variant2 = new System.Windows.Forms.Label();
            this.variant3 = new System.Windows.Forms.Label();
            this.variant4 = new System.Windows.Forms.Label();
            this.variant5 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.quetion = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.CheckButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PreviousButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.quetion, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1229, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CheckButton.Location = new System.Drawing.Point(3, 420);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 36);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.rb1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rb3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rb4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.rb5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.variant1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.variant2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.variant3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.variant4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.variant5, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 230);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1226, 184);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb1.Location = new System.Drawing.Point(3, 3);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(44, 28);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1)";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb2.Location = new System.Drawing.Point(3, 37);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(44, 28);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2)";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb3.Location = new System.Drawing.Point(3, 71);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(44, 28);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3)";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb4.Location = new System.Drawing.Point(3, 105);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(44, 28);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "4)";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb5.Location = new System.Drawing.Point(3, 139);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(44, 28);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "5)";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // variant1
            // 
            this.variant1.AutoSize = true;
            this.variant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.variant1.Location = new System.Drawing.Point(53, 0);
            this.variant1.Name = "variant1";
            this.variant1.Size = new System.Drawing.Size(86, 24);
            this.variant1.TabIndex = 5;
            this.variant1.Text = "<variant>";
            // 
            // variant2
            // 
            this.variant2.AutoSize = true;
            this.variant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.variant2.Location = new System.Drawing.Point(53, 34);
            this.variant2.Name = "variant2";
            this.variant2.Size = new System.Drawing.Size(86, 24);
            this.variant2.TabIndex = 6;
            this.variant2.Text = "<variant>";
            // 
            // variant3
            // 
            this.variant3.AutoSize = true;
            this.variant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.variant3.Location = new System.Drawing.Point(53, 68);
            this.variant3.Name = "variant3";
            this.variant3.Size = new System.Drawing.Size(86, 24);
            this.variant3.TabIndex = 7;
            this.variant3.Text = "<variant>";
            // 
            // variant4
            // 
            this.variant4.AutoSize = true;
            this.variant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.variant4.Location = new System.Drawing.Point(53, 102);
            this.variant4.Name = "variant4";
            this.variant4.Size = new System.Drawing.Size(86, 24);
            this.variant4.TabIndex = 8;
            this.variant4.Text = "<variant>";
            // 
            // variant5
            // 
            this.variant5.AutoSize = true;
            this.variant5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.variant5.Location = new System.Drawing.Point(53, 136);
            this.variant5.Name = "variant5";
            this.variant5.Size = new System.Drawing.Size(86, 24);
            this.variant5.TabIndex = 9;
            this.variant5.Text = "<variant>";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NextButton.Location = new System.Drawing.Point(3, 462);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 36);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PreviousButton.Location = new System.Drawing.Point(3, 504);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(107, 36);
            this.PreviousButton.TabIndex = 7;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // quetion
            // 
            this.quetion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.quetion.Location = new System.Drawing.Point(3, 3);
            this.quetion.Name = "quetion";
            this.quetion.Size = new System.Drawing.Size(1226, 221);
            this.quetion.TabIndex = 8;
            this.quetion.Text = "";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Label variant1;
        private System.Windows.Forms.Label variant2;
        private System.Windows.Forms.Label variant3;
        private System.Windows.Forms.Label variant4;
        private System.Windows.Forms.Label variant5;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.RichTextBox quetion;
    }
}