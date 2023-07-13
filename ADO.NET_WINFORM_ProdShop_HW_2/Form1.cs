using ADO.NET_WINFORM_ProdShop_HW_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_WINFORM_ProdShop_HW_2
{
    public partial class Form1 : Form
    {
        Controller Controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            checkBoxShowAll.Checked = false;
           
            ComboboxIni();
            lblCaloryIni(comboBoxCategory.SelectedItem.ToString());
            lblAmountCategoryIni();
            txtInsertIni();
            btnDelete.Enabled = true;


        }

        private void checkBoxShowAll_CheckedChanged(object sender, EventArgs e) 
        {
            
            if (checkBoxShowAll.Checked)
            {
                lblCaloryIni();
                lblAmountCategoryIni();
                comboBoxCategory.Enabled = false; //если включен чекбокс - листбокс показывает весь товар
                ListShowALlProducts.DataSource =  Controller.SelectAllName();
                checkBoxColor.Enabled = false;
                comboBoxColor.Enabled = false;
                
            }
            if (!checkBoxShowAll.Checked)
            {
                lblCaloryIni(comboBoxCategory.SelectedItem.ToString());
                lblAmountCategoryIni();
                comboBoxCategory.Enabled = true;//если выключен чекбокс - листбокс показывает показывает выбраную категорию,
                                                //по умолчанию первую
                ListShowALlProducts.DataSource = Controller.SelectType(comboBoxCategory.SelectedItem.ToString());
                checkBoxColor.Enabled = true;
                comboBoxColor.Enabled = true;
                
            }
        }


        //выводит название товара выбранной категории
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            ListShowALlProducts.DataSource = Controller.SelectType(comboBoxCategory.SelectedItem.ToString());
            CheckColor(sender,e);
            

            ListShowALlProductsRefresh(sender,e);
            lblAmountCategoryIni();


        }

        private void ListShowALlProducts_SelectedIndexChanged(object sender, EventArgs e)//Показывает Инфо об отдельном продукте
        {
            
            if (ListShowALlProducts.Items.Count == 0)
            {
                
                listBoxInfo.Visible = false;
                pictureBox1.Visible = true;
                listBoxInfo.BackColor = Color.FromName("White");
                lblAmountCategoryIni();
                btnDelete.Enabled = false;
            }
                
            else
            {
                lblAmountCategoryIni();
                pictureBox1.Visible = false;
                listBoxInfo.Visible = true;
                listBoxInfo.DataSource = Controller.SelectInfoAboutProduct(ListShowALlProducts.SelectedItem.ToString());
                listBoxInfo.BackColor = Color.FromName(Controller.GetColorSelectProduct(ListShowALlProducts.SelectedItem.ToString()));
                btnDelete.Enabled = true ;
            }
           


            if (listBoxInfo.BackColor == Color.FromName("Black"))
            {
                listBoxInfo.ForeColor = Color.FromName("White");
            }
            else
            {
                listBoxInfo.ForeColor = Color.FromName("Black");

            }

           

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

           
            Controller.DelProd(ListShowALlProducts.SelectedItem.ToString());
            RefreshForm();

        }
        private void checkBoxColor_CheckedChanged(object sender, EventArgs e)
        {
            
            ComboBoxColorIni();
            if (checkBoxColor.Checked) 
            {
                comboBoxColor.Enabled = true;
                string type = comboBoxCategory.SelectedItem.ToString();
                string color = comboBoxColor.SelectedItem.ToString();

                ListShowALlProducts.DataSource = Controller.GetProductSelectColorAndName(color, type);
                lblCaloryIni(type , color);
                lblAmountCategoryIni();
            }
            else 
            {
                comboBoxColor.Enabled = false;
                string type = comboBoxCategory.SelectedItem.ToString();
                ListShowALlProducts.DataSource = Controller.SelectType(comboBoxCategory.SelectedItem.ToString()); 
                lblCaloryIni(type);
                lblAmountCategoryIni();
            }

        }



    
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxColor.Checked)
            {

                comboBoxColor.Enabled = true;
                string type = comboBoxCategory.SelectedItem.ToString();
                string color = comboBoxColor.SelectedItem.ToString();
                ListShowALlProducts.DataSource = Controller.GetProductSelectColorAndName(color, type);

                ListShowALlProductsRefresh(sender, e);

                //если выбран цвет и в прод.листе что-=то есть - ставим значение  калорий в лэйбл по цвету и категории
                if (ListShowALlProducts.Items.Count > 0)
                {
                    lblCaloryIni(comboBoxCategory.SelectedItem.ToString(),
                    Controller.GetColorSelectProduct(ListShowALlProducts.SelectedItem.ToString()));
                    
                }
                else lblCaloryIni(comboBoxCategory.SelectedItem.ToString());

            }
            else
            {   //если цвет не выбран - лэймбл  калорий ставим только по категории
                ListShowALlProductsRefresh(sender, e);
                
        
            }
            lblAmountCategoryIni();
            }




        private void CheckColor(object sender, EventArgs e)
        {
            comboBoxColor_SelectedIndexChanged(sender, e);
        
        
        }

        private void ListShowALlProductsRefresh(object sender, EventArgs e)
        {
            ListShowALlProducts_SelectedIndexChanged(sender, e);

        }





        private void lblCaloryIni(string type = null, string color = null)
        {
            if (ListShowALlProducts.Items.Count != 0)
            {
                lblMaxCalory.Text = $"Max Calory = {Controller.GetCaloryFromAll("Max", type, color)}";
                lblMinCalory.Text = $"Min Calory = {Controller.GetCaloryFromAll("Min", type, color)}";
                lblAVGCalory.Text = $"AVG Calory = {Controller.GetCaloryFromAll("AVG", type, color)}";
            }
            else
            {
                lblMaxCalory.Text = "Max Calory = 0";
                lblMinCalory.Text = "Min Calory = 0";
                lblAVGCalory.Text = "AVG Calory = 0";
            }

        }

        private void ComboBoxColorIni()
        {
            comboBoxColor.Enabled = false;
            comboBoxColor.DataSource = Controller.GetColors();

        }





        private void ComboboxIni() //инициализация комбобокса с категориями товаров
        {

            comboBoxCategory.DataSource = Controller.GetCategories();

        }

        private void txtInsertIni()
        {
            txtBoxName.Text = "Name";
            txtBoxType.Text = "Type";
            txtBoxColor.Text = "Color";
            txtBoxCalory.Text = "Calory";
        }

        private void lblAmountCategoryIni()
        {
            lblAmountCategory.Text = $"Количество наименований категории : {ListShowALlProducts.Items.Count}";
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxName.Text!="" || txtBoxName.Text != "Name")
            {
               Controller.product.Name = txtBoxName.Text;
            }
        }

        private void txtBoxType_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxType.Text != "" || txtBoxType.Text != "Type")
            {
                Controller.product.Type = txtBoxType.Text;
            }
        }

        private void txtBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxColor.Text != "" || txtBoxColor.Text != "Color")
            {
                Controller.product.Color = txtBoxColor.Text;
            }
        }

        private void txtBoxCalory_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCalory.Text != "" || txtBoxCalory.Text != "Calory")
            {
                int res;
                if(int.TryParse(txtBoxCalory.Text,out res))
                             Controller.product.Calory = res;
                
            }
        }


        private void txtBoxName_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtBoxName.Text == "Name")
                txtBoxName.Text = "";
        }

        private void txtBoxName_MouseLeave(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
                txtBoxName.Text = "Name";
        }

        private void txtBoxType_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtBoxType.Text == "Type")
                txtBoxType.Text = "";
        }

        private void txtBoxType_MouseLeave(object sender, EventArgs e)
        {
            if (txtBoxType.Text == "")
                txtBoxType.Text = "Type";
        }

        private void txtBoxColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtBoxColor.Text == "Color")
                txtBoxColor.Text = "";
        }

        private void txtBoxColor_MouseLeave(object sender, EventArgs e)
        {
            if (txtBoxColor.Text == "")
                txtBoxColor.Text = "Color";
        }

        private void txtBoxCalory_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtBoxCalory.Text == "Calory")
                txtBoxCalory.Text = "";
        }

        private void txtBoxCalory_MouseLeave(object sender, EventArgs e)
        {
            if (txtBoxCalory.Text == "")
                txtBoxCalory.Text = "Calory";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Controller.InsertNew();
             RefreshForm();
        }

       
        
        private void RefreshForm()
        {
            Controller = new Controller();
            checkBoxShowAll.Checked = false;

            ComboboxIni();
            lblCaloryIni(comboBoxCategory.SelectedItem.ToString());
            lblAmountCategoryIni();
            txtInsertIni();


        }

    
    }
}
