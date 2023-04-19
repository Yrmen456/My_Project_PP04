using LibraryDataBase;
using My_Project_PP04.Data;
using My_Project_PP04.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Control
{
    public partial class ProductList : UserControl
    {
        Category category;
        public ProductList(Category category)
        {
            InitializeComponent();
            this.category = category;
            Program.ThisMain.ProductList = this;
            Program.ThisMain.panelBtn.Controls.Add(Program.ThisMain.panelTopBtn.panel2);
            Program.ThisMain.panelTopBtn.button4.Click += buttonBack_Click;
            Program.ThisMain.panelTopBtn.button3.Click += buttonBasket_Click;
            Program.ThisMain.panelTopBtn.panel2.Show();
            Program.ThisMain.panelTopBtn.ShowPriceBasket(Program.ThisMain.panelTopBtn.button3,"Корзина");

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.ThisMain.panelTopBtn.panel2.Hide();
            Program.ThisMain.panelControl.Controls.Clear();
            CategoriesList CategoriesList = new CategoriesList();
            CategoriesList.Dock = DockStyle.Fill;
            CategoriesList.Name = "CategoriesList";
            Program.ThisMain.panelControl.Controls.Add(CategoriesList);
            this.Dispose();
        }
        public Basket Basket = new Basket();
        private void buttonBasket_Click(object sender, EventArgs e)
        {
       
            if (Program.Basket.IsDisposed)
            {
                Program.MyApplicationContext.Open(Basket);
            }
            else
            {
                Program.MyApplicationContext.Open(Basket);
                Program.Basket.Focus();
            }

        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            SQLProducts();
        }
        Products products;
        public async void SQLProducts()
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select * from Product where Product.Category = {category.ID}");
            });
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            if (dataSet.Tables.Count <= 0)
            {
                MessageBox.Show("F1");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
              
            }

            dataSet.Tables[0].TableName = "Product";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            products = JsonConvert.DeserializeObject<Products>(json, settings);
            ShowProducts();
        }


        public async void ShowProducts()
        {


            List<ProductListItems> ProductList = new List<ProductListItems>();

            await Task.Run(() => {
                for (int i = 0; i < products.Product.Count; i++)
                {
                    ProductListItems ProductListItems = new ProductListItems(this, products.Product[i]);
                    ProductListItems.Name = "ProductListItems" + i;
                    ProductList.Add(ProductListItems);

                }
            });

            flowLayoutPanelProductList.Visible = false;
            flowLayoutPanelProductList.Controls.Clear();
            for (int i = 0; i < ProductList.Count; i++)
            {
                flowLayoutPanelProductList.Controls.Add(ProductList[i]);
            }
            await Task.Delay(500);

            flowLayoutPanelProductList.Visible = true;


        }
    }
}
