using System;
using System.Windows.Forms;
using Core.Business.DependencyResolvers.Ninject;
using EMarket.Business.Abstract;
using EMarket.Entity.Concrete;
using EMarket.WindowsFormUI.Helper;
using Ninject.Modules;

namespace EMarket.WindowsFormUI
{
    public partial class UpdateProducts : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly NinjectModule _module;
        public UpdateProducts(NinjectModule module)
        {
            _module = module;
            _productService = InstanceFactory.GetInstance<IProductService>(_module);
            _categoryService = InstanceFactory.GetInstance<ICategoryService>(_module);
            InitializeComponent();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadAddCategories();
            LoadUpdateCategories();
            LoadSearchByCategories();
        }

        private void LoadSearchByCategories()
        {
            var categories = _categoryService.GetAll();
            categories.Insert(0,new Category()
            {
                CategoryName = "All products",
                Id=0
            });
            cbxSearchByCategoryId.DataSource = categories;
            cbxSearchByCategoryId.DisplayMember = "CategoryName";
            cbxSearchByCategoryId.ValueMember = "Id";
        }

        private void LoadUpdateCategories()
        {
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "Id";
        }

        private void LoadAddCategories()
        {
            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                var newProduct = new Product()
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = tbxAddName.Text,
                    StockAmount = Convert.ToInt16(tbxAddUnitInStock.Text),
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text)
                };
                _productService.Add(newProduct);
                LoadProducts();
                MessageBox.Show(newProduct.ProductName + @" " + @"Added!");
            });
            
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            if (row == null) return;
            tbxUpdateName.Text = row.Cells[2].Value.ToString();
            tbxUpdateUnitInStock.Text = row.Cells[4].Value.ToString();
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[1].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                if (dgwProducts.CurrentRow != null)
                {
                    var newProduct = new Product()
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                        ProductName = tbxUpdateName.Text,
                        StockAmount = Convert.ToInt16(tbxUpdateUnitInStock.Text),
                        UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)
                    };
                    _productService.Update(newProduct);
                    LoadProducts();
                    MessageBox.Show(newProduct.ProductName + @" " + @"Updated!");
                }
            });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                if (dgwProducts.CurrentRow != null)
                {
                    var newProduct = new Product()
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        ProductName = tbxUpdateName.Text,
                    };
                    _productService.Delete(newProduct);
                    LoadProducts();
                    MessageBox.Show(newProduct.ProductName + @" " + @"Deleted!");
                }
            });
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var name = tbxSearchByName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                dgwProducts.DataSource = _productService.GetByName(name);
            }
            else
            {
                LoadProducts();
            }
            
        }

        private void cbxSearchByCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var categoryId = Convert.ToInt32(cbxSearchByCategoryId.SelectedValue);
                if (categoryId==0)
                {
                    LoadProducts();
                }
                else
                {
                    dgwProducts.DataSource = _productService.GetByCategoryId(categoryId);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProducts = new MainMenu(_module);
            updateProducts.ShowDialog();
            this.Close();
        }
    }
}
