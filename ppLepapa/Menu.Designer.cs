namespace ppLepapa
{
    partial class Menu
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonObject = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(117, 270);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(164, 47);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Администратор";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Location = new System.Drawing.Point(345, 270);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(171, 47);
            this.buttonTeacher.TabIndex = 1;
            this.buttonTeacher.Text = "Учитель";
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonObject
            // 
            this.buttonObject.Location = new System.Drawing.Point(578, 270);
            this.buttonObject.Name = "buttonObject";
            this.buttonObject.Size = new System.Drawing.Size(157, 47);
            this.buttonObject.TabIndex = 2;
            this.buttonObject.Text = "Предмет";
            this.buttonObject.UseVisualStyleBackColor = true;
            this.buttonObject.Click += new System.EventHandler(this.buttonObject_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(345, 374);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 45);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ppLepapa.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(117, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonObject);
            this.Controls.Add(this.buttonTeacher);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonObject;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}