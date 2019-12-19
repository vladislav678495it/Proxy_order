namespace Proxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Full_name = new System.Windows.Forms.Label();
            this.txt_Full_name = new System.Windows.Forms.TextBox();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.txt_phone_number = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.list_product_goods = new System.Windows.Forms.ListBox();
            this.lbl_goods = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiving an order";
            // 
            // lbl_Full_name
            // 
            this.lbl_Full_name.AutoSize = true;
            this.lbl_Full_name.Location = new System.Drawing.Point(18, 45);
            this.lbl_Full_name.Name = "lbl_Full_name";
            this.lbl_Full_name.Size = new System.Drawing.Size(69, 17);
            this.lbl_Full_name.TabIndex = 1;
            this.lbl_Full_name.Text = "Full name";
            // 
            // txt_Full_name
            // 
            this.txt_Full_name.Location = new System.Drawing.Point(21, 65);
            this.txt_Full_name.Name = "txt_Full_name";
            this.txt_Full_name.Size = new System.Drawing.Size(120, 22);
            this.txt_Full_name.TabIndex = 2;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Location = new System.Drawing.Point(21, 90);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(101, 17);
            this.lbl_phone_number.TabIndex = 3;
            this.lbl_phone_number.Text = "Phone number";
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.Location = new System.Drawing.Point(21, 110);
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.Size = new System.Drawing.Size(120, 22);
            this.txt_phone_number.TabIndex = 4;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(21, 306);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(120, 30);
            this.btn_input.TabIndex = 5;
            this.btn_input.Text = "input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // list_product_goods
            // 
            this.list_product_goods.FormattingEnabled = true;
            this.list_product_goods.ItemHeight = 16;
            this.list_product_goods.Location = new System.Drawing.Point(21, 204);
            this.list_product_goods.Name = "list_product_goods";
            this.list_product_goods.Size = new System.Drawing.Size(120, 84);
            this.list_product_goods.TabIndex = 6;
            this.list_product_goods.SelectedIndexChanged += new System.EventHandler(this.list_product_goods_SelectedIndexChanged);
            // 
            // lbl_goods
            // 
            this.lbl_goods.AutoSize = true;
            this.lbl_goods.Location = new System.Drawing.Point(21, 184);
            this.lbl_goods.Name = "lbl_goods";
            this.lbl_goods.Size = new System.Drawing.Size(50, 17);
            this.lbl_goods.TabIndex = 7;
            this.lbl_goods.Text = "Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "output data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(21, 139);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(52, 17);
            this.lbl_adress.TabIndex = 12;
            this.lbl_adress.Text = "Adress";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(26, 160);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(115, 22);
            this.txt_adress.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 567);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_goods);
            this.Controls.Add(this.list_product_goods);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txt_phone_number);
            this.Controls.Add(this.lbl_phone_number);
            this.Controls.Add(this.txt_Full_name);
            this.Controls.Add(this.lbl_Full_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Full_name;
        private System.Windows.Forms.TextBox txt_Full_name;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.TextBox txt_phone_number;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox list_product_goods;
        private System.Windows.Forms.Label lbl_goods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.TextBox txt_adress;
    }
}

