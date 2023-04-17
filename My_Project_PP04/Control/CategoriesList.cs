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
    public partial class CategoriesList : UserControl
    {
        public CategoriesList()
        {
            InitializeComponent();
            Program.ThisMain.CategoriesList = this;
        }

        private void CategoriesList_Load(object sender, EventArgs e)
        {
            SQLCategories();
        }

        Categories categories;
        public async void SQLCategories()
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select *, Name as CategorieName, SCR as CategorieSCR from Categories");
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

            dataSet.Tables[0].TableName = "Category";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            categories = JsonConvert.DeserializeObject<Categories>(json, settings);
            ShowCategories();
        }


        public async void ShowCategories()
        {
     

            List<CategoriesListItems> CategoriesListItems = new List<CategoriesListItems>();
          
            await Task.Run(() => {
                for (int i = 0; i < categories.Category.Count; i++)
                {
                    CategoriesListItems ServicesListItems = new CategoriesListItems(this, categories.Category[i]);
                    ServicesListItems.Name = "CategoriesListItems" + i;
                    CategoriesListItems.Add(ServicesListItems);
                   
                }
            });

            flowLayoutPanelProductList.Visible = false;
            flowLayoutPanelProductList.Controls.Clear();
            for (int i = 0; i < CategoriesListItems.Count; i++)
            {
                flowLayoutPanelProductList.Controls.Add(CategoriesListItems[i]);
            }
            await Task.Delay(10);

            flowLayoutPanelProductList.Visible = true;
           

        }
    }
}
