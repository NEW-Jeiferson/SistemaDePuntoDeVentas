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
            tabPage2 = new TabPage();
            lblInventario = new MaterialSkin.Controls.MaterialLabel();
            lblProductoStockMinimo = new MaterialSkin.Controls.MaterialLabel();
            dataGridView2 = new DataGridView();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            cmbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            lblStockMinimo = new MaterialSkin.Controls.MaterialLabel();
            lblStock = new MaterialSkin.Controls.MaterialLabel();
            lblCosto = new MaterialSkin.Controls.MaterialLabel();
            lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            txtStockMinimo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtStock = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtCosto = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPrecio = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtCodigo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtBuscarProducto = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnBuscar = new MaterialSkin.Controls.MaterialButton();
            btnAgregar = new MaterialSkin.Controls.MaterialButton();
            tabPage3 = new TabPage();
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
            tabPage4 = new TabPage();
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
            materialTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage4.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(lblInventario);
            tabPage2.Controls.Add(lblProductoStockMinimo);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(986, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Depth = 0;
            lblInventario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblInventario.Location = new Point(654, 11);
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
            lblProductoStockMinimo.Location = new Point(595, 389);
            lblProductoStockMinimo.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductoStockMinimo.Name = "lblProductoStockMinimo";
            lblProductoStockMinimo.Size = new Size(185, 19);
            lblProductoStockMinimo.TabIndex = 19;
            lblProductoStockMinimo.Text = "Productos Con Stock Bajo";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(420, 412);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(536, 87);
            dataGridView2.TabIndex = 15;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(734, 306);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 252);
            dataGridView1.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(cmbCategoria);
            materialCard1.Controls.Add(lblStockMinimo);
            materialCard1.Controls.Add(lblStock);
            materialCard1.Controls.Add(lblCosto);
            materialCard1.Controls.Add(lblPrecio);
            materialCard1.Controls.Add(lblCategoria);
            materialCard1.Controls.Add(lblNombre);
            materialCard1.Controls.Add(lblCodigo);
            materialCard1.Controls.Add(txtStockMinimo);
            materialCard1.Controls.Add(txtStock);
            materialCard1.Controls.Add(txtCosto);
            materialCard1.Controls.Add(txtPrecio);
            materialCard1.Controls.Add(txtNombre);
            materialCard1.Controls.Add(txtCodigo);
            materialCard1.Controls.Add(txtBuscarProducto);
            materialCard1.Controls.Add(btnBuscar);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(380, 540);
            materialCard1.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoResize = false;
            cmbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategoria.Depth = 0;
            cmbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategoria.DropDownHeight = 174;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.DropDownWidth = 121;
            cmbCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.IntegralHeight = false;
            cmbCategoria.ItemHeight = 43;
            cmbCategoria.Location = new Point(135, 197);
            cmbCategoria.MaxDropDownItems = 4;
            cmbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(228, 49);
            cmbCategoria.StartIndex = 0;
            cmbCategoria.TabIndex = 18;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Depth = 0;
            lblStockMinimo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStockMinimo.Location = new Point(17, 468);
            lblStockMinimo.MouseState = MaterialSkin.MouseState.HOVER;
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(99, 19);
            lblStockMinimo.TabIndex = 17;
            lblStockMinimo.Text = "Stock Minimo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Depth = 0;
            lblStock.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStock.Location = new Point(17, 400);
            lblStock.MouseState = MaterialSkin.MouseState.HOVER;
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(41, 19);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Depth = 0;
            lblCosto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCosto.Location = new Point(17, 339);
            lblCosto.MouseState = MaterialSkin.MouseState.HOVER;
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(42, 19);
            lblCosto.TabIndex = 15;
            lblCosto.Text = "Costo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Depth = 0;
            lblPrecio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPrecio.Location = new Point(17, 278);
            lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 19);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Depth = 0;
            lblCategoria.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCategoria.Location = new Point(17, 212);
            lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 19);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(17, 153);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 19);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Depth = 0;
            lblCodigo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCodigo.Location = new Point(17, 88);
            lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(51, 19);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Codigo";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.AllowPromptAsInput = true;
            txtStockMinimo.AnimateReadOnly = false;
            txtStockMinimo.AsciiOnly = false;
            txtStockMinimo.BackgroundImageLayout = ImageLayout.None;
            txtStockMinimo.BeepOnError = false;
            txtStockMinimo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtStockMinimo.Depth = 0;
            txtStockMinimo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStockMinimo.HidePromptOnLeave = false;
            txtStockMinimo.HideSelection = true;
            txtStockMinimo.InsertKeyMode = InsertKeyMode.Default;
            txtStockMinimo.LeadingIcon = null;
            txtStockMinimo.Location = new Point(135, 454);
            txtStockMinimo.Mask = "";
            txtStockMinimo.MaxLength = 32767;
            txtStockMinimo.MouseState = MaterialSkin.MouseState.OUT;
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.PasswordChar = '\0';
            txtStockMinimo.PrefixSuffixText = null;
            txtStockMinimo.PromptChar = '_';
            txtStockMinimo.ReadOnly = false;
            txtStockMinimo.RejectInputOnFirstFailure = false;
            txtStockMinimo.ResetOnPrompt = true;
            txtStockMinimo.ResetOnSpace = true;
            txtStockMinimo.RightToLeft = RightToLeft.No;
            txtStockMinimo.SelectedText = "";
            txtStockMinimo.SelectionLength = 0;
            txtStockMinimo.SelectionStart = 0;
            txtStockMinimo.ShortcutsEnabled = true;
            txtStockMinimo.Size = new Size(228, 48);
            txtStockMinimo.SkipLiterals = true;
            txtStockMinimo.TabIndex = 10;
            txtStockMinimo.TabStop = false;
            txtStockMinimo.TextAlign = HorizontalAlignment.Left;
            txtStockMinimo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtStockMinimo.TrailingIcon = null;
            txtStockMinimo.UseSystemPasswordChar = false;
            txtStockMinimo.ValidatingType = null;
            // 
            // txtStock
            // 
            txtStock.AllowPromptAsInput = true;
            txtStock.AnimateReadOnly = false;
            txtStock.AsciiOnly = false;
            txtStock.BackgroundImageLayout = ImageLayout.None;
            txtStock.BeepOnError = false;
            txtStock.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtStock.Depth = 0;
            txtStock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStock.HidePromptOnLeave = false;
            txtStock.HideSelection = true;
            txtStock.InsertKeyMode = InsertKeyMode.Default;
            txtStock.LeadingIcon = null;
            txtStock.Location = new Point(135, 389);
            txtStock.Mask = "";
            txtStock.MaxLength = 32767;
            txtStock.MouseState = MaterialSkin.MouseState.OUT;
            txtStock.Name = "txtStock";
            txtStock.PasswordChar = '\0';
            txtStock.PrefixSuffixText = null;
            txtStock.PromptChar = '_';
            txtStock.ReadOnly = false;
            txtStock.RejectInputOnFirstFailure = false;
            txtStock.ResetOnPrompt = true;
            txtStock.ResetOnSpace = true;
            txtStock.RightToLeft = RightToLeft.No;
            txtStock.SelectedText = "";
            txtStock.SelectionLength = 0;
            txtStock.SelectionStart = 0;
            txtStock.ShortcutsEnabled = true;
            txtStock.Size = new Size(228, 48);
            txtStock.SkipLiterals = true;
            txtStock.TabIndex = 9;
            txtStock.TabStop = false;
            txtStock.TextAlign = HorizontalAlignment.Left;
            txtStock.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtStock.TrailingIcon = null;
            txtStock.UseSystemPasswordChar = false;
            txtStock.ValidatingType = null;
            // 
            // txtCosto
            // 
            txtCosto.AllowPromptAsInput = true;
            txtCosto.AnimateReadOnly = false;
            txtCosto.AsciiOnly = false;
            txtCosto.BackgroundImageLayout = ImageLayout.None;
            txtCosto.BeepOnError = false;
            txtCosto.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCosto.Depth = 0;
            txtCosto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCosto.HidePromptOnLeave = false;
            txtCosto.HideSelection = true;
            txtCosto.InsertKeyMode = InsertKeyMode.Default;
            txtCosto.LeadingIcon = null;
            txtCosto.Location = new Point(135, 325);
            txtCosto.Mask = "";
            txtCosto.MaxLength = 32767;
            txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            txtCosto.Name = "txtCosto";
            txtCosto.PasswordChar = '\0';
            txtCosto.PrefixSuffixText = null;
            txtCosto.PromptChar = '_';
            txtCosto.ReadOnly = false;
            txtCosto.RejectInputOnFirstFailure = false;
            txtCosto.ResetOnPrompt = true;
            txtCosto.ResetOnSpace = true;
            txtCosto.RightToLeft = RightToLeft.No;
            txtCosto.SelectedText = "";
            txtCosto.SelectionLength = 0;
            txtCosto.SelectionStart = 0;
            txtCosto.ShortcutsEnabled = true;
            txtCosto.Size = new Size(228, 48);
            txtCosto.SkipLiterals = true;
            txtCosto.TabIndex = 8;
            txtCosto.TabStop = false;
            txtCosto.TextAlign = HorizontalAlignment.Left;
            txtCosto.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCosto.TrailingIcon = null;
            txtCosto.UseSystemPasswordChar = false;
            txtCosto.ValidatingType = null;
            // 
            // txtPrecio
            // 
            txtPrecio.AllowPromptAsInput = true;
            txtPrecio.AnimateReadOnly = false;
            txtPrecio.AsciiOnly = false;
            txtPrecio.BackgroundImageLayout = ImageLayout.None;
            txtPrecio.BeepOnError = false;
            txtPrecio.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecio.Depth = 0;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecio.HidePromptOnLeave = false;
            txtPrecio.HideSelection = true;
            txtPrecio.InsertKeyMode = InsertKeyMode.Default;
            txtPrecio.LeadingIcon = null;
            txtPrecio.Location = new Point(135, 261);
            txtPrecio.Mask = "";
            txtPrecio.MaxLength = 32767;
            txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PasswordChar = '\0';
            txtPrecio.PrefixSuffixText = null;
            txtPrecio.PromptChar = '_';
            txtPrecio.ReadOnly = false;
            txtPrecio.RejectInputOnFirstFailure = false;
            txtPrecio.ResetOnPrompt = true;
            txtPrecio.ResetOnSpace = true;
            txtPrecio.RightToLeft = RightToLeft.No;
            txtPrecio.SelectedText = "";
            txtPrecio.SelectionLength = 0;
            txtPrecio.SelectionStart = 0;
            txtPrecio.ShortcutsEnabled = true;
            txtPrecio.Size = new Size(228, 48);
            txtPrecio.SkipLiterals = true;
            txtPrecio.TabIndex = 7;
            txtPrecio.TabStop = false;
            txtPrecio.TextAlign = HorizontalAlignment.Left;
            txtPrecio.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecio.TrailingIcon = null;
            txtPrecio.UseSystemPasswordChar = false;
            txtPrecio.ValidatingType = null;
            // 
            // txtNombre
            // 
            txtNombre.AllowPromptAsInput = true;
            txtNombre.AnimateReadOnly = false;
            txtNombre.AsciiOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.BeepOnError = false;
            txtNombre.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HidePromptOnLeave = false;
            txtNombre.HideSelection = true;
            txtNombre.InsertKeyMode = InsertKeyMode.Default;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(135, 134);
            txtNombre.Mask = "";
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.PromptChar = '_';
            txtNombre.ReadOnly = false;
            txtNombre.RejectInputOnFirstFailure = false;
            txtNombre.ResetOnPrompt = true;
            txtNombre.ResetOnSpace = true;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(228, 48);
            txtNombre.SkipLiterals = true;
            txtNombre.TabIndex = 5;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.ValidatingType = null;
            // 
            // txtCodigo
            // 
            txtCodigo.AllowPromptAsInput = true;
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AsciiOnly = false;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.BeepOnError = false;
            txtCodigo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HidePromptOnLeave = false;
            txtCodigo.HideSelection = true;
            txtCodigo.InsertKeyMode = InsertKeyMode.Default;
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(135, 70);
            txtCodigo.Mask = "";
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.PromptChar = '_';
            txtCodigo.ReadOnly = false;
            txtCodigo.RejectInputOnFirstFailure = false;
            txtCodigo.ResetOnPrompt = true;
            txtCodigo.ResetOnSpace = true;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(228, 48);
            txtCodigo.SkipLiterals = true;
            txtCodigo.TabIndex = 4;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            txtCodigo.ValidatingType = null;
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
            txtBuscarProducto.Location = new Point(6, 6);
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
            // btnBuscar
            // 
            btnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscar.Depth = 0;
            btnBuscar.HighEmphasis = true;
            btnBuscar.Icon = null;
            btnBuscar.Location = new Point(252, 11);
            btnBuscar.Margin = new Padding(4, 6, 4, 6);
            btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoAccentTextColor = Color.Empty;
            btnBuscar.Size = new Size(77, 36);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscar.UseAccentColor = false;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.Location = new Point(559, 306);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(88, 36);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cmbMetodoPago);
            tabPage3.Controls.Add(lblMetodoPago);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(btnValidarVenta);
            tabPage3.Controls.Add(materialCard2);
            tabPage3.Controls.Add(btnQuitarProducto);
            tabPage3.Controls.Add(btnCancelarVenta);
            tabPage3.Controls.Add(lblCantidad);
            tabPage3.Controls.Add(nmrCantidadProducto);
            tabPage3.Controls.Add(btnAgregarAlCarrito);
            tabPage3.Controls.Add(lblCarrito);
            tabPage3.Controls.Add(lblProductosDisponibles);
            tabPage3.Controls.Add(txtBuscarPorCodigo);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Controls.Add(btnCodigoProducto);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(986, 505);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Carrito";
            tabPage3.UseVisualStyleBackColor = true;
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
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(169, 435);
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
            lblMetodoPago.Location = new Point(31, 451);
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
            dataGridView3.Size = new Size(400, 230);
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
            lblCantidad.Location = new Point(32, 390);
            lblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(65, 19);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // nmrCantidadProducto
            // 
            nmrCantidadProducto.Location = new Point(121, 389);
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
            btnAgregarAlCarrito.Location = new Point(258, 380);
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
            txtBuscarPorCodigo.Location = new Point(31, 291);
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
            btnCodigoProducto.Location = new Point(202, 299);
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
            // tabPage4
            // 
            tabPage4.Controls.Add(lblReporteVentasDia);
            tabPage4.Controls.Add(btnRecarcularPlinq);
            tabPage4.Controls.Add(materialCard4);
            tabPage4.Controls.Add(materialCard3);
            tabPage4.Controls.Add(dgvReporteVentas);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(986, 505);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reporte de Ventas";
            tabPage4.UseVisualStyleBackColor = true;
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
            // FormMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormMenuPrincipal";
            Text = "Colmado Alegria";
            materialTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarProducto;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStock;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCosto;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNombre;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStockMinimo;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialLabel lblStockMinimo;
        private MaterialSkin.Controls.MaterialLabel lblStock;
        private MaterialSkin.Controls.MaterialLabel lblCosto;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoria;
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
    }
}
