namespace Assignment08
{
    partial class App
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.NAME_VAL = new System.Windows.Forms.TextBox();
            this.NUMBER = new System.Windows.Forms.Label();
            this.NUMBER_VAL = new System.Windows.Forms.TextBox();
            this.STORE_DATA_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PAY_RATE_VAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HOURS_VAL = new System.Windows.Forms.TextBox();
            this.OUTPUT_BOX = new System.Windows.Forms.RichTextBox();
            this.RETRIEVE_DATA_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(14, 357);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Visible = false;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(14, 54);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(49, 17);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "Name:";
            // 
            // NAME_VAL
            // 
            this.NAME_VAL.Location = new System.Drawing.Point(116, 51);
            this.NAME_VAL.Name = "NAME_VAL";
            this.NAME_VAL.Size = new System.Drawing.Size(100, 22);
            this.NAME_VAL.TabIndex = 2;
            // 
            // NUMBER
            // 
            this.NUMBER.AutoSize = true;
            this.NUMBER.Location = new System.Drawing.Point(14, 103);
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.Size = new System.Drawing.Size(62, 17);
            this.NUMBER.TabIndex = 3;
            this.NUMBER.Text = "Number:";
            // 
            // NUMBER_VAL
            // 
            this.NUMBER_VAL.Location = new System.Drawing.Point(116, 103);
            this.NUMBER_VAL.Name = "NUMBER_VAL";
            this.NUMBER_VAL.Size = new System.Drawing.Size(100, 22);
            this.NUMBER_VAL.TabIndex = 4;
            // 
            // STORE_DATA_BUTTON
            // 
            this.STORE_DATA_BUTTON.Location = new System.Drawing.Point(82, 296);
            this.STORE_DATA_BUTTON.Name = "STORE_DATA_BUTTON";
            this.STORE_DATA_BUTTON.Size = new System.Drawing.Size(100, 23);
            this.STORE_DATA_BUTTON.TabIndex = 5;
            this.STORE_DATA_BUTTON.Text = "Store Data";
            this.STORE_DATA_BUTTON.UseVisualStyleBackColor = true;
            this.STORE_DATA_BUTTON.Click += new System.EventHandler(this.STORE_DATA_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pay Rate:";
            // 
            // PAY_RATE_VAL
            // 
            this.PAY_RATE_VAL.Location = new System.Drawing.Point(116, 152);
            this.PAY_RATE_VAL.Name = "PAY_RATE_VAL";
            this.PAY_RATE_VAL.Size = new System.Drawing.Size(100, 22);
            this.PAY_RATE_VAL.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours Worked:";
            // 
            // HOURS_VAL
            // 
            this.HOURS_VAL.Location = new System.Drawing.Point(116, 201);
            this.HOURS_VAL.Name = "HOURS_VAL";
            this.HOURS_VAL.Size = new System.Drawing.Size(100, 22);
            this.HOURS_VAL.TabIndex = 9;
            // 
            // OUTPUT_BOX
            // 
            this.OUTPUT_BOX.Location = new System.Drawing.Point(286, 51);
            this.OUTPUT_BOX.Name = "OUTPUT_BOX";
            this.OUTPUT_BOX.Size = new System.Drawing.Size(252, 218);
            this.OUTPUT_BOX.TabIndex = 10;
            this.OUTPUT_BOX.Text = "";
            // 
            // RETRIEVE_DATA_BUTTON
            // 
            this.RETRIEVE_DATA_BUTTON.Location = new System.Drawing.Point(325, 296);
            this.RETRIEVE_DATA_BUTTON.Name = "RETRIEVE_DATA_BUTTON";
            this.RETRIEVE_DATA_BUTTON.Size = new System.Drawing.Size(104, 23);
            this.RETRIEVE_DATA_BUTTON.TabIndex = 11;
            this.RETRIEVE_DATA_BUTTON.Text = "Retrieve Data";
            this.RETRIEVE_DATA_BUTTON.UseVisualStyleBackColor = true;
            this.RETRIEVE_DATA_BUTTON.Click += new System.EventHandler(this.RETRIEVE_DATA_BUTTON_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 438);
            this.Controls.Add(this.RETRIEVE_DATA_BUTTON);
            this.Controls.Add(this.OUTPUT_BOX);
            this.Controls.Add(this.HOURS_VAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PAY_RATE_VAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STORE_DATA_BUTTON);
            this.Controls.Add(this.NUMBER_VAL);
            this.Controls.Add(this.NUMBER);
            this.Controls.Add(this.NAME_VAL);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "App";
            this.Text = "Employee Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.App_FormClosed);
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox NAME_VAL;
        private System.Windows.Forms.Label NUMBER;
        private System.Windows.Forms.TextBox NUMBER_VAL;
        private System.Windows.Forms.Button STORE_DATA_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PAY_RATE_VAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HOURS_VAL;
        private System.Windows.Forms.RichTextBox OUTPUT_BOX;
        private System.Windows.Forms.Button RETRIEVE_DATA_BUTTON;
    }
}

