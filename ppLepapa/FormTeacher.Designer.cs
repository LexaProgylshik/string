namespace ppLepapa
{
    partial class FormTeacher
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
            this.textBoxЭлектроннаяПочта = new System.Windows.Forms.TextBox();
            this.textBoxИмя = new System.Windows.Forms.TextBox();
            this.textBoxТелефон = new System.Windows.Forms.TextBox();
            this.textBoxЛогин = new System.Windows.Forms.TextBox();
            this.textBoxПароль = new System.Windows.Forms.TextBox();
            this.textBoxОтчество = new System.Windows.Forms.TextBox();
            this.textBoxФамилия = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxЭлектроннаяПочта
            // 
            this.textBoxЭлектроннаяПочта.Location = new System.Drawing.Point(29, 257);
            this.textBoxЭлектроннаяПочта.Name = "textBoxЭлектроннаяПочта";
            this.textBoxЭлектроннаяПочта.Size = new System.Drawing.Size(100, 20);
            this.textBoxЭлектроннаяПочта.TabIndex = 0;
            // 
            // textBoxИмя
            // 
            this.textBoxИмя.Location = new System.Drawing.Point(29, 127);
            this.textBoxИмя.Name = "textBoxИмя";
            this.textBoxИмя.Size = new System.Drawing.Size(100, 20);
            this.textBoxИмя.TabIndex = 1;
            // 
            // textBoxТелефон
            // 
            this.textBoxТелефон.Location = new System.Drawing.Point(29, 209);
            this.textBoxТелефон.Name = "textBoxТелефон";
            this.textBoxТелефон.Size = new System.Drawing.Size(100, 20);
            this.textBoxТелефон.TabIndex = 2;
            // 
            // textBoxЛогин
            // 
            this.textBoxЛогин.Location = new System.Drawing.Point(674, 111);
            this.textBoxЛогин.Name = "textBoxЛогин";
            this.textBoxЛогин.Size = new System.Drawing.Size(100, 20);
            this.textBoxЛогин.TabIndex = 3;
            // 
            // textBoxПароль
            // 
            this.textBoxПароль.Location = new System.Drawing.Point(674, 161);
            this.textBoxПароль.Name = "textBoxПароль";
            this.textBoxПароль.Size = new System.Drawing.Size(100, 20);
            this.textBoxПароль.TabIndex = 4;
            // 
            // textBoxОтчество
            // 
            this.textBoxОтчество.Location = new System.Drawing.Point(29, 170);
            this.textBoxОтчество.Name = "textBoxОтчество";
            this.textBoxОтчество.Size = new System.Drawing.Size(100, 20);
            this.textBoxОтчество.TabIndex = 5;
            // 
            // textBoxФамилия
            // 
            this.textBoxФамилия.Location = new System.Drawing.Point(29, 84);
            this.textBoxФамилия.Name = "textBoxФамилия";
            this.textBoxФамилия.Size = new System.Drawing.Size(100, 20);
            this.textBoxФамилия.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(135, 72);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 205);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Электронная почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Фамилия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(135, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 47);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(332, 301);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(136, 47);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDell
            // 
            this.buttonDell.Location = new System.Drawing.Point(516, 301);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(149, 47);
            this.buttonDell.TabIndex = 17;
            this.buttonDell.Text = "Удалить";
            this.buttonDell.UseVisualStyleBackColor = true;
            this.buttonDell.Click += new System.EventHandler(this.buttonDell_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxФамилия);
            this.Controls.Add(this.textBoxОтчество);
            this.Controls.Add(this.textBoxПароль);
            this.Controls.Add(this.textBoxЛогин);
            this.Controls.Add(this.textBoxТелефон);
            this.Controls.Add(this.textBoxИмя);
            this.Controls.Add(this.textBoxЭлектроннаяПочта);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxЭлектроннаяПочта;
        private System.Windows.Forms.TextBox textBoxИмя;
        private System.Windows.Forms.TextBox textBoxТелефон;
        private System.Windows.Forms.TextBox textBoxЛогин;
        private System.Windows.Forms.TextBox textBoxПароль;
        private System.Windows.Forms.TextBox textBoxОтчество;
        private System.Windows.Forms.TextBox textBoxФамилия;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDell;
    }
}