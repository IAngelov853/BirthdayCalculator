namespace BirthdayCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            labelResult = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(473, 447);
            button1.Name = "button1";
            button1.Size = new Size(311, 56);
            button1.TabIndex = 0;
            button1.Text = "Изчисли";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(525, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(525, 220);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(584, 321);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(82, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "labelResult";
            labelResult.Click += button1_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(571, 418);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(108, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Изчисти";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1277, 645);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
        private Button buttonClear;
    }
}
