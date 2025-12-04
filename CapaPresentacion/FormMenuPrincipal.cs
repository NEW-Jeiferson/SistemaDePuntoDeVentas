using MaterialSkin;
using MaterialSkin.Controls;
namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            // Configurar MaterialSkin
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this); // 'this' se refiere a tu formulario actual
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            // --- CONFIGURACIÓN CON COLORES VERDES ---
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Green700,      // Primary Color (el color principal, más oscuro)
                MaterialSkin.Primary.Green900,
                MaterialSkin.Primary.Green500,
                MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE
            );

            // Cambiar color del label manualmente
            //lblNombreC.ForeColor = Color.White;
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
    }
}
