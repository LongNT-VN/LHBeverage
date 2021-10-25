using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls.Component;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LHBeverage.UserControls.PageComponent
{
    public partial class CartPagePanel : UserControl
    {
       
        public CartPagePanel(Cart cart)
        {
            InitializeComponent();
            CreateCartItem(cart);
        }
        private void CreateCartItem(Cart cart)
        {
            List<DetailCart> itemcarts = DetailCartConnect.LoadDetailCart(cart);
            foreach (DetailCart itemcart in itemcarts)
            {
                ItemCart itemCart = new ItemCart(itemcart);
            }
            
        }
    }
}
