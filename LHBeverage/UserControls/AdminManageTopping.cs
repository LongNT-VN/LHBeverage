﻿using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.UserControls
{
   
    public partial class AdminManageTopping : UserControl
    {
        public static AdminManageTopping instance;
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        List<Category> categories;
        Topping toppingEditTmp;
        public AdminManageTopping()
        {
            InitializeComponent();
            loadCategoryInComboBox();
            instance = this;
            int idCate = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
            LoadToppingInListPanelByCate(idCate);
            setMode();
        }
        public void setMode()
        {
            if(PublicParam.ligthMode == true)
            {
                this.BackColor = Color.FromArgb(209, 218, 235);
                panelAddTopping.BackColor = Color.White;
                ListTopping_flowpanel.BackColor = Color.WhiteSmoke;
                toppingPrice_lbl.ForeColor = Color.Black;
                lbl_categortName.ForeColor = Color.Black;
                NameToppings_lbl.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                panelAddTopping.BackColor = Color.Black;
                ListTopping_flowpanel.BackColor = Color.Black;
                toppingPrice_lbl.ForeColor = Color.White;
                lbl_categortName.ForeColor = Color.White;
                NameToppings_lbl.ForeColor = Color.White;
            }
        }
        bool checkNumber(string text)
        {
            int outValue = 0;
            bool isNumber = false;
            isNumber = int.TryParse(text, out outValue);
            return isNumber;
        }
        // Load category từ CSDL đổ vào combobox:
        private void loadCategoryInComboBox()
        {
            categories = CategoryConnect.LoadCategory();
            // create Dictionnary comboSource to 
            comboSource.Add("0", "Tất cả");
            foreach (Category category in categories)
            {
                comboSource.Add(category.IDCate.ToString(), category.Name);
            }
            Category_cb.DataSource = new BindingSource(comboSource, null);
            Category_cb.DisplayMember = "Value";
            Category_cb.ValueMember = "Key"; 
        }
        private void LoadToppingInListPanelByCate(int idCate)
        {
            List<Topping> toppings;
            ListTopping_flowpanel.Controls.Clear();
            if (idCate == 0)
            {
                toppings = ToppingConnect.LoadTopping();
                List<Category> cates = CategoryConnect.LoadCategory();
                foreach(Category category in cates)
                {
                    AdminCardCateForTopping adminCardCateForTopping = new AdminCardCateForTopping(category.Name);
                    ListTopping_flowpanel.Controls.Add(adminCardCateForTopping);
                    foreach (Topping topping in toppings)
                    {
                        if(topping.IDCate == category.IDCate)
                        {
                            AdminCardTopping adminCardTopping = new AdminCardTopping(topping);
                            ListTopping_flowpanel.Controls.Add(adminCardTopping);
                        }
                      
                    }
                }
               
            }
            else
            {
                toppings = ToppingConnect.SelectToppingByCate(idCate);
                //List<Category> cates = CategoryConnect.LoadCategory();
                Category category = CategoryConnect.SelectCategory(idCate);
                AdminCardCateForTopping adminCardCateForTopping = new AdminCardCateForTopping(category.Name);
                ListTopping_flowpanel.Controls.Add(adminCardCateForTopping);
                foreach (Topping topping in toppings)
                {
                    AdminCardTopping adminCardTopping = new AdminCardTopping(topping);
                    ListTopping_flowpanel.Controls.Add(adminCardTopping);
                }
            }
         

        }
        public void renderToppingEdit(Topping toppingEdit)
        { 
                NameTopping_tb.Text = toppingEdit.ToppingName;
                PriceTopping_tb.Text = toppingEdit.Price.ToString();
                Category_cb.SelectedValue = toppingEdit.IDCate.ToString();
                toppingEditTmp = toppingEdit;
        }
        
        //-----------------------------Event----------------------------------------------
        private void Category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idCate = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
            LoadToppingInListPanelByCate(idCate);
        }

        private void AddCate_btn_Click(object sender, EventArgs e)
        {
            if (NameTopping_tb.Text == "" || PriceTopping_tb.Text == "")
            {
                MessageBox.Show("Please enter topping infor fully");
            }
            else if (!checkNumber(PriceTopping_tb.Text))
            {
                MessageBox.Show("Please enter Topping infor correct format");
            }
            else
            {
                
                int key = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
                if (key == 0)
                {
                    MessageBox.Show("Please choose category for topping");
                }
                else
                {
                    
                    try
                    {
                        Topping topping = new Topping();
                        topping.IDCate = key;
                        topping.ToppingName = NameTopping_tb.Text;
                        topping.Price = Convert.ToInt32(PriceTopping_tb.Text);
                        ToppingConnect.CreateTopping(topping);
                        MessageBox.Show("Add topping success");
                        LoadToppingInListPanelByCate(key);
                        //topping.ToppingName = "";
                        //topping.Price = 0;
                        NameTopping_tb.Text = "";
                        PriceTopping_tb.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void UpdateCate_btn_Click(object sender, EventArgs e)
        {
            if(toppingEditTmp != null)
            {
                try
                {
                    if(NameTopping_tb.Text == "" || PriceTopping_tb.Text=="")
                    {
                        MessageBox.Show("Please enter topping infor fully");
                    }
                    else if (!checkNumber(PriceTopping_tb.Text))
                    {
                        MessageBox.Show("Please enter Topping infor correct format");
                    }
                    else
                    {
                        int key = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
                        if (key == 0)
                        {
                            MessageBox.Show("Please choose category for topping");
                        }
                        else
                        {
                            toppingEditTmp.IDCate = key;
                            toppingEditTmp.ToppingName = NameTopping_tb.Text;
                            toppingEditTmp.Price = Convert.ToInt32(PriceTopping_tb.Text);
                            ToppingConnect.UpdateTopping(toppingEditTmp);
                            MessageBox.Show("Update successfull");
                            LoadToppingInListPanelByCate(key);
                        }
                       
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cannot update Topping");
            }
        }
        public void Delete_Topping(Topping toppingDelete)
        {
            try
            {
                int key = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
                ToppingConnect.DeleteTopping(toppingDelete);
           
                LoadToppingInListPanelByCate(key);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
