using DataAccessLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SearchProduct : Form
    {
        ProductContainer pc = new ProductContainer();
        CategoryContainer cc = new CategoryContainer();
        public SearchProduct()
        {
            InitializeComponent();
            cbxFilter.Items.AddRange(cc.GetAll().Select(x => x.Name).ToArray());
        }

        private void tbZoeken_TextChanged(object sender, EventArgs e)
        {
            string invoer = tbZoeken.Text.ToLower();
            lbxMatch.Items.Clear();
            if (cbxFilter.SelectedItem == null)
            {
                lbxMatch.Items.AddRange(pc.GetAll().FindAll(Product => Product.Name.ToLower().Contains(invoer) || Product.Barcode.ToLower().Contains(invoer)).ToArray());
            }
            else
            {
                lbxMatch.Items.AddRange(pc.GetListOfProductsOnFilter(invoer,cbxFilter.Text).Select(Product => Product.ToString()).ToArray());
            }
        }

        private void Filteren_Click(object sender, EventArgs e)
        {
            lbxMatch.Items.Clear();
            if (tbZoeken.Text != "")
            {
                lbxMatch.Items.AddRange(pc.GetListOfProductsOnFilter(tbZoeken.Text.ToLower(),cbxFilter.Text)/*.FindAll(Product => Product.Name == cbxFilter.SelectedItem.ToString())*/.ToArray());
            }
            else
            {
                lbxMatch.Items.AddRange(pc.GetAll().FindAll(Product => Product.Category.Name == cbxFilter.SelectedItem.ToString()).ToArray());
            }
        }
    }
}
