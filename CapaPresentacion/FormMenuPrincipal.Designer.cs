namespace CapaPresentacion
{
    partial class FormMenuPrincipal
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPageInventario = new TabPage();
            btnBuscarProducto = new MaterialSkin.Controls.MaterialButton();
            txtBuscarProducto = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblInventario = new MaterialSkin.Controls.MaterialLabel();
            lblProductoStockMinimo = new MaterialSkin.Controls.MaterialLabel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            tabPageCarrito = new TabPage();
            btnAgregarClienteAlCarrito = new MaterialSkin.Controls.MaterialButton();
            txtRNCdeClienteParaCarrito = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cmbMetodoPago = new MaterialSkin.Controls.MaterialComboBox();
            lblMetodoPago = new MaterialSkin.Controls.MaterialLabel();
            dataGridView3 = new DataGridView();
            btnValidarVenta = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblMontoTotal = new MaterialSkin.Controls.MaterialLabel();
            lblMontoITBIS = new MaterialSkin.Controls.MaterialLabel();
            lblMontoSubtotal = new MaterialSkin.Controls.MaterialLabel();
            lblTotal = new MaterialSkin.Controls.MaterialLabel();
            lblImpuesto = new MaterialSkin.Controls.MaterialLabel();
            lblSubTotal = new MaterialSkin.Controls.MaterialLabel();
            btnQuitarProducto = new MaterialSkin.Controls.MaterialButton();
            btnCancelarVenta = new MaterialSkin.Controls.MaterialButton();
            lblCantidad = new MaterialSkin.Controls.MaterialLabel();
            nmrCantidadProducto = new NumericUpDown();
            btnAgregarAlCarrito = new MaterialSkin.Controls.MaterialButton();
            lblCarrito = new MaterialSkin.Controls.MaterialLabel();
            lblProductosDisponibles = new MaterialSkin.Controls.MaterialLabel();
            txtBuscarPorCodigo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dataGridView4 = new DataGridView();
            btnCodigoProducto = new MaterialSkin.Controls.MaterialButton();
            tabPageReportes = new TabPage();
            lblReporteVentasDia = new MaterialSkin.Controls.MaterialLabel();
            btnRecarcularPlinq = new MaterialSkin.Controls.MaterialButton();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            lblReportesdelDia = new MaterialSkin.Controls.MaterialLabel();
            lblTotalGeneralFinal = new MaterialSkin.Controls.MaterialLabel();
            lblITBISFinal = new MaterialSkin.Controls.MaterialLabel();
            lblSubtotalGenealNumero = new MaterialSkin.Controls.MaterialLabel();
            lblCantidadVentasFinal = new MaterialSkin.Controls.MaterialLabel();
            lblTotalGeneral = new MaterialSkin.Controls.MaterialLabel();
            lblNumeroVentas = new MaterialSkin.Controls.MaterialLabel();
            lblSubTotalGeneral = new MaterialSkin.Controls.MaterialLabel();
            lblITBISGeneral = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lblEstadoCargando = new MaterialSkin.Controls.MaterialLabel();
            lblEstado = new MaterialSkin.Controls.MaterialLabel();
            btnReporte = new MaterialSkin.Controls.MaterialButton();
            lblProgreso = new MaterialSkin.Controls.MaterialLabel();
            prbProgreso = new ProgressBar();
            dtpFecha = new DateTimePicker();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            dgvReporteVentas = new DataGridView();
            tabPageClientes = new TabPage();
            btnQuitarCliente = new MaterialSkin.Controls.MaterialButton();
            btnIngreseCliente = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            cmbIngreseTipoCliente = new MaterialSkin.Controls.MaterialComboBox();
            txtIngreseRNC = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtIngreseNombreCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblIngreseNombre = new MaterialSkin.Controls.MaterialLabel();
            lblIngreseTipoCliente = new MaterialSkin.Controls.MaterialLabel();
            lblIngreseRNC = new MaterialSkin.Controls.MaterialLabel();
            lblClientesRegistrados = new MaterialSkin.Controls.MaterialLabel();
            dataGridView5 = new DataGridView();
            btnBuscarCliente = new MaterialSkin.Controls.MaterialButton();
            txtRncCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialTabControl1.SuspendLayout();
            tabPageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPageReportes.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).BeginInit();
            tabPageClientes.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPageInventario);
            materialTabControl1.Controls.Add(tabPageCarrito);
            materialTabControl1.Controls.Add(tabPageReportes);
            materialTabControl1.Controls.Add(tabPageClientes);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(994, 533);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(986, 505);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageInventario
            // 
            tabPageInventario.Controls.Add(btnBuscarProducto);
            tabPageInventario.Controls.Add(txtBuscarProducto);
            tabPageInventario.Controls.Add(lblInventario);
            tabPageInventario.Controls.Add(lblProductoStockMinimo);
            tabPageInventario.Controls.Add(dataGridView2);
            tabPageInventario.Controls.Add(dataGridView1);
            tabPageInventario.Location = new Point(4, 24);
            tabPageInventario.Name = "tabPageInventario";
            tabPageInventario.Padding = new Padding(3);
            tabPageInventario.Size = new Size(986, 505);
            tabPageInventario.TabIndex = 1;
            tabPageInventario.Text = "Inventario";
            tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProducto.Depth = 0;
            btnBuscarProducto.HighEmphasis = true;
            btnBuscarProducto.Icon = null;
            btnBuscarProducto.Location = new Point(263, 18);
            btnBuscarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.NoAccentTextColor = Color.Empty;
            btnBuscarProducto.Size = new Size(77, 36);
            btnBuscarProducto.TabIndex = 2;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProducto.UseAccentColor = false;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.AllowPromptAsInput = true;
            txtBuscarProducto.AnimateReadOnly = false;
            txtBuscarProducto.AsciiOnly = false;
            txtBuscarProducto.BackgroundImageLayout = ImageLayout.None;
            txtBuscarProducto.BeepOnError = false;
            txtBuscarProducto.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscarProducto.Depth = 0;
            txtBuscarProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProducto.HidePromptOnLeave = false;
            txtBuscarProducto.HideSelection = true;
            txtBuscarProducto.InsertKeyMode = InsertKeyMode.Default;
            txtBuscarProducto.LeadingIcon = null;
            txtBuscarProducto.Location = new Point(6, 11);
            txtBuscarProducto.Mask = "";
            txtBuscarProducto.MaxLength = 32767;
            txtBuscarProducto.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PasswordChar = '\0';
            txtBuscarProducto.PrefixSuffixText = null;
            txtBuscarProducto.PromptChar = '_';
            txtBuscarProducto.ReadOnly = false;
            txtBuscarProducto.RejectInputOnFirstFailure = false;
            txtBuscarProducto.ResetOnPrompt = true;
            txtBuscarProducto.ResetOnSpace = true;
            txtBuscarProducto.RightToLeft = RightToLeft.No;
            txtBuscarProducto.SelectedText = "";
            txtBuscarProducto.SelectionLength = 0;
            txtBuscarProducto.SelectionStart = 0;
            txtBuscarProducto.ShortcutsEnabled = true;
            txtBuscarProducto.Size = new Size(234, 48);
            txtBuscarProducto.SkipLiterals = true;
            txtBuscarProducto.TabIndex = 3;
            txtBuscarProducto.TabStop = false;
            txtBuscarProducto.Text = "Buscar Producto";
            txtBuscarProducto.TextAlign = HorizontalAlignment.Left;
            txtBuscarProducto.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscarProducto.TrailingIcon = null;
            txtBuscarProducto.UseSystemPasswordChar = false;
            txtBuscarProducto.ValidatingType = null;
            txtBuscarProducto.Enter += txtBuscarProducto_Enter;
            txtBuscarProducto.Leave += txtBuscarProducto_Leave;
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Depth = 0;
            lblInventario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblInventario.Location = new Point(449, 53);
            lblInventario.MouseState = MaterialSkin.MouseState.HOVER;
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(71, 19);
            lblInventario.TabIndex = 20;
            lblInventario.Text = "Inventario";
            // 
            // lblProductoStockMinimo
            // 
            lblProductoStockMinimo.AutoSize = true;
            lblProductoStockMinimo.Depth = 0;
            lblProductoStockMinimo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProductoStockMinimo.ForeColor = Color.FromArgb(211, 47, 47);
            lblProductoStockMinimo.Location = new Point(393, 387);
            lblProductoStockMinimo.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductoStockMinimo.Name = "lblProductoStockMinimo";
            lblProductoStockMinimo.Size = new Size(185, 19);
            lblProductoStockMinimo.TabIndex = 19;
            lblProductoStockMinimo.Text = "Productos Con Stock Bajo";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(215, 412);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(536, 87);
            dataGridView2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(215, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 252);
            dataGridView1.TabIndex = 1;
            // 
            // tabPageCarrito
            // 
            tabPageCarrito.Controls.Add(btnAgregarClienteAlCarrito);
            tabPageCarrito.Controls.Add(txtRNCdeClienteParaCarrito);
            tabPageCarrito.Controls.Add(cmbMetodoPago);
            tabPageCarrito.Controls.Add(lblMetodoPago);
            tabPageCarrito.Controls.Add(dataGridView3);
            tabPageCarrito.Controls.Add(btnValidarVenta);
            tabPageCarrito.Controls.Add(materialCard2);
            tabPageCarrito.Controls.Add(btnQuitarProducto);
            tabPageCarrito.Controls.Add(btnCancelarVenta);
            tabPageCarrito.Controls.Add(lblCantidad);
            tabPageCarrito.Controls.Add(nmrCantidadProducto);
            tabPageCarrito.Controls.Add(btnAgregarAlCarrito);
            tabPageCarrito.Controls.Add(lblCarrito);
            tabPageCarrito.Controls.Add(lblProductosDisponibles);
            tabPageCarrito.Controls.Add(txtBuscarPorCodigo);
            tabPageCarrito.Controls.Add(dataGridView4);
            tabPageCarrito.Controls.Add(btnCodigoProducto);
            tabPageCarrito.Location = new Point(4, 24);
            tabPageCarrito.Name = "tabPageCarrito";
            tabPageCarrito.Padding = new Padding(3);
            tabPageCarrito.Size = new Size(986, 505);
            tabPageCarrito.TabIndex = 2;
            tabPageCarrito.Text = "Carrito";
            tabPageCarrito.UseVisualStyleBackColor = true;
            // 
            // btnAgregarClienteAlCarrito
            // 
            btnAgregarClienteAlCarrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarClienteAlCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarClienteAlCarrito.Depth = 0;
            btnAgregarClienteAlCarrito.HighEmphasis = true;
            btnAgregarClienteAlCarrito.Icon = null;
            btnAgregarClienteAlCarrito.Location = new Point(247, 362);
            btnAgregarClienteAlCarrito.Margin = new Padding(4, 6, 4, 6);
            btnAgregarClienteAlCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarClienteAlCarrito.Name = "btnAgregarClienteAlCarrito";
            btnAgregarClienteAlCarrito.NoAccentTextColor = Color.Empty;
            btnAgregarClienteAlCarrito.Size = new Size(77, 36);
            btnAgregarClienteAlCarrito.TabIndex = 22;
            btnAgregarClienteAlCarrito.Text = "Buscar";
            btnAgregarClienteAlCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarClienteAlCarrito.UseAccentColor = false;
            btnAgregarClienteAlCarrito.UseVisualStyleBackColor = true;
            // 
            // txtRNCdeClienteParaCarrito
            // 
            txtRNCdeClienteParaCarrito.AllowPromptAsInput = true;
            txtRNCdeClienteParaCarrito.AnimateReadOnly = false;
            txtRNCdeClienteParaCarrito.AsciiOnly = false;
            txtRNCdeClienteParaCarrito.BackgroundImageLayout = ImageLayout.None;
            txtRNCdeClienteParaCarrito.BeepOnError = false;
            txtRNCdeClienteParaCarrito.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtRNCdeClienteParaCarrito.Depth = 0;
            txtRNCdeClienteParaCarrito.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRNCdeClienteParaCarrito.HidePromptOnLeave = false;
            txtRNCdeClienteParaCarrito.HideSelection = true;
            txtRNCdeClienteParaCarrito.InsertKeyMode = InsertKeyMode.Default;
            txtRNCdeClienteParaCarrito.LeadingIcon = null;
            txtRNCdeClienteParaCarrito.Location = new Point(31, 355);
            txtRNCdeClienteParaCarrito.Mask = "";
            txtRNCdeClienteParaCarrito.MaxLength = 32767;
            txtRNCdeClienteParaCarrito.MouseState = MaterialSkin.MouseState.OUT;
            txtRNCdeClienteParaCarrito.Name = "txtRNCdeClienteParaCarrito";
            txtRNCdeClienteParaCarrito.PasswordChar = '\0';
            txtRNCdeClienteParaCarrito.PrefixSuffixText = null;
            txtRNCdeClienteParaCarrito.PromptChar = '_';
            txtRNCdeClienteParaCarrito.ReadOnly = false;
            txtRNCdeClienteParaCarrito.RejectInputOnFirstFailure = false;
            txtRNCdeClienteParaCarrito.ResetOnPrompt = true;
            txtRNCdeClienteParaCarrito.ResetOnSpace = true;
            txtRNCdeClienteParaCarrito.RightToLeft = RightToLeft.No;
            txtRNCdeClienteParaCarrito.SelectedText = "";
            txtRNCdeClienteParaCarrito.SelectionLength = 0;
            txtRNCdeClienteParaCarrito.SelectionStart = 0;
            txtRNCdeClienteParaCarrito.ShortcutsEnabled = true;
            txtRNCdeClienteParaCarrito.Size = new Size(201, 48);
            txtRNCdeClienteParaCarrito.SkipLiterals = true;
            txtRNCdeClienteParaCarrito.TabIndex = 21;
            txtRNCdeClienteParaCarrito.TabStop = false;
            txtRNCdeClienteParaCarrito.Text = "Ingrese RNC del Cliente";
            txtRNCdeClienteParaCarrito.TextAlign = HorizontalAlignment.Left;
            txtRNCdeClienteParaCarrito.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtRNCdeClienteParaCarrito.TrailingIcon = null;
            txtRNCdeClienteParaCarrito.UseSystemPasswordChar = false;
            txtRNCdeClienteParaCarrito.ValidatingType = null;
            txtRNCdeClienteParaCarrito.Enter += txtRNCdeClienteParaCarrito_Enter;
            txtRNCdeClienteParaCarrito.Leave += txtRNCdeClienteParaCarrito_Leave;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.AutoResize = false;
            cmbMetodoPago.BackColor = Color.FromArgb(255, 255, 255);
            cmbMetodoPago.Depth = 0;
            cmbMetodoPago.DrawMode = DrawMode.OwnerDrawVariable;
            cmbMetodoPago.DropDownHeight = 174;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.DropDownWidth = 121;
            cmbMetodoPago.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbMetodoPago.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.IntegralHeight = false;
            cmbMetodoPago.ItemHeight = 43;
            cmbMetodoPago.Location = new Point(685, 281);
            cmbMetodoPago.MaxDropDownItems = 4;
            cmbMetodoPago.MouseState = MaterialSkin.MouseState.OUT;
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(144, 49);
            cmbMetodoPago.StartIndex = 0;
            cmbMetodoPago.TabIndex = 18;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Depth = 0;
            lblMetodoPago.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMetodoPago.Location = new Point(554, 294);
            lblMetodoPago.MouseState = MaterialSkin.MouseState.HOVER;
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(117, 19);
            lblMetodoPago.TabIndex = 17;
            lblMetodoPago.Text = "Metodo de Pago";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(31, 45);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(400, 140);
            dataGridView3.TabIndex = 16;
            // 
            // btnValidarVenta
            // 
            btnValidarVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnValidarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnValidarVenta.Depth = 0;
            btnValidarVenta.HighEmphasis = true;
            btnValidarVenta.Icon = null;
            btnValidarVenta.Location = new Point(587, 463);
            btnValidarVenta.Margin = new Padding(4, 6, 4, 6);
            btnValidarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            btnValidarVenta.Name = "btnValidarVenta";
            btnValidarVenta.NoAccentTextColor = Color.Empty;
            btnValidarVenta.Size = new Size(146, 36);
            btnValidarVenta.TabIndex = 15;
            btnValidarVenta.Text = "Procesar Venta";
            btnValidarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnValidarVenta.UseAccentColor = false;
            btnValidarVenta.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblMontoTotal);
            materialCard2.Controls.Add(lblMontoITBIS);
            materialCard2.Controls.Add(lblMontoSubtotal);
            materialCard2.Controls.Add(lblTotal);
            materialCard2.Controls.Add(lblImpuesto);
            materialCard2.Controls.Add(lblSubTotal);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(636, 340);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(250, 112);
            materialCard2.TabIndex = 14;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Depth = 0;
            lblMontoTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMontoTotal.Location = new Point(126, 79);
            lblMontoTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(32, 19);
            lblMontoTotal.TabIndex = 22;
            lblMontoTotal.Text = "0.00";
            // 
            // lblMontoITBIS
            // 
            lblMontoITBIS.AutoSize = true;
            lblMontoITBIS.Depth = 0;
            lblMontoITBIS.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMontoITBIS.Location = new Point(126, 49);
            lblMontoITBIS.MouseState = MaterialSkin.MouseState.HOVER;
            lblMontoITBIS.Name = "lblMontoITBIS";
            lblMontoITBIS.Size = new Size(32, 19);
            lblMontoITBIS.TabIndex = 21;
            lblMontoITBIS.Text = "0.00";
            // 
            // lblMontoSubtotal
            // 
            lblMontoSubtotal.AutoSize = true;
            lblMontoSubtotal.Depth = 0;
            lblMontoSubtotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMontoSubtotal.Location = new Point(126, 14);
            lblMontoSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblMontoSubtotal.Name = "lblMontoSubtotal";
            lblMontoSubtotal.Size = new Size(32, 19);
            lblMontoSubtotal.TabIndex = 20;
            lblMontoSubtotal.Text = "0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotal.Location = new Point(12, 79);
            lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 19);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "Total:";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Depth = 0;
            lblImpuesto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblImpuesto.Location = new Point(11, 49);
            lblImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(43, 19);
            lblImpuesto.TabIndex = 18;
            lblImpuesto.Text = "ITBIS:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Depth = 0;
            lblSubTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubTotal.Location = new Point(11, 14);
            lblSubTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(86, 19);
            lblSubTotal.TabIndex = 17;
            lblSubTotal.Text = "SubTotales:";
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuitarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnQuitarProducto.Depth = 0;
            btnQuitarProducto.HighEmphasis = true;
            btnQuitarProducto.Icon = null;
            btnQuitarProducto.Location = new Point(881, 284);
            btnQuitarProducto.Margin = new Padding(4, 6, 4, 6);
            btnQuitarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.NoAccentTextColor = Color.Empty;
            btnQuitarProducto.Size = new Size(73, 36);
            btnQuitarProducto.TabIndex = 13;
            btnQuitarProducto.Text = "Quitar";
            btnQuitarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnQuitarProducto.UseAccentColor = false;
            btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarVenta.Depth = 0;
            btnCancelarVenta.HighEmphasis = true;
            btnCancelarVenta.Icon = null;
            btnCancelarVenta.Location = new Point(807, 463);
            btnCancelarVenta.Margin = new Padding(4, 6, 4, 6);
            btnCancelarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.NoAccentTextColor = Color.Empty;
            btnCancelarVenta.Size = new Size(147, 36);
            btnCancelarVenta.TabIndex = 11;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarVenta.UseAccentColor = false;
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Depth = 0;
            lblCantidad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCantidad.Location = new Point(31, 294);
            lblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(65, 19);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // nmrCantidadProducto
            // 
            nmrCantidadProducto.Location = new Point(112, 290);
            nmrCantidadProducto.Name = "nmrCantidadProducto";
            nmrCantidadProducto.Size = new Size(120, 23);
            nmrCantidadProducto.TabIndex = 9;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarAlCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarAlCarrito.Depth = 0;
            btnAgregarAlCarrito.HighEmphasis = true;
            btnAgregarAlCarrito.Icon = null;
            btnAgregarAlCarrito.Location = new Point(258, 284);
            btnAgregarAlCarrito.Margin = new Padding(4, 6, 4, 6);
            btnAgregarAlCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.NoAccentTextColor = Color.Empty;
            btnAgregarAlCarrito.Size = new Size(173, 36);
            btnAgregarAlCarrito.TabIndex = 8;
            btnAgregarAlCarrito.Text = "Agregar al Carrito";
            btnAgregarAlCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarAlCarrito.UseAccentColor = false;
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Depth = 0;
            lblCarrito.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCarrito.Location = new Point(685, 14);
            lblCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(161, 19);
            lblCarrito.TabIndex = 7;
            lblCarrito.Text = "Productos en el Carrito";
            // 
            // lblProductosDisponibles
            // 
            lblProductosDisponibles.AutoSize = true;
            lblProductosDisponibles.Depth = 0;
            lblProductosDisponibles.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProductosDisponibles.Location = new Point(141, 14);
            lblProductosDisponibles.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductosDisponibles.Name = "lblProductosDisponibles";
            lblProductosDisponibles.Size = new Size(160, 19);
            lblProductosDisponibles.TabIndex = 6;
            lblProductosDisponibles.Text = "Productos Disponibles";
            // 
            // txtBuscarPorCodigo
            // 
            txtBuscarPorCodigo.AllowPromptAsInput = true;
            txtBuscarPorCodigo.AnimateReadOnly = false;
            txtBuscarPorCodigo.AsciiOnly = false;
            txtBuscarPorCodigo.BackgroundImageLayout = ImageLayout.None;
            txtBuscarPorCodigo.BeepOnError = false;
            txtBuscarPorCodigo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscarPorCodigo.Depth = 0;
            txtBuscarPorCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarPorCodigo.HidePromptOnLeave = false;
            txtBuscarPorCodigo.HideSelection = true;
            txtBuscarPorCodigo.InsertKeyMode = InsertKeyMode.Default;
            txtBuscarPorCodigo.LeadingIcon = null;
            txtBuscarPorCodigo.Location = new Point(31, 211);
            txtBuscarPorCodigo.Mask = "";
            txtBuscarPorCodigo.MaxLength = 32767;
            txtBuscarPorCodigo.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarPorCodigo.Name = "txtBuscarPorCodigo";
            txtBuscarPorCodigo.PasswordChar = '\0';
            txtBuscarPorCodigo.PrefixSuffixText = null;
            txtBuscarPorCodigo.PromptChar = '_';
            txtBuscarPorCodigo.ReadOnly = false;
            txtBuscarPorCodigo.RejectInputOnFirstFailure = false;
            txtBuscarPorCodigo.ResetOnPrompt = true;
            txtBuscarPorCodigo.ResetOnSpace = true;
            txtBuscarPorCodigo.RightToLeft = RightToLeft.No;
            txtBuscarPorCodigo.SelectedText = "";
            txtBuscarPorCodigo.SelectionLength = 0;
            txtBuscarPorCodigo.SelectionStart = 0;
            txtBuscarPorCodigo.ShortcutsEnabled = true;
            txtBuscarPorCodigo.Size = new Size(151, 48);
            txtBuscarPorCodigo.SkipLiterals = true;
            txtBuscarPorCodigo.TabIndex = 0;
            txtBuscarPorCodigo.TabStop = false;
            txtBuscarPorCodigo.Text = "Ingresa el Codigo";
            txtBuscarPorCodigo.TextAlign = HorizontalAlignment.Left;
            txtBuscarPorCodigo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscarPorCodigo.TrailingIcon = null;
            txtBuscarPorCodigo.UseSystemPasswordChar = false;
            txtBuscarPorCodigo.ValidatingType = null;
            txtBuscarPorCodigo.Enter += txtBuscarPorCodigo_Enter;
            txtBuscarPorCodigo.Leave += txtBuscarPorCodigo_Leave;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(554, 45);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(400, 230);
            dataGridView4.TabIndex = 5;
            // 
            // btnCodigoProducto
            // 
            btnCodigoProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCodigoProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCodigoProducto.Depth = 0;
            btnCodigoProducto.HighEmphasis = true;
            btnCodigoProducto.Icon = null;
            btnCodigoProducto.Location = new Point(200, 220);
            btnCodigoProducto.Margin = new Padding(4, 6, 4, 6);
            btnCodigoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnCodigoProducto.Name = "btnCodigoProducto";
            btnCodigoProducto.NoAccentTextColor = Color.Empty;
            btnCodigoProducto.Size = new Size(77, 36);
            btnCodigoProducto.TabIndex = 1;
            btnCodigoProducto.Text = "Buscar";
            btnCodigoProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCodigoProducto.UseAccentColor = false;
            btnCodigoProducto.UseVisualStyleBackColor = true;
            // 
            // tabPageReportes
            // 
            tabPageReportes.Controls.Add(lblReporteVentasDia);
            tabPageReportes.Controls.Add(btnRecarcularPlinq);
            tabPageReportes.Controls.Add(materialCard4);
            tabPageReportes.Controls.Add(materialCard3);
            tabPageReportes.Controls.Add(dgvReporteVentas);
            tabPageReportes.Location = new Point(4, 24);
            tabPageReportes.Name = "tabPageReportes";
            tabPageReportes.Padding = new Padding(3);
            tabPageReportes.Size = new Size(986, 505);
            tabPageReportes.TabIndex = 3;
            tabPageReportes.Text = "Reporte de Ventas";
            tabPageReportes.UseVisualStyleBackColor = true;
            // 
            // lblReporteVentasDia
            // 
            lblReporteVentasDia.AutoSize = true;
            lblReporteVentasDia.Depth = 0;
            lblReporteVentasDia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblReporteVentasDia.Location = new Point(542, 159);
            lblReporteVentasDia.MouseState = MaterialSkin.MouseState.HOVER;
            lblReporteVentasDia.Name = "lblReporteVentasDia";
            lblReporteVentasDia.Size = new Size(163, 19);
            lblReporteVentasDia.TabIndex = 11;
            lblReporteVentasDia.Text = "Reporte Ventas Del Dia";
            // 
            // btnRecarcularPlinq
            // 
            btnRecarcularPlinq.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecarcularPlinq.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRecarcularPlinq.Depth = 0;
            btnRecarcularPlinq.HighEmphasis = true;
            btnRecarcularPlinq.Icon = null;
            btnRecarcularPlinq.Location = new Point(568, 449);
            btnRecarcularPlinq.Margin = new Padding(4, 6, 4, 6);
            btnRecarcularPlinq.MouseState = MaterialSkin.MouseState.HOVER;
            btnRecarcularPlinq.Name = "btnRecarcularPlinq";
            btnRecarcularPlinq.NoAccentTextColor = Color.Empty;
            btnRecarcularPlinq.Size = new Size(112, 36);
            btnRecarcularPlinq.TabIndex = 10;
            btnRecarcularPlinq.Text = "Recalcular";
            btnRecarcularPlinq.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRecarcularPlinq.UseAccentColor = false;
            btnRecarcularPlinq.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(lblReportesdelDia);
            materialCard4.Controls.Add(lblTotalGeneralFinal);
            materialCard4.Controls.Add(lblITBISFinal);
            materialCard4.Controls.Add(lblSubtotalGenealNumero);
            materialCard4.Controls.Add(lblCantidadVentasFinal);
            materialCard4.Controls.Add(lblTotalGeneral);
            materialCard4.Controls.Add(lblNumeroVentas);
            materialCard4.Controls.Add(lblSubTotalGeneral);
            materialCard4.Controls.Add(lblITBISGeneral);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(-1, 190);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(259, 250);
            materialCard4.TabIndex = 9;
            // 
            // lblReportesdelDia
            // 
            lblReportesdelDia.AutoSize = true;
            lblReportesdelDia.Depth = 0;
            lblReportesdelDia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblReportesdelDia.Location = new Point(61, 23);
            lblReportesdelDia.MouseState = MaterialSkin.MouseState.HOVER;
            lblReportesdelDia.Name = "lblReportesdelDia";
            lblReportesdelDia.Size = new Size(116, 19);
            lblReportesdelDia.TabIndex = 14;
            lblReportesdelDia.Text = "Reportes del Dia";
            // 
            // lblTotalGeneralFinal
            // 
            lblTotalGeneralFinal.AutoSize = true;
            lblTotalGeneralFinal.Depth = 0;
            lblTotalGeneralFinal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalGeneralFinal.Location = new Point(138, 192);
            lblTotalGeneralFinal.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalGeneralFinal.Name = "lblTotalGeneralFinal";
            lblTotalGeneralFinal.Size = new Size(32, 19);
            lblTotalGeneralFinal.TabIndex = 13;
            lblTotalGeneralFinal.Text = "0.00";
            // 
            // lblITBISFinal
            // 
            lblITBISFinal.AutoSize = true;
            lblITBISFinal.Depth = 0;
            lblITBISFinal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblITBISFinal.Location = new Point(138, 154);
            lblITBISFinal.MouseState = MaterialSkin.MouseState.HOVER;
            lblITBISFinal.Name = "lblITBISFinal";
            lblITBISFinal.Size = new Size(32, 19);
            lblITBISFinal.TabIndex = 12;
            lblITBISFinal.Text = "0.00";
            // 
            // lblSubtotalGenealNumero
            // 
            lblSubtotalGenealNumero.AutoSize = true;
            lblSubtotalGenealNumero.Depth = 0;
            lblSubtotalGenealNumero.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubtotalGenealNumero.Location = new Point(138, 110);
            lblSubtotalGenealNumero.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtotalGenealNumero.Name = "lblSubtotalGenealNumero";
            lblSubtotalGenealNumero.Size = new Size(32, 19);
            lblSubtotalGenealNumero.TabIndex = 11;
            lblSubtotalGenealNumero.Text = "0.00";
            // 
            // lblCantidadVentasFinal
            // 
            lblCantidadVentasFinal.AutoSize = true;
            lblCantidadVentasFinal.Depth = 0;
            lblCantidadVentasFinal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCantidadVentasFinal.Location = new Point(140, 69);
            lblCantidadVentasFinal.MouseState = MaterialSkin.MouseState.HOVER;
            lblCantidadVentasFinal.Name = "lblCantidadVentasFinal";
            lblCantidadVentasFinal.Size = new Size(10, 19);
            lblCantidadVentasFinal.TabIndex = 10;
            lblCantidadVentasFinal.Text = "0";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Depth = 0;
            lblTotalGeneral.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalGeneral.Location = new Point(1, 192);
            lblTotalGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(100, 19);
            lblTotalGeneral.TabIndex = 9;
            lblTotalGeneral.Text = "Total General:";
            // 
            // lblNumeroVentas
            // 
            lblNumeroVentas.AutoSize = true;
            lblNumeroVentas.Depth = 0;
            lblNumeroVentas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumeroVentas.Location = new Point(4, 69);
            lblNumeroVentas.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumeroVentas.Name = "lblNumeroVentas";
            lblNumeroVentas.Size = new Size(122, 19);
            lblNumeroVentas.TabIndex = 8;
            lblNumeroVentas.Text = "Cantidad Ventas:";
            // 
            // lblSubTotalGeneral
            // 
            lblSubTotalGeneral.AutoSize = true;
            lblSubTotalGeneral.Depth = 0;
            lblSubTotalGeneral.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubTotalGeneral.Location = new Point(4, 110);
            lblSubTotalGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubTotalGeneral.Name = "lblSubTotalGeneral";
            lblSubTotalGeneral.Size = new Size(128, 19);
            lblSubTotalGeneral.TabIndex = 7;
            lblSubTotalGeneral.Text = "SubTotal General:";
            // 
            // lblITBISGeneral
            // 
            lblITBISGeneral.AutoSize = true;
            lblITBISGeneral.Depth = 0;
            lblITBISGeneral.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblITBISGeneral.Location = new Point(5, 154);
            lblITBISGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            lblITBISGeneral.Name = "lblITBISGeneral";
            lblITBISGeneral.Size = new Size(77, 19);
            lblITBISGeneral.TabIndex = 6;
            lblITBISGeneral.Text = "ITBIS 18%:";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lblEstadoCargando);
            materialCard3.Controls.Add(lblEstado);
            materialCard3.Controls.Add(btnReporte);
            materialCard3.Controls.Add(lblProgreso);
            materialCard3.Controls.Add(prbProgreso);
            materialCard3.Controls.Add(dtpFecha);
            materialCard3.Controls.Add(lblFecha);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(-4, 0);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(1007, 98);
            materialCard3.TabIndex = 1;
            // 
            // lblEstadoCargando
            // 
            lblEstadoCargando.AutoSize = true;
            lblEstadoCargando.Depth = 0;
            lblEstadoCargando.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEstadoCargando.Location = new Point(417, 61);
            lblEstadoCargando.MouseState = MaterialSkin.MouseState.HOVER;
            lblEstadoCargando.Name = "lblEstadoCargando";
            lblEstadoCargando.Size = new Size(82, 19);
            lblEstadoCargando.TabIndex = 6;
            lblEstadoCargando.Text = "Cargando...";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Depth = 0;
            lblEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEstado.Location = new Point(357, 61);
            lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 19);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado:";
            // 
            // btnReporte
            // 
            btnReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReporte.Depth = 0;
            btnReporte.HighEmphasis = true;
            btnReporte.Icon = null;
            btnReporte.Location = new Point(357, 9);
            btnReporte.Margin = new Padding(4, 6, 4, 6);
            btnReporte.MouseState = MaterialSkin.MouseState.HOVER;
            btnReporte.Name = "btnReporte";
            btnReporte.NoAccentTextColor = Color.Empty;
            btnReporte.Size = new Size(146, 36);
            btnReporte.TabIndex = 4;
            btnReporte.Text = "Cargar Reporte";
            btnReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReporte.UseAccentColor = false;
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Depth = 0;
            lblProgreso.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProgreso.Location = new Point(6, 62);
            lblProgreso.MouseState = MaterialSkin.MouseState.HOVER;
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(127, 19);
            lblProgreso.TabIndex = 3;
            lblProgreso.Text = "Barra de Progreso";
            // 
            // prbProgreso
            // 
            prbProgreso.Location = new Point(139, 62);
            prbProgreso.Name = "prbProgreso";
            prbProgreso.Size = new Size(121, 23);
            prbProgreso.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(60, 14);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFecha.Location = new Point(6, 14);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 19);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // dgvReporteVentas
            // 
            dgvReporteVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteVentas.Location = new Point(346, 190);
            dgvReporteVentas.Name = "dgvReporteVentas";
            dgvReporteVentas.Size = new Size(550, 250);
            dgvReporteVentas.TabIndex = 0;
            // 
            // tabPageClientes
            // 
            tabPageClientes.Controls.Add(btnQuitarCliente);
            tabPageClientes.Controls.Add(btnIngreseCliente);
            tabPageClientes.Controls.Add(materialCard1);
            tabPageClientes.Controls.Add(lblClientesRegistrados);
            tabPageClientes.Controls.Add(dataGridView5);
            tabPageClientes.Controls.Add(btnBuscarCliente);
            tabPageClientes.Controls.Add(txtRncCliente);
            tabPageClientes.Location = new Point(4, 24);
            tabPageClientes.Name = "tabPageClientes";
            tabPageClientes.Padding = new Padding(3);
            tabPageClientes.Size = new Size(986, 505);
            tabPageClientes.TabIndex = 4;
            tabPageClientes.Text = "Agregar Cliente";
            tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // btnQuitarCliente
            // 
            btnQuitarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuitarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnQuitarCliente.Depth = 0;
            btnQuitarCliente.HighEmphasis = true;
            btnQuitarCliente.Icon = null;
            btnQuitarCliente.Location = new Point(725, 412);
            btnQuitarCliente.Margin = new Padding(4, 6, 4, 6);
            btnQuitarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuitarCliente.Name = "btnQuitarCliente";
            btnQuitarCliente.NoAccentTextColor = Color.Empty;
            btnQuitarCliente.Size = new Size(135, 36);
            btnQuitarCliente.TabIndex = 9;
            btnQuitarCliente.Text = "Quitar Cliente";
            btnQuitarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnQuitarCliente.UseAccentColor = false;
            btnQuitarCliente.UseVisualStyleBackColor = true;
            // 
            // btnIngreseCliente
            // 
            btnIngreseCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngreseCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIngreseCliente.Depth = 0;
            btnIngreseCliente.HighEmphasis = true;
            btnIngreseCliente.Icon = null;
            btnIngreseCliente.Location = new Point(350, 412);
            btnIngreseCliente.Margin = new Padding(4, 6, 4, 6);
            btnIngreseCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnIngreseCliente.Name = "btnIngreseCliente";
            btnIngreseCliente.NoAccentTextColor = Color.Empty;
            btnIngreseCliente.Size = new Size(136, 36);
            btnIngreseCliente.TabIndex = 8;
            btnIngreseCliente.Text = "Añadir Cliente";
            btnIngreseCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIngreseCliente.UseAccentColor = false;
            btnIngreseCliente.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(cmbIngreseTipoCliente);
            materialCard1.Controls.Add(txtIngreseRNC);
            materialCard1.Controls.Add(txtIngreseNombreCliente);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(lblIngreseNombre);
            materialCard1.Controls.Add(lblIngreseTipoCliente);
            materialCard1.Controls.Add(lblIngreseRNC);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(-11, 103);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(321, 300);
            materialCard1.TabIndex = 7;
            // 
            // cmbIngreseTipoCliente
            // 
            cmbIngreseTipoCliente.AutoResize = false;
            cmbIngreseTipoCliente.BackColor = Color.FromArgb(255, 255, 255);
            cmbIngreseTipoCliente.Depth = 0;
            cmbIngreseTipoCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cmbIngreseTipoCliente.DropDownHeight = 174;
            cmbIngreseTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngreseTipoCliente.DropDownWidth = 121;
            cmbIngreseTipoCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbIngreseTipoCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbIngreseTipoCliente.FormattingEnabled = true;
            cmbIngreseTipoCliente.IntegralHeight = false;
            cmbIngreseTipoCliente.ItemHeight = 43;
            cmbIngreseTipoCliente.Location = new Point(133, 223);
            cmbIngreseTipoCliente.MaxDropDownItems = 4;
            cmbIngreseTipoCliente.MouseState = MaterialSkin.MouseState.OUT;
            cmbIngreseTipoCliente.Name = "cmbIngreseTipoCliente";
            cmbIngreseTipoCliente.Size = new Size(164, 49);
            cmbIngreseTipoCliente.StartIndex = 0;
            cmbIngreseTipoCliente.TabIndex = 10;
            // 
            // txtIngreseRNC
            // 
            txtIngreseRNC.AllowPromptAsInput = true;
            txtIngreseRNC.AnimateReadOnly = false;
            txtIngreseRNC.AsciiOnly = false;
            txtIngreseRNC.BackgroundImageLayout = ImageLayout.None;
            txtIngreseRNC.BeepOnError = false;
            txtIngreseRNC.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtIngreseRNC.Depth = 0;
            txtIngreseRNC.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIngreseRNC.HidePromptOnLeave = false;
            txtIngreseRNC.HideSelection = true;
            txtIngreseRNC.InsertKeyMode = InsertKeyMode.Default;
            txtIngreseRNC.LeadingIcon = null;
            txtIngreseRNC.Location = new Point(84, 150);
            txtIngreseRNC.Mask = "";
            txtIngreseRNC.MaxLength = 32767;
            txtIngreseRNC.MouseState = MaterialSkin.MouseState.OUT;
            txtIngreseRNC.Name = "txtIngreseRNC";
            txtIngreseRNC.PasswordChar = '\0';
            txtIngreseRNC.PrefixSuffixText = null;
            txtIngreseRNC.PromptChar = '_';
            txtIngreseRNC.ReadOnly = false;
            txtIngreseRNC.RejectInputOnFirstFailure = false;
            txtIngreseRNC.ResetOnPrompt = true;
            txtIngreseRNC.ResetOnSpace = true;
            txtIngreseRNC.RightToLeft = RightToLeft.No;
            txtIngreseRNC.SelectedText = "";
            txtIngreseRNC.SelectionLength = 0;
            txtIngreseRNC.SelectionStart = 0;
            txtIngreseRNC.ShortcutsEnabled = true;
            txtIngreseRNC.Size = new Size(213, 48);
            txtIngreseRNC.SkipLiterals = true;
            txtIngreseRNC.TabIndex = 9;
            txtIngreseRNC.TabStop = false;
            txtIngreseRNC.TextAlign = HorizontalAlignment.Left;
            txtIngreseRNC.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtIngreseRNC.TrailingIcon = null;
            txtIngreseRNC.UseSystemPasswordChar = false;
            txtIngreseRNC.ValidatingType = null;
            // 
            // txtIngreseNombreCliente
            // 
            txtIngreseNombreCliente.AllowPromptAsInput = true;
            txtIngreseNombreCliente.AnimateReadOnly = false;
            txtIngreseNombreCliente.AsciiOnly = false;
            txtIngreseNombreCliente.BackgroundImageLayout = ImageLayout.None;
            txtIngreseNombreCliente.BeepOnError = false;
            txtIngreseNombreCliente.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtIngreseNombreCliente.Depth = 0;
            txtIngreseNombreCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIngreseNombreCliente.HidePromptOnLeave = false;
            txtIngreseNombreCliente.HideSelection = true;
            txtIngreseNombreCliente.InsertKeyMode = InsertKeyMode.Default;
            txtIngreseNombreCliente.LeadingIcon = null;
            txtIngreseNombreCliente.Location = new Point(84, 76);
            txtIngreseNombreCliente.Mask = "";
            txtIngreseNombreCliente.MaxLength = 32767;
            txtIngreseNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtIngreseNombreCliente.Name = "txtIngreseNombreCliente";
            txtIngreseNombreCliente.PasswordChar = '\0';
            txtIngreseNombreCliente.PrefixSuffixText = null;
            txtIngreseNombreCliente.PromptChar = '_';
            txtIngreseNombreCliente.ReadOnly = false;
            txtIngreseNombreCliente.RejectInputOnFirstFailure = false;
            txtIngreseNombreCliente.ResetOnPrompt = true;
            txtIngreseNombreCliente.ResetOnSpace = true;
            txtIngreseNombreCliente.RightToLeft = RightToLeft.No;
            txtIngreseNombreCliente.SelectedText = "";
            txtIngreseNombreCliente.SelectionLength = 0;
            txtIngreseNombreCliente.SelectionStart = 0;
            txtIngreseNombreCliente.ShortcutsEnabled = true;
            txtIngreseNombreCliente.Size = new Size(213, 48);
            txtIngreseNombreCliente.SkipLiterals = true;
            txtIngreseNombreCliente.TabIndex = 8;
            txtIngreseNombreCliente.TabStop = false;
            txtIngreseNombreCliente.TextAlign = HorizontalAlignment.Left;
            txtIngreseNombreCliente.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtIngreseNombreCliente.TrailingIcon = null;
            txtIngreseNombreCliente.UseSystemPasswordChar = false;
            txtIngreseNombreCliente.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(56, 27);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(220, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "INGRESE DATOS DEL CLIENTE";
            // 
            // lblIngreseNombre
            // 
            lblIngreseNombre.AutoSize = true;
            lblIngreseNombre.Depth = 0;
            lblIngreseNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIngreseNombre.Location = new Point(17, 92);
            lblIngreseNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblIngreseNombre.Name = "lblIngreseNombre";
            lblIngreseNombre.Size = new Size(61, 19);
            lblIngreseNombre.TabIndex = 4;
            lblIngreseNombre.Text = "Nombre:";
            // 
            // lblIngreseTipoCliente
            // 
            lblIngreseTipoCliente.AutoSize = true;
            lblIngreseTipoCliente.Depth = 0;
            lblIngreseTipoCliente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIngreseTipoCliente.Location = new Point(17, 239);
            lblIngreseTipoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblIngreseTipoCliente.Name = "lblIngreseTipoCliente";
            lblIngreseTipoCliente.Size = new Size(110, 19);
            lblIngreseTipoCliente.TabIndex = 5;
            lblIngreseTipoCliente.Text = "Tipo de Cliente:";
            // 
            // lblIngreseRNC
            // 
            lblIngreseRNC.AutoSize = true;
            lblIngreseRNC.Depth = 0;
            lblIngreseRNC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIngreseRNC.Location = new Point(17, 165);
            lblIngreseRNC.MouseState = MaterialSkin.MouseState.HOVER;
            lblIngreseRNC.Name = "lblIngreseRNC";
            lblIngreseRNC.Size = new Size(36, 19);
            lblIngreseRNC.TabIndex = 6;
            lblIngreseRNC.Text = "RNC:";
            // 
            // lblClientesRegistrados
            // 
            lblClientesRegistrados.AutoSize = true;
            lblClientesRegistrados.Depth = 0;
            lblClientesRegistrados.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblClientesRegistrados.Location = new Point(541, 76);
            lblClientesRegistrados.MouseState = MaterialSkin.MouseState.HOVER;
            lblClientesRegistrados.Name = "lblClientesRegistrados";
            lblClientesRegistrados.Size = new Size(137, 19);
            lblClientesRegistrados.TabIndex = 3;
            lblClientesRegistrados.Text = "Clientes Agregados";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(350, 103);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(510, 300);
            dataGridView5.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarCliente.Depth = 0;
            btnBuscarCliente.HighEmphasis = true;
            btnBuscarCliente.Icon = null;
            btnBuscarCliente.Location = new Point(209, 12);
            btnBuscarCliente.Margin = new Padding(4, 6, 4, 6);
            btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.NoAccentTextColor = Color.Empty;
            btnBuscarCliente.Size = new Size(77, 36);
            btnBuscarCliente.TabIndex = 1;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarCliente.UseAccentColor = false;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtRncCliente
            // 
            txtRncCliente.AllowPromptAsInput = true;
            txtRncCliente.AnimateReadOnly = false;
            txtRncCliente.AsciiOnly = false;
            txtRncCliente.BackgroundImageLayout = ImageLayout.None;
            txtRncCliente.BeepOnError = false;
            txtRncCliente.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtRncCliente.Depth = 0;
            txtRncCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRncCliente.HidePromptOnLeave = false;
            txtRncCliente.HideSelection = true;
            txtRncCliente.InsertKeyMode = InsertKeyMode.Default;
            txtRncCliente.LeadingIcon = null;
            txtRncCliente.Location = new Point(3, 6);
            txtRncCliente.Mask = "";
            txtRncCliente.MaxLength = 32767;
            txtRncCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtRncCliente.Name = "txtRncCliente";
            txtRncCliente.PasswordChar = '\0';
            txtRncCliente.PrefixSuffixText = null;
            txtRncCliente.PromptChar = '_';
            txtRncCliente.ReadOnly = false;
            txtRncCliente.RejectInputOnFirstFailure = false;
            txtRncCliente.ResetOnPrompt = true;
            txtRncCliente.ResetOnSpace = true;
            txtRncCliente.RightToLeft = RightToLeft.No;
            txtRncCliente.SelectedText = "";
            txtRncCliente.SelectionLength = 0;
            txtRncCliente.SelectionStart = 0;
            txtRncCliente.ShortcutsEnabled = true;
            txtRncCliente.Size = new Size(199, 48);
            txtRncCliente.SkipLiterals = true;
            txtRncCliente.TabIndex = 0;
            txtRncCliente.TabStop = false;
            txtRncCliente.Text = "Ingrese RNC del Cliente";
            txtRncCliente.TextAlign = HorizontalAlignment.Left;
            txtRncCliente.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtRncCliente.TrailingIcon = null;
            txtRncCliente.UseSystemPasswordChar = false;
            txtRncCliente.ValidatingType = null;
            txtRncCliente.Enter += txtRncCliente_Enter;
            txtRncCliente.Leave += txtRncCliente_Leave;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colmado Alegria";
            materialTabControl1.ResumeLayout(false);
            tabPageInventario.ResumeLayout(false);
            tabPageInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageCarrito.ResumeLayout(false);
            tabPageCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPageReportes.ResumeLayout(false);
            tabPageReportes.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).EndInit();
            tabPageClientes.ResumeLayout(false);
            tabPageClientes.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPageInventario;
        private TabPage tabPageCarrito;
        private TabPage tabPageReportes;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarProducto;
        private MaterialSkin.Controls.MaterialButton btnBuscarProducto;
        private DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel lblProductoStockMinimo;
        private DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarPorCodigo;
        private MaterialSkin.Controls.MaterialButton btnCodigoProducto;
        private MaterialSkin.Controls.MaterialButton btnAgregarAlCarrito;
        private MaterialSkin.Controls.MaterialLabel lblCarrito;
        private MaterialSkin.Controls.MaterialLabel lblProductosDisponibles;
        private NumericUpDown nmrCantidadProducto;
        private MaterialSkin.Controls.MaterialLabel lblCantidad;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton btnQuitarProducto;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnCancelarVenta;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnValidarVenta;
        private DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblImpuesto;
        private MaterialSkin.Controls.MaterialLabel lblSubTotal;
        private MaterialSkin.Controls.MaterialComboBox cmbMetodoPago;
        private MaterialSkin.Controls.MaterialLabel lblMetodoPago;
        private MaterialSkin.Controls.MaterialLabel lblMontoTotal;
        private MaterialSkin.Controls.MaterialLabel lblMontoITBIS;
        private MaterialSkin.Controls.MaterialLabel lblMontoSubtotal;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private DataGridView dgvReporteVentas;
        private ProgressBar prbProgreso;
        private DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialLabel lblProgreso;
        private MaterialSkin.Controls.MaterialButton btnReporte;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lblNumeroVentas;
        private MaterialSkin.Controls.MaterialLabel lblSubTotalGeneral;
        private MaterialSkin.Controls.MaterialLabel lblITBISGeneral;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private MaterialSkin.Controls.MaterialLabel lblTotalGeneral;
        private MaterialSkin.Controls.MaterialLabel lblCantidadVentasFinal;
        private MaterialSkin.Controls.MaterialLabel lblTotalGeneralFinal;
        private MaterialSkin.Controls.MaterialLabel lblITBISFinal;
        private MaterialSkin.Controls.MaterialLabel lblSubtotalGenealNumero;
        private MaterialSkin.Controls.MaterialLabel lblReporteVentasDia;
        private MaterialSkin.Controls.MaterialButton btnRecarcularPlinq;
        private MaterialSkin.Controls.MaterialLabel lblEstadoCargando;
        private MaterialSkin.Controls.MaterialLabel lblReportesdelDia;
        private MaterialSkin.Controls.MaterialLabel lblInventario;
        private TabPage tabPageClientes;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRncCliente;
        private MaterialSkin.Controls.MaterialButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialLabel lblClientesRegistrados;
        private DataGridView dataGridView5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblIngreseNombre;
        private MaterialSkin.Controls.MaterialLabel lblIngreseTipoCliente;
        private MaterialSkin.Controls.MaterialLabel lblIngreseRNC;
        private MaterialSkin.Controls.MaterialComboBox cmbIngreseTipoCliente;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtIngreseRNC;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtIngreseNombreCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnQuitarCliente;
        private MaterialSkin.Controls.MaterialButton btnIngreseCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarClienteAlCarrito;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRNCdeClienteParaCarrito;
    }
}
