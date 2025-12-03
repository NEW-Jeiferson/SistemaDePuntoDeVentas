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
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
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
            txtCategoria = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtCodigo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtBuscarProducto = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnBuscar = new MaterialSkin.Controls.MaterialButton();
            btnAgregar = new MaterialSkin.Controls.MaterialButton();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            materialTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(944, 533);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(936, 505);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLimpiar);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(936, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(820, 440);
            btnLimpiar.Margin = new Padding(4, 6, 4, 6);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(79, 36);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(683, 440);
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
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(555, 440);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(480, 380);
            dataGridView1.TabIndex = 1;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
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
            materialCard1.Controls.Add(txtCategoria);
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
            // txtCategoria
            // 
            txtCategoria.AllowPromptAsInput = true;
            txtCategoria.AnimateReadOnly = false;
            txtCategoria.AsciiOnly = false;
            txtCategoria.BackgroundImageLayout = ImageLayout.None;
            txtCategoria.BeepOnError = false;
            txtCategoria.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCategoria.Depth = 0;
            txtCategoria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategoria.HidePromptOnLeave = false;
            txtCategoria.HideSelection = true;
            txtCategoria.InsertKeyMode = InsertKeyMode.Default;
            txtCategoria.LeadingIcon = null;
            txtCategoria.Location = new Point(135, 198);
            txtCategoria.Mask = "";
            txtCategoria.MaxLength = 32767;
            txtCategoria.MouseState = MaterialSkin.MouseState.OUT;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PasswordChar = '\0';
            txtCategoria.PrefixSuffixText = null;
            txtCategoria.PromptChar = '_';
            txtCategoria.ReadOnly = false;
            txtCategoria.RejectInputOnFirstFailure = false;
            txtCategoria.ResetOnPrompt = true;
            txtCategoria.ResetOnSpace = true;
            txtCategoria.RightToLeft = RightToLeft.No;
            txtCategoria.SelectedText = "";
            txtCategoria.SelectionLength = 0;
            txtCategoria.SelectionStart = 0;
            txtCategoria.ShortcutsEnabled = true;
            txtCategoria.Size = new Size(228, 48);
            txtCategoria.SkipLiterals = true;
            txtCategoria.TabIndex = 6;
            txtCategoria.TabStop = false;
            txtCategoria.TextAlign = HorizontalAlignment.Left;
            txtCategoria.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCategoria.TrailingIcon = null;
            txtCategoria.UseSystemPasswordChar = false;
            txtCategoria.ValidatingType = null;
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
            btnAgregar.Location = new Point(420, 440);
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(936, 505);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Carrito";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(936, 505);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reporte de Ventas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(936, 505);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Historial";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(950, 600);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "FormMenuPrincipal";
            Text = "Colmado Alegria";
            materialTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarProducto;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStock;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCosto;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCategoria;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNombre;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtStockMinimo;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialLabel lblStockMinimo;
        private MaterialSkin.Controls.MaterialLabel lblStock;
        private MaterialSkin.Controls.MaterialLabel lblCosto;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
    }
}
