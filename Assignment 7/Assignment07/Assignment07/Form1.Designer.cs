namespace Assignment07
{
    partial class TuitionCalc
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
            this.STUDENT_ID_TAG = new System.Windows.Forms.Label();
            this.STUDENT_NAME_TAG = new System.Windows.Forms.Label();
            this.RESIDENCY_TAG = new System.Windows.Forms.Label();
            this.CREDITS_TAG = new System.Windows.Forms.Label();
            this.TUITION_TAG = new System.Windows.Forms.Label();
            this.STUDENT_ID_TEXTBOX = new System.Windows.Forms.TextBox();
            this.STUDENT_NAME_TEXTBOX = new System.Windows.Forms.TextBox();
            this.CREDITS_TEXTBOX = new System.Windows.Forms.TextBox();
            this.TUITION_TEXTBOX = new System.Windows.Forms.TextBox();
            this.RESIDENT_RADIO_BUTTON = new System.Windows.Forms.RadioButton();
            this.NON_RESIDENT_RADIO_BUTTON = new System.Windows.Forms.RadioButton();
            this.CALC_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STUDENT_ID_TAG
            // 
            this.STUDENT_ID_TAG.AutoSize = true;
            this.STUDENT_ID_TAG.Location = new System.Drawing.Point(13, 30);
            this.STUDENT_ID_TAG.Name = "STUDENT_ID_TAG";
            this.STUDENT_ID_TAG.Size = new System.Drawing.Size(74, 17);
            this.STUDENT_ID_TAG.TabIndex = 0;
            this.STUDENT_ID_TAG.Tag = "StudID";
            this.STUDENT_ID_TAG.Text = "Student ID";
            // 
            // STUDENT_NAME_TAG
            // 
            this.STUDENT_NAME_TAG.AutoSize = true;
            this.STUDENT_NAME_TAG.Location = new System.Drawing.Point(12, 67);
            this.STUDENT_NAME_TAG.Name = "STUDENT_NAME_TAG";
            this.STUDENT_NAME_TAG.Size = new System.Drawing.Size(98, 17);
            this.STUDENT_NAME_TAG.TabIndex = 1;
            this.STUDENT_NAME_TAG.Tag = "StudName";
            this.STUDENT_NAME_TAG.Text = "Student Name";
            // 
            // RESIDENCY_TAG
            // 
            this.RESIDENCY_TAG.AutoSize = true;
            this.RESIDENCY_TAG.Location = new System.Drawing.Point(16, 105);
            this.RESIDENCY_TAG.Name = "RESIDENCY_TAG";
            this.RESIDENCY_TAG.Size = new System.Drawing.Size(74, 17);
            this.RESIDENCY_TAG.TabIndex = 2;
            this.RESIDENCY_TAG.Text = "Residency";
            // 
            // CREDITS_TAG
            // 
            this.CREDITS_TAG.AutoSize = true;
            this.CREDITS_TAG.Location = new System.Drawing.Point(16, 154);
            this.CREDITS_TAG.Name = "CREDITS_TAG";
            this.CREDITS_TAG.Size = new System.Drawing.Size(52, 17);
            this.CREDITS_TAG.TabIndex = 3;
            this.CREDITS_TAG.Text = "Credits";
            // 
            // TUITION_TAG
            // 
            this.TUITION_TAG.AutoSize = true;
            this.TUITION_TAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUITION_TAG.Location = new System.Drawing.Point(16, 196);
            this.TUITION_TAG.Name = "TUITION_TAG";
            this.TUITION_TAG.Size = new System.Drawing.Size(58, 17);
            this.TUITION_TAG.TabIndex = 4;
            this.TUITION_TAG.Text = "Tuition";
            // 
            // STUDENT_ID_TEXTBOX
            // 
            this.STUDENT_ID_TEXTBOX.Location = new System.Drawing.Point(117, 25);
            this.STUDENT_ID_TEXTBOX.Name = "STUDENT_ID_TEXTBOX";
            this.STUDENT_ID_TEXTBOX.Size = new System.Drawing.Size(100, 22);
            this.STUDENT_ID_TEXTBOX.TabIndex = 5;
            this.STUDENT_ID_TEXTBOX.TextChanged += new System.EventHandler(this.STUDENT_ID_TEXTBOX_TextChanged);
            this.STUDENT_ID_TEXTBOX.Enter += new System.EventHandler(this.STUDENT_ID_TEXTBOX_TextChanged);
            // 
            // STUDENT_NAME_TEXTBOX
            // 
            this.STUDENT_NAME_TEXTBOX.Location = new System.Drawing.Point(117, 67);
            this.STUDENT_NAME_TEXTBOX.Name = "STUDENT_NAME_TEXTBOX";
            this.STUDENT_NAME_TEXTBOX.Size = new System.Drawing.Size(100, 22);
            this.STUDENT_NAME_TEXTBOX.TabIndex = 6;
            this.STUDENT_NAME_TEXTBOX.TextChanged += new System.EventHandler(this.STUDENT_NAME_TEXTBOX_TextChanged);
            // 
            // CREDITS_TEXTBOX
            // 
            this.CREDITS_TEXTBOX.Location = new System.Drawing.Point(117, 148);
            this.CREDITS_TEXTBOX.Name = "CREDITS_TEXTBOX";
            this.CREDITS_TEXTBOX.Size = new System.Drawing.Size(100, 22);
            this.CREDITS_TEXTBOX.TabIndex = 7;
            this.CREDITS_TEXTBOX.TextChanged += new System.EventHandler(this.CREDITS_TEXTBOX_TextChanged);
            // 
            // TUITION_TEXTBOX
            // 
            this.TUITION_TEXTBOX.Location = new System.Drawing.Point(117, 190);
            this.TUITION_TEXTBOX.Name = "TUITION_TEXTBOX";
            this.TUITION_TEXTBOX.ReadOnly = true;
            this.TUITION_TEXTBOX.Size = new System.Drawing.Size(100, 22);
            this.TUITION_TEXTBOX.TabIndex = 8;
            this.TUITION_TEXTBOX.TextChanged += new System.EventHandler(this.TUITION_TEXTBOX_TextChanged);
            // 
            // RESIDENT_RADIO_BUTTON
            // 
            this.RESIDENT_RADIO_BUTTON.AutoSize = true;
            this.RESIDENT_RADIO_BUTTON.Location = new System.Drawing.Point(117, 103);
            this.RESIDENT_RADIO_BUTTON.Name = "RESIDENT_RADIO_BUTTON";
            this.RESIDENT_RADIO_BUTTON.Size = new System.Drawing.Size(85, 21);
            this.RESIDENT_RADIO_BUTTON.TabIndex = 9;
            this.RESIDENT_RADIO_BUTTON.TabStop = true;
            this.RESIDENT_RADIO_BUTTON.Text = "Resident";
            this.RESIDENT_RADIO_BUTTON.UseVisualStyleBackColor = true;
            this.RESIDENT_RADIO_BUTTON.CheckedChanged += new System.EventHandler(this.RESIDENT_RADIO_BUTTON_CheckedChanged);
            // 
            // NON_RESIDENT_RADIO_BUTTON
            // 
            this.NON_RESIDENT_RADIO_BUTTON.AutoSize = true;
            this.NON_RESIDENT_RADIO_BUTTON.Location = new System.Drawing.Point(224, 105);
            this.NON_RESIDENT_RADIO_BUTTON.Name = "NON_RESIDENT_RADIO_BUTTON";
            this.NON_RESIDENT_RADIO_BUTTON.Size = new System.Drawing.Size(116, 21);
            this.NON_RESIDENT_RADIO_BUTTON.TabIndex = 10;
            this.NON_RESIDENT_RADIO_BUTTON.TabStop = true;
            this.NON_RESIDENT_RADIO_BUTTON.Text = "Non-Resident";
            this.NON_RESIDENT_RADIO_BUTTON.UseVisualStyleBackColor = true;
            this.NON_RESIDENT_RADIO_BUTTON.CheckedChanged += new System.EventHandler(this.NON_RESIDENT_RADIO_BUTTON_CheckedChanged);
            // 
            // CALC_BUTTON
            // 
            this.CALC_BUTTON.Location = new System.Drawing.Point(224, 218);
            this.CALC_BUTTON.Name = "CALC_BUTTON";
            this.CALC_BUTTON.Size = new System.Drawing.Size(86, 23);
            this.CALC_BUTTON.TabIndex = 11;
            this.CALC_BUTTON.Text = "Calculate";
            this.CALC_BUTTON.UseVisualStyleBackColor = true;
            this.CALC_BUTTON.Click += new System.EventHandler(this.CALC_BUTTON_Click);
            // 
            // TuitionCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 253);
            this.Controls.Add(this.CALC_BUTTON);
            this.Controls.Add(this.NON_RESIDENT_RADIO_BUTTON);
            this.Controls.Add(this.RESIDENT_RADIO_BUTTON);
            this.Controls.Add(this.TUITION_TEXTBOX);
            this.Controls.Add(this.CREDITS_TEXTBOX);
            this.Controls.Add(this.STUDENT_NAME_TEXTBOX);
            this.Controls.Add(this.STUDENT_ID_TEXTBOX);
            this.Controls.Add(this.TUITION_TAG);
            this.Controls.Add(this.CREDITS_TAG);
            this.Controls.Add(this.RESIDENCY_TAG);
            this.Controls.Add(this.STUDENT_NAME_TAG);
            this.Controls.Add(this.STUDENT_ID_TAG);
            this.Name = "TuitionCalc";
            this.Text = "Student Tuition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STUDENT_ID_TAG;
        private System.Windows.Forms.Label STUDENT_NAME_TAG;
        private System.Windows.Forms.Label RESIDENCY_TAG;
        private System.Windows.Forms.Label CREDITS_TAG;
        private System.Windows.Forms.Label TUITION_TAG;
        private System.Windows.Forms.TextBox STUDENT_ID_TEXTBOX;
        private System.Windows.Forms.TextBox STUDENT_NAME_TEXTBOX;
        private System.Windows.Forms.TextBox CREDITS_TEXTBOX;
        private System.Windows.Forms.TextBox TUITION_TEXTBOX;
        private System.Windows.Forms.RadioButton RESIDENT_RADIO_BUTTON;
        private System.Windows.Forms.RadioButton NON_RESIDENT_RADIO_BUTTON;
        private System.Windows.Forms.Button CALC_BUTTON;
    }
}

