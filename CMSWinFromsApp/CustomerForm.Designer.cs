namespace CMSWinFromsApp
{
    partial class CustomerForm
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
            lblCarNo = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblMake = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // lblCarNo
            // 
            lblCarNo.AutoSize = true;
            lblCarNo.Location = new Point(137, 93);
            lblCarNo.Name = "lblCarNo";
            lblCarNo.Size = new Size(70, 24);
            lblCarNo.TabIndex = 0;
            lblCarNo.Text = "Car No";
            lblCarNo.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(137, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(421, 93);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 24);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(421, 189);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(58, 24);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(224, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(529, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(529, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(224, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(95, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(262, 302);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(423, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(597, 302);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(95, 382);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(112, 34);
            btnPrevious.TabIndex = 12;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(597, 382);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(262, 382);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 30);
            textBox5.TabIndex = 14;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(textBox5);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblMake);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblCarNo);
            Name = "CustomerForm";
            Text = " ";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarNo;
        private Label lblName;
        private Label lblAddress;
        private Label lblMake;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnSave;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExit;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox textBox5;
    }
}