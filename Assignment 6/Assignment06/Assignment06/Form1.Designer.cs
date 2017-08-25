namespace Assignment06
{
    partial class InAddMul
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
            this.Instructions = new System.Windows.Forms.TextBox();
            this.EnterNum1 = new System.Windows.Forms.TextBox();
            this.In_1 = new System.Windows.Forms.TextBox();
            this.In_2 = new System.Windows.Forms.TextBox();
            this.EnterNum2 = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Out_Put = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Instructions.Location = new System.Drawing.Point(71, 65);
            this.Instructions.Multiline = true;
            this.Instructions.Name = "Instructions";
            this.Instructions.ReadOnly = true;
            this.Instructions.Size = new System.Drawing.Size(230, 52);
            this.Instructions.TabIndex = 0;
            this.Instructions.Tag = "Instructs";
            this.Instructions.Text = "Type two numbers, then click \"Add\" or \"multiply\" to calculate.";
            this.Instructions.TextChanged += new System.EventHandler(this.Instructions_TextChanged);
            // 
            // EnterNum1
            // 
            this.EnterNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EnterNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterNum1.Location = new System.Drawing.Point(71, 123);
            this.EnterNum1.Name = "EnterNum1";
            this.EnterNum1.ReadOnly = true;
            this.EnterNum1.Size = new System.Drawing.Size(100, 15);
            this.EnterNum1.TabIndex = 1;
            this.EnterNum1.Tag = "EnterN1";
            this.EnterNum1.Text = "Enter Number 1:";
            // 
            // In_1
            // 
            this.In_1.Location = new System.Drawing.Point(177, 123);
            this.In_1.Name = "In_1";
            this.In_1.Size = new System.Drawing.Size(100, 22);
            this.In_1.TabIndex = 3;
            this.In_1.TextChanged += new System.EventHandler(this.In_Num1_txt);
            // 
            // In_2
            // 
            this.In_2.Location = new System.Drawing.Point(177, 177);
            this.In_2.Name = "In_2";
            this.In_2.Size = new System.Drawing.Size(100, 22);
            this.In_2.TabIndex = 4;
            this.In_2.TextChanged += new System.EventHandler(this.In_Num2_txt);
            // 
            // EnterNum2
            // 
            this.EnterNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EnterNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterNum2.Location = new System.Drawing.Point(71, 177);
            this.EnterNum2.Name = "EnterNum2";
            this.EnterNum2.ReadOnly = true;
            this.EnterNum2.Size = new System.Drawing.Size(100, 15);
            this.EnterNum2.TabIndex = 5;
            this.EnterNum2.Tag = "EnterN2";
            this.EnterNum2.Text = "Enter Number 2:";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(96, 260);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Tag = "Add";
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Location = new System.Drawing.Point(202, 260);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(75, 23);
            this.Multiply_Button.TabIndex = 7;
            this.Multiply_Button.Text = "Multiply";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Out_Put
            // 
            this.Out_Put.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Out_Put.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Out_Put.Location = new System.Drawing.Point(142, 319);
            this.Out_Put.Name = "Out_Put";
            this.Out_Put.ReadOnly = true;
            this.Out_Put.Size = new System.Drawing.Size(100, 15);
            this.Out_Put.TabIndex = 8;
            this.Out_Put.Tag = "OutPt";
            this.Out_Put.Visible = false;
            this.Out_Put.TextChanged += new System.EventHandler(this.Out_Put_TextChanged);
            // 
            // InAddMul
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Out_Put);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.EnterNum2);
            this.Controls.Add(this.In_2);
            this.Controls.Add(this.In_1);
            this.Controls.Add(this.EnterNum1);
            this.Controls.Add(this.Instructions);
            this.Location = new System.Drawing.Point(30, 30);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.Name = "InAddMul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add and Multiply Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Instructions;
        private System.Windows.Forms.TextBox In_1;
        private System.Windows.Forms.TextBox In_2;
        public System.Windows.Forms.TextBox EnterNum1;
        public System.Windows.Forms.TextBox EnterNum2;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.TextBox Out_Put;
    }
}

