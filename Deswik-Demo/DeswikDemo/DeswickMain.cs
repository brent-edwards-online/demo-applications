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
        public DeswickMain()
        {
            InitializeComponent();

            this.Icon = new Icon(@".\assets\beol-logo.ico");
            this.Text = "Deswick Desktop Demo";
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            using (var context = new DataAccess.Entities.RecipeDbContext())
            {
                try
                {
                    DataAccess.Repositories.RecipeRepository repo = new DataAccess.Repositories.RecipeRepository(context);
                    DataAccess.Entities.Recipe r = new DataAccess.Entities.Recipe();
                    r.name = this.txtRecipeName.Text;
                    repo.Create(r);
                    DataAccess.Repositories.UnitOfWork u = new DataAccess.Repositories.UnitOfWork(context);
                    u.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
