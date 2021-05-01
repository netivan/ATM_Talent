
namespace ATM_Talent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ATM_LOAD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ATM = new System.Windows.Forms.ListBox();
            this.WITHDRAWAL = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AMOUNT = new System.Windows.Forms.TextBox();
            this.ATM_TAKE = new System.Windows.Forms.Button();
            this.DISPLAY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ATM_LOAD
            // 
            this.ATM_LOAD.Location = new System.Drawing.Point(142, 311);
            this.ATM_LOAD.Name = "ATM_LOAD";
            this.ATM_LOAD.Size = new System.Drawing.Size(94, 29);
            this.ATM_LOAD.TabIndex = 1;
            this.ATM_LOAD.Text = "ATM  LOAD";
            this.ATM_LOAD.UseVisualStyleBackColor = true;
            this.ATM_LOAD.Click += new System.EventHandler(this.ATM_LOAD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ATM
            // 
            this.ATM.FormattingEnabled = true;
            this.ATM.ItemHeight = 20;
            this.ATM.Location = new System.Drawing.Point(112, 65);
            this.ATM.Name = "ATM";
            this.ATM.Size = new System.Drawing.Size(150, 224);
            this.ATM.TabIndex = 3;
            this.ATM.SelectedIndexChanged += new System.EventHandler(this.ATM_SelectedIndexChanged);
            // 
            // WITHDRAWAL
            // 
            this.WITHDRAWAL.FormattingEnabled = true;
            this.WITHDRAWAL.ItemHeight = 20;
            this.WITHDRAWAL.Location = new System.Drawing.Point(531, 65);
            this.WITHDRAWAL.Name = "WITHDRAWAL";
            this.WITHDRAWAL.Size = new System.Drawing.Size(257, 324);
            this.WITHDRAWAL.TabIndex = 4;
            this.WITHDRAWAL.SelectedIndexChanged += new System.EventHandler(this.WITHDRAWAL_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "WITHDRAWAL_LIST";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AMOUNT
            // 
            this.AMOUNT.Location = new System.Drawing.Point(306, 311);
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(154, 27);
            this.AMOUNT.TabIndex = 7;
            this.AMOUNT.TextChanged += new System.EventHandler(this.AMOUNT_TextChanged);
            // 
            // ATM_TAKE
            // 
            this.ATM_TAKE.Location = new System.Drawing.Point(328, 344);
            this.ATM_TAKE.Name = "ATM_TAKE";
            this.ATM_TAKE.Size = new System.Drawing.Size(110, 45);
            this.ATM_TAKE.TabIndex = 8;
            this.ATM_TAKE.Text = "TAKE";
            this.ATM_TAKE.UseVisualStyleBackColor = true;
            this.ATM_TAKE.Click += new System.EventHandler(this.ATM_TAKE_Click);
            // 
            // DISPLAY
            // 
            this.DISPLAY.AutoSize = true;
            this.DISPLAY.Location = new System.Drawing.Point(346, 33);
            this.DISPLAY.Name = "DISPLAY";
            this.DISPLAY.Size = new System.Drawing.Size(64, 20);
            this.DISPLAY.TabIndex = 9;
            this.DISPLAY.Text = "DISPLAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(21, 414);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(66, 24);
            this.listBox1.TabIndex = 11;
            this.listBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Insert Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DISPLAY);
            this.Controls.Add(this.ATM_TAKE);
            this.Controls.Add(this.AMOUNT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WITHDRAWAL);
            this.Controls.Add(this.ATM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ATM_LOAD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ATM_LOAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ATM;
        private System.Windows.Forms.ListBox WITHDRAWAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AMOUNT;
        private System.Windows.Forms.Button ATM_TAKE;
        private System.Windows.Forms.Label DISPLAY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}

