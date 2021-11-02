using LHBeverage.Model;
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
                AddNameTopping_tb.Text = toppingEdit.ToppingName;
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
            if(AddNameTopping_tb.Text == "")
            {
                MessageBox.Show("Please enter topping name");
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
                    Topping topping = new Topping();
                    topping.IDCate = key;
                    topping.ToppingName = AddNameTopping_tb.Text;

                    ToppingConnect.CreateTopping(topping);
                    MessageBox.Show("Add topping success");
                    LoadToppingInListPanelByCate(key);
                    topping.ToppingName = "";
                    try
                    {

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
                    int key = Convert.ToInt32(((KeyValuePair<string, string>)Category_cb.SelectedItem).Key);
                    toppingEditTmp.IDCate = key;
                    toppingEditTmp.ToppingName = AddNameTopping_tb.Text;
                    ToppingConnect.UpdateTopping(toppingEditTmp);
                    MessageBox.Show("Update successfull");
                    LoadToppingInListPanelByCate(key);
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
