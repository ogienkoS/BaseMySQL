namespace BaseSQL
{
    partial class wow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.check_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroButton3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аккаунт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(154, 87);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(127, 23);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Удалить ГМ-аккаунт";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(151, 64);
            this.dataGridView1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(185, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(274, 69);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(185, 128);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(96, 23);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Выдать права";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroTextBox3);
            this.groupBox3.Location = new System.Drawing.Point(6, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введи уровень доступа (1-5):";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(6, 19);
            this.metroTextBox3.MaxLength = 1;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(108, 23);
            this.metroTextBox3.TabIndex = 0;
            this.metroTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox3_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введи ID аккаунта:";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(6, 19);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(108, 23);
            this.metroTextBox2.TabIndex = 0;
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.check_btn);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введи имя аккаунта:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(353, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(299, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Гм лвл:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 1;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(6, 19);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox1.TabIndex = 0;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(148, 19);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(127, 23);
            this.check_btn.TabIndex = 2;
            this.check_btn.Text = "Чекнуть ID аккаунта";
            this.check_btn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(348, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "База:";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(393, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(397, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Offline";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(350, 14);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Пинг:";
            // 
            // wow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 334);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wow";
            this.Text = "World Of Warcraft";
            this.Load += new System.EventHandler(this.wow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton check_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}