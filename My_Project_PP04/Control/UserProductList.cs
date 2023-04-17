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
    public partial class UserProductList : UserControl
    {
        Category category;
        public UserProductList( )
        {
            InitializeComponent();
            this.category = category;
            //Program.ThisMain.ProductList = this;
     
        }
       

        private void ProductList_Load(object sender, EventArgs e)
        {
            SQLProducts();
        }
        Baskets products;
        public async void SQLProducts()
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select *, Categories.Name as CategorieName, Categories.SCR as CategorieSCR from Basket
                Inner join Product Product on Product.ID = Basket.ProductID
                Inner Join Categories Categories on Categories.ID = Product.Category
                where Basket.UserID = {Data.Data.User.ID}	");
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
                MessageBox.Show("F2");
                return;
            }

            dataSet.Tables[0].TableName = "Basket";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            products = JsonConvert.DeserializeObject<Baskets>(json, settings);
       
            ShowProducts();
        }


        public async void ShowProducts()
        {


            List<UserProductListItems> ProductUserList = new List<UserProductListItems>();

            await Task.Run(() =>
            {
                for (int i = 0; i < products.Basket.Count; i++)
                {
                    UserProductListItems UserProductListItems = new UserProductListItems(this, products.Basket[i]);
                    UserProductListItems.Name = "UserProductListItems" + i;
                    ProductUserList.Add(UserProductListItems);

                }
            });

            flowLayoutPanelProductList.Visible = false;
            flowLayoutPanelProductList.Controls.Clear();
            for (int i = 0; i < ProductUserList.Count; i++)
            {
                flowLayoutPanelProductList.Controls.Add(ProductUserList[i]);
            }
            await Task.Delay(500);

            flowLayoutPanelProductList.Visible = true;


        }
    }
}
