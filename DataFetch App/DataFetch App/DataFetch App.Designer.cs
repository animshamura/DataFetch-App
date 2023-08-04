namespace CRUD_APP
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
            this.label1 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.t0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(141, 222);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(257, 23);
            this.t1.TabIndex = 1;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(141, 251);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(257, 23);
            this.t2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(141, 337);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(257, 23);
            this.t5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cell No.";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(141, 280);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(257, 23);
            this.t3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(141, 308);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(257, 23);
            this.t4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(122, 372);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 38);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(31, 12);
            this.Grid.Name = "Grid";
            this.Grid.RowTemplate.Height = 25;
            this.Grid.Size = new System.Drawing.Size(650, 162);
            this.Grid.TabIndex = 8;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(263, 372);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(123, 40);
            this.ShowButton.TabIndex = 10;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(529, 308);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 40);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // t0
            // 
            this.t0.Location = new System.Drawing.Point(141, 193);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(257, 23);
            this.t0.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(529, 265);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(133, 23);
            this.id1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter ID to Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DataFetch App";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox t1;
        private TextBox t2;
        private Label label2;
        private TextBox t5;
        private Label label3;
        private TextBox t3;
        private Label label4;
        private TextBox t4;
        private Label label5;
        private Button SaveButton;
        private DataGridView Grid;
        private Button ShowButton;
        private Button DeleteButton;
        private TextBox t0;
        private Label label6;
        private TextBox id1;
        private Label label7;
    }
}