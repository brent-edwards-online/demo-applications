using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeswikDemo
{
    public partial class DeswickMain : Form
    {
        RecipeDbContext _context;

        public DeswickMain()
        {
            InitializeComponent();

            this.Icon = new Icon(@".\assets\beol-logo.ico");
            this.Text = "Deswick Desktop Demo";

            _context = new RecipeDbContext();


        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.Repositories.RecipeRepository repo = new DataAccess.Repositories.RecipeRepository(_context);
                DataAccess.Entities.Recipe r = new DataAccess.Entities.Recipe();
                r.name = this.txtRecipeName.Text;
                repo.Create(r);
                DataAccess.Repositories.UnitOfWork u = new DataAccess.Repositories.UnitOfWork(_context);
                u.SaveChanges();
                this.dgRecipe.DataSource = this._context.Recipes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeswickMain_Load(object sender, EventArgs e)
        {
            this.dgRecipe.DataSource = this._context.Recipes.ToList();
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            UnitOfWork u = new UnitOfWork(_context);
            u.SaveChanges();
        }
    }
}
