namespace MultiColorModernUI
{
    partial class LoginCard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextResult = new System.Windows.Forms.RichTextBox();
            this.buttonCreateDB = new System.Windows.Forms.Button();
            this.textDatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveAndConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textUserID);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Connection";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(663, 94);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(125, 43);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connet";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password :";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(93, 91);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(217, 20);
            this.textPassword.TabIndex = 6;
            this.textPassword.Text = "12345678";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "User Name :";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(93, 65);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(217, 20);
            this.textUserID.TabIndex = 4;
            this.textUserID.Text = "sa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1433";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port :";
            // 
            // textServerName
            // 
            this.textServerName.Location = new System.Drawing.Point(93, 39);
            this.textServerName.Name = "textServerName";
            this.textServerName.Size = new System.Drawing.Size(217, 20);
            this.textServerName.TabIndex = 1;
            this.textServerName.Text = "DESKTOPCODE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextResult);
            this.groupBox2.Controls.Add(this.buttonCreateDB);
            this.groupBox2.Controls.Add(this.textDatabaseName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Connection";
            // 
            // richTextResult
            // 
            this.richTextResult.Location = new System.Drawing.Point(12, 107);
            this.richTextResult.Name = "richTextResult";
            this.richTextResult.Size = new System.Drawing.Size(776, 192);
            this.richTextResult.TabIndex = 7;
            this.richTextResult.Text = "";
            // 
            // buttonCreateDB
            // 
            this.buttonCreateDB.Enabled = false;
            this.buttonCreateDB.Location = new System.Drawing.Point(102, 57);
            this.buttonCreateDB.Name = "buttonCreateDB";
            this.buttonCreateDB.Size = new System.Drawing.Size(208, 44);
            this.buttonCreateDB.TabIndex = 6;
            this.buttonCreateDB.Text = "Create";
            this.buttonCreateDB.UseVisualStyleBackColor = true;
            this.buttonCreateDB.Click += new System.EventHandler(this.buttonCreateDB_Click);
            // 
            // textDatabaseName
            // 
            this.textDatabaseName.Location = new System.Drawing.Point(102, 31);
            this.textDatabaseName.Name = "textDatabaseName";
            this.textDatabaseName.Size = new System.Drawing.Size(208, 20);
            this.textDatabaseName.TabIndex = 5;
            this.textDatabaseName.Text = "NERP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Databse Name :";
            // 
            // buttonSaveAndConnect
            // 
            this.buttonSaveAndConnect.Location = new System.Drawing.Point(12, 493);
            this.buttonSaveAndConnect.Name = "buttonSaveAndConnect";
            this.buttonSaveAndConnect.Size = new System.Drawing.Size(133, 44);
            this.buttonSaveAndConnect.TabIndex = 7;
            this.buttonSaveAndConnect.Text = "Save and Connect";
            this.buttonSaveAndConnect.UseVisualStyleBackColor = true;
            this.buttonSaveAndConnect.Click += new System.EventHandler(this.buttonSaveAndConnect_Click);
            // 
            // LoginCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.buttonSaveAndConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginCard";
            this.Text = "LoginCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Button buttonCreateDB;
        private System.Windows.Forms.Button buttonSaveAndConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox richTextResult;
    }
}