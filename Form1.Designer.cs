
namespace WinFormGamVector2D
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(13, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Линия",
            "Элипс",
            "Прямоугольник"});
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 52);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 638);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Location = new System.Drawing.Point(667, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 52);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Толщина линии";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(285, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(660, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 61);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Заливка фигуры";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(334, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет линии";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигура";
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 663);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NedoPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
    }
}

