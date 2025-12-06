using MaterialSkin;
using MaterialSkin.Controls;
using CapaNegocios.Servicios;
using CapaNegocios.Entidades;
using CapaNegocios.Exepciones;

namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            // Configurar MaterialSkin
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            // --- CONFIGURACIÓN CON COLORES VERDES ---
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Green700,
                MaterialSkin.Primary.Green900,
                MaterialSkin.Primary.Green500,
                MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE
            );

        }


        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "Buscar Producto")
            {
                txtBuscarProducto.Text = "";
                txtBuscarProducto.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "")
            {
                txtBuscarProducto.Text = "Buscar Producto";
                txtBuscarProducto.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscarPorCodigo_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPorCodigo.Text == "Ingresa el Codigo")
            {
                txtBuscarPorCodigo.Text = "";
                txtBuscarPorCodigo.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscarPorCodigo_Leave(object sender, EventArgs e)
        {
            if (txtBuscarPorCodigo.Text == "")
            {
                txtBuscarPorCodigo.Text = "Ingresa el Codigo";
                txtBuscarPorCodigo.ForeColor = Color.LightGray;
            }
        }

        private void txtRncCliente_Enter(object sender, EventArgs e)
        {
            if (txtRncCliente.Text == "Ingrese RNC del Cliente")
            {
                txtRncCliente.Text = "";
                txtRncCliente.ForeColor = Color.LightGray;
            }
        }

        private void txtRncCliente_Leave(object sender, EventArgs e)
        {
            if (txtRncCliente.Text == "")
            {
                txtRncCliente.Text = "Ingrese RNC del Cliente";
                txtRncCliente.ForeColor = Color.LightGray;
            }
        }
    }
}
