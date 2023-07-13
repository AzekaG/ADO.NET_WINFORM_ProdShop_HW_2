namespace ADO.NET_WINFORM_ProdShop_HW_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.checkBoxShowAll = new System.Windows.Forms.CheckBox();
            this.ListShowALlProducts = new System.Windows.Forms.ListBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.lblMaxCalory = new System.Windows.Forms.Label();
            this.lblMinCalory = new System.Windows.Forms.Label();
            this.lblAVGCalory = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxColor = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAmountCategory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCalory = new System.Windows.Forms.TextBox();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(57, 12);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // checkBoxShowAll
            // 
            this.checkBoxShowAll.AutoSize = true;
            this.checkBoxShowAll.Location = new System.Drawing.Point(631, 12);
            this.checkBoxShowAll.Name = "checkBoxShowAll";
            this.checkBoxShowAll.Size = new System.Drawing.Size(91, 17);
            this.checkBoxShowAll.TabIndex = 1;
            this.checkBoxShowAll.Text = "Выбрать всё";
            this.checkBoxShowAll.UseVisualStyleBackColor = true;
            this.checkBoxShowAll.CheckedChanged += new System.EventHandler(this.checkBoxShowAll_CheckedChanged);
            // 
            // ListShowALlProducts
            // 
            this.ListShowALlProducts.FormattingEnabled = true;
            this.ListShowALlProducts.Location = new System.Drawing.Point(12, 39);
            this.ListShowALlProducts.Name = "ListShowALlProducts";
            this.ListShowALlProducts.Size = new System.Drawing.Size(166, 420);
            this.ListShowALlProducts.TabIndex = 2;
            this.ListShowALlProducts.SelectedIndexChanged += new System.EventHandler(this.ListShowALlProducts_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(219, 39);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(503, 147);
            this.listBoxInfo.TabIndex = 3;
            // 
            // lblMaxCalory
            // 
            this.lblMaxCalory.AutoSize = true;
            this.lblMaxCalory.Location = new System.Drawing.Point(219, 202);
            this.lblMaxCalory.Name = "lblMaxCalory";
            this.lblMaxCalory.Size = new System.Drawing.Size(35, 13);
            this.lblMaxCalory.TabIndex = 4;
            this.lblMaxCalory.Text = "label1";
            // 
            // lblMinCalory
            // 
            this.lblMinCalory.AutoSize = true;
            this.lblMinCalory.Location = new System.Drawing.Point(219, 215);
            this.lblMinCalory.Name = "lblMinCalory";
            this.lblMinCalory.Size = new System.Drawing.Size(35, 13);
            this.lblMinCalory.TabIndex = 5;
            this.lblMinCalory.Text = "label2";
            // 
            // lblAVGCalory
            // 
            this.lblAVGCalory.AutoSize = true;
            this.lblAVGCalory.Location = new System.Drawing.Point(219, 228);
            this.lblAVGCalory.Name = "lblAVGCalory";
            this.lblAVGCalory.Size = new System.Drawing.Size(35, 13);
            this.lblAVGCalory.TabIndex = 6;
            this.lblAVGCalory.Text = "label3";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(262, 9);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 7;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вид";
            // 
            // checkBoxColor
            // 
            this.checkBoxColor.AutoSize = true;
            this.checkBoxColor.Location = new System.Drawing.Point(205, 11);
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(51, 17);
            this.checkBoxColor.TabIndex = 9;
            this.checkBoxColor.Text = "Цвет";
            this.checkBoxColor.UseVisualStyleBackColor = true;
            this.checkBoxColor.CheckedChanged += new System.EventHandler(this.checkBoxColor_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ADO.NET_WINFORM_ProdShop_HW_2.Properties.Resources.ab67616d0000b2737ba880e00f8f7d9b20785254;
            this.pictureBox1.InitialImage = global::ADO.NET_WINFORM_ProdShop_HW_2.Properties.Resources.ab67616d0000b2737ba880e00f8f7d9b20785254;
            this.pictureBox1.Location = new System.Drawing.Point(219, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblAmountCategory
            // 
            this.lblAmountCategory.AutoSize = true;
            this.lblAmountCategory.Location = new System.Drawing.Point(219, 292);
            this.lblAmountCategory.Name = "lblAmountCategory";
            this.lblAmountCategory.Size = new System.Drawing.Size(210, 13);
            this.lblAmountCategory.TabIndex = 11;
            this.lblAmountCategory.Text = "Количество наименований  категории : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBoxCalory);
            this.groupBox1.Controls.Add(this.txtBoxColor);
            this.groupBox1.Controls.Add(this.txtBoxType);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Location = new System.Drawing.Point(222, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 130);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxCalory
            // 
            this.txtBoxCalory.Location = new System.Drawing.Point(7, 101);
            this.txtBoxCalory.Name = "txtBoxCalory";
            this.txtBoxCalory.Size = new System.Drawing.Size(164, 20);
            this.txtBoxCalory.TabIndex = 3;
            this.txtBoxCalory.TextChanged += new System.EventHandler(this.txtBoxCalory_TextChanged);
            this.txtBoxCalory.MouseLeave += new System.EventHandler(this.txtBoxCalory_MouseLeave);
            this.txtBoxCalory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxCalory_MouseMove);
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Location = new System.Drawing.Point(7, 74);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(164, 20);
            this.txtBoxColor.TabIndex = 2;
            this.txtBoxColor.TextChanged += new System.EventHandler(this.txtBoxColor_TextChanged);
            this.txtBoxColor.MouseLeave += new System.EventHandler(this.txtBoxColor_MouseLeave);
            this.txtBoxColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxColor_MouseMove);
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(7, 47);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.Size = new System.Drawing.Size(164, 20);
            this.txtBoxType.TabIndex = 1;
            this.txtBoxType.TextChanged += new System.EventHandler(this.txtBoxType_TextChanged);
            this.txtBoxType.MouseLeave += new System.EventHandler(this.txtBoxType_MouseLeave);
            this.txtBoxType.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxType_MouseMove);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(7, 20);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            this.txtBoxName.MouseLeave += new System.EventHandler(this.txtBoxName_MouseLeave);
            this.txtBoxName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxName_MouseMove);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAmountCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.lblAVGCalory);
            this.Controls.Add(this.lblMinCalory);
            this.Controls.Add(this.lblMaxCalory);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.ListShowALlProducts);
            this.Controls.Add(this.checkBoxShowAll);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxShowAll;
        private System.Windows.Forms.ListBox ListShowALlProducts;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Label lblMaxCalory;
        private System.Windows.Forms.Label lblMinCalory;
        private System.Windows.Forms.Label lblAVGCalory;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAmountCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCalory;
        private System.Windows.Forms.Button btnDelete;
    }
}

