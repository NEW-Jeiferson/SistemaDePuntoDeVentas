using MaterialSkin;
using MaterialSkin.Controls;
using CapaNegocios.Servicios;
using CapaNegocios.Entidades;
using CapaNegocios.Exepciones;
using CapaNegocios.Eventos;
using CapaNegocios.Repositorios;
using System.Drawing;


namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : MaterialSkin.Controls.MaterialForm
    {
        private InventarioService inventarioService;
        private VentaService ventaService;
        private ClienteRepositorio clienteRepo;

        //TODO: Venta actual, esto sera el carrito de compras
        private Ventas ventaActual;
        private Cliente clienteActual;

        //TODO: Usuario actual, que lo recibimos del login
        private int usuarioActualID;
        private string nombreUsuario;

        public FormMenuPrincipal(int usuarioID, string nombre)
        {
            InitializeComponent();

            //TODO: Inicializar servicios y repositorios
            this.usuarioActualID = usuarioID;
            this.nombreUsuario = nombre;

            //TODO: Inicializar servicios y repositorios
            InicializarNuevaVenta();
            ConfigurarMaterialSkin();
            ConfigurarComboBoxes();
            ConfigurarEventosDeControles();
            InicializarServiciosAsync();

            //TODO: Inicializar la venta actual
            this.Text = $"Colmado Alegria - Usuario: {nombreUsuario}";
        }

        /// <summary>
        /// COMO ESTA VAINA ESTA ECHA EN TAB CONTROLS Y NO POR DIFERENTES FORM LO QUE HARE SERA PONER REGIONES
        /// PARA CADA CONFIGURACION INICIAL DE CADA TAB Y ASI TENERLO MAS ORDENADO Y UNO NO SE PIERDA COMO ZORO
        /// </summary>

        #region Configuracion Incial
        //TODO: Configurar Material Skin
        private void ConfigurarMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green700,
                Primary.Green900,
                Primary.Green500,
                Accent.LightGreen200,
                TextShade.WHITE
            );
        }

        //TODO: Configurar ComboBoxes
        private void ConfigurarComboBoxes()
        {
            //TODO: ComboBox encargado de Metodo de Pago
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.AddRange(new[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.SelectedIndex = 0;

            //TODO: ComboBox Tipo de Cliente, el que esta en Registrar Cliente / Esto es en registro cliente
            cmbIngreseTipoCliente.Items.Clear();
            cmbIngreseTipoCliente.Items.AddRange(new[] { "General", "A por mayor" });
            cmbIngreseTipoCliente.SelectedIndex = 0;
        }

        //TODO: Inicializar servicios y cargar datos iniciales
        private async void InicializarServiciosAsync()
        {
            try
            {
                //TODO: Inicializar servicios
                inventarioService = new InventarioService();
                ventaService = new VentaService(inventarioService);
                clienteRepo = new ClienteRepositorio();

                //TODO: Cargar inventario usando Task.WhenAll, eso pa cumplir todos los requisitos
                lblEstadoCargando.Text = "Cargando inventario...";
                await inventarioService.CargarInventarioAsync();
                lblEstadoCargando.Text = "Inventario cargado";

                //TODO: Cargar inventario en DataGridView
                await CargarInventarioEnGrid();
                
                //TODO: Cargar CLientes en DataGridView
                await CargarClientesEnGrid();

                //TODO: Suscribirse a eventos de negocio para que notifiquen la interfaz
                inventarioService.InventarioBajo += InventarioService_InventarioBajo;
                ventaService.ProductoAgregado += VentaService_ProductoAgregado;
                ventaService.VentaCompletada += VentaService_VentaCompletada;

                MessageBox.Show("Sistema inicializado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //TODO: Manejar errores de inicializacion para que no explote
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar sistema: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Configurar eventos de controles
        private void ConfigurarEventosDeControles()
        {
            //TODO: TABPAGE INVENTARIO
            btnBuscarProducto.Click += BtnBuscarProducto_Click;

            //TODO: TABPAGE CARRITO
            btnCodigoProducto.Click += BtnBuscarPorCodigo_Click;
            btnAgregarAlCarrito.Click += BtnAgregarAlCarrito_Click;
            btnQuitarProducto.Click += BtnQuitarProducto_Click;
            btnValidarVenta.Click += BtnProcesarVenta_Click;
            btnCancelarVenta.Click += BtnCancelarVenta_Click;
            btnAgregarClienteAlCarrito.Click += BtnAgregarClienteAlCarrito_Click;

            //TODO: Validacion solo numeros en RNC del cliente para el carrito
            txtRNCdeClienteParaCarrito.KeyPress += SoloNumeros_KeyPress;
            txtRNCdeClienteParaCarrito.MaxLength = 11;

            //TODO: TABPAGE REPORTES
            btnReporte.Click += BtnCargarReporte_Click;
            btnRecarcularPlinq.Click += BtnRecalcularPlinq_Click;

            //TODO: TABPAGE CLIENTES
            btnBuscarCliente.Click += BtnBuscarCliente_Click;
            btnIngreseCliente.Click += BtnRegistrarCliente_Click;
            btnQuitarCliente.Click += BtnQuitarCliente_Click;

            //TODO: Validacion solo numeros en RNC del cliente para registro
            txtRncCliente.KeyPress += SoloNumeros_KeyPress;
            txtRncCliente.MaxLength = 11;
            txtIngreseRNC.KeyPress += SoloNumeros_KeyPress;
            txtIngreseRNC.MaxLength = 11;

            //TODO: Validacion solo letras en nombre del cliente para registro
            txtIngreseNombreCliente.KeyPress += SoloLetras_KeyPress;
            txtIngreseNombreCliente.MaxLength = 100;

            //TODO: Configurar NumericUpDown, esto para que no se pase de rango
            nmrCantidadProducto.Minimum = 1;
            nmrCantidadProducto.Maximum = 1000;
            nmrCantidadProducto.Value = 1;

            //TODO: Boton salir del sistema
            btnSalirDelSistema.Click += BtnSalirDelSistema_Click;
        }

        //TODO: Inicializar nueva venta
        private void InicializarNuevaVenta()
        {
            ventaActual = new Ventas
            {
                UsuarioID = usuarioActualID,
                Fecha = DateTime.Now,
                MetodoPago = "Efectivo"
            };

            clienteActual = null;
        }
        #endregion

        #region EVENTOS DE NEGOCIO
        private void InventarioService_InventarioBajo(object sender, InventarioBajoEventArgs e)
        {
            //TODO: Mostrar alerta de inventario bajo
            MessageBox.Show(
                $"ALERTA DE INVENTARIO BAJO\n\n" +
                $"Producto: {e.Producto.Nombre}\n" +
                $"Código: {e.Producto.Codigo}\n" +
                $"Stock actual: {e.StockActual}\n" +
                $"Stock mínimo: {e.StockMinimo}",
                "Inventario Bajo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            //TODO: Actualizar productos con stock bajo
            CargarProductosStockBajo();
        }

        //TODO: Evento cuando se agrega un producto al carrito
        private void VentaService_ProductoAgregado(object sender, ProductoAgregadoEventArgs e)
        {
            lblEstadoCargando.Text = $" {e.Producto.Nombre} agregado x{e.Cantidad}";
            ActualizarInterfazVenta();
        }

        //TODO: Evento cuando se completa una venta
        private void VentaService_VentaCompletada(object sender, VentaCompletadaEventArgs e)
        {
            decimal cambio = e.Cambio;

            MessageBox.Show(
                $"VENTA COMPLETADA EXITOSAMENTE\n\n" +
                $"Venta #: {e.Venta.VentaID}\n" +
                $"Subtotal: {e.Venta.Subtotal.AFormatoDominicano()}\n" +
                $"ITBIS (18%): {e.Venta.ITBIS.AFormatoDominicano()}\n" +
                $"Descuento: {e.Venta.Descuento.AFormatoDominicano()}\n" +
                $"Total: {e.Venta.Total.AFormatoDominicano()}\n\n" +
                $"Pagado: {e.MontoPagado.AFormatoDominicano()}\n" +
                $"Cambio: {cambio.AFormatoDominicano()}",
                "Venta Exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            InicializarNuevaVenta();
            ActualizarInterfazVenta();
        }

        #endregion

        #region TAB INVENTARIO

        //TODO: Boton buscar producto en inventario
        private async void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Obtener texto de busqueda
                string busqueda = txtBuscarProducto.Text.Trim();

                if (string.IsNullOrEmpty(busqueda) || busqueda == "Buscar Producto")
                {
                    await CargarInventarioEnGrid();
                    return;
                }

                //TODO: Buscar por nombre primero
                var productosPorNombre = await inventarioService.BuscarPorNombreAsync(busqueda);

                //TODO: Luego buscar por codigo y agregar si no esta en la lista
                try
                {
                    var productoPorCodigo = await inventarioService.BuscarPorCodigoAsync(busqueda);
                    if (productoPorCodigo != null)
                    {
                        //TODO: Si ya existe en la lista, no lo agregamos
                        if (!productosPorNombre.Any(p => p.ProductoID == productoPorCodigo.ProductoID))
                        {
                            productosPorNombre.Insert(0, productoPorCodigo);
                        }
                    }
                }
                catch (CodigoInvalidoException)
                {
                    //TODO: No hacer nada si el codigo es invalido
                }

                //TODO: Mostrar mensaje si no se encontraron productos
                if (productosPorNombre.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos", "Busqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridView1.DataSource = productosPorNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Cargar inventario en DataGridView
        private async Task CargarInventarioEnGrid()
        {
            try
            {
                var productos = await inventarioService.BuscarPorNombreAsync("");
                dataGridView1.DataSource = productos;

                //TODO: Configurar columnas
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["ProductoID"].Visible = false;
                    dataGridView1.Columns["Costo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Cargar productos con stock bajo
        private async void CargarProductosStockBajo()
        {
            try
            {
                var productos = await inventarioService.ObtenerProductosStockBajoAsync();
                dataGridView2.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TAB CARRITO

        //TODO: Boton buscar producto por codigo
        private async void BtnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtBuscarPorCodigo.Text.Trim();

                if (string.IsNullOrEmpty(codigo) || codigo == "Ingresa el Codigo")
                {
                    MessageBox.Show("Ingrese un código de producto", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //TODO: Buscar producto y mostrarlo
                var producto = await inventarioService.BuscarPorCodigoAsync(codigo);

                if (producto != null)
                {
                    dataGridView3.DataSource = new[] { producto };
                    lblEstadoCargando.Text = $"Producto encontrado: {producto.Nombre}";
                }
            }
            catch (CodigoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Codigo Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton agregar cliente al carrito
        private async void BtnAgregarClienteAlCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                string rnc = txtRNCdeClienteParaCarrito.Text.Trim();

                if (string.IsNullOrEmpty(rnc))
                {
                    MessageBox.Show("Ingrese el RNC del cliente", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //TODO: Buscar cliente por RNC en el repositorio de clientes para conectar a la venta
                var cliente = await clienteRepo.BuscarPorRNCAsync(rnc);

                if (cliente != null)
                {
                    clienteActual = cliente;
                    ventaActual.Cliente = cliente.Nombre;

                    MessageBox.Show(
                        $"Cliente agregado a la venta:\n\n" +
                        $"Nombre: {cliente.Nombre}\n" +
                        $"RNC: {cliente.RNC}\n" +
                        $"Tipo: {cliente.TipoCliente}\n" +
                        $"Descuento: {cliente.PorcentajeDescuento:P0}",
                        "Cliente Agregado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    lblEstadoCargando.Text = $"Cliente: {cliente.Nombre} ({cliente.TipoCliente})";
                }
                else
                {
                    MessageBox.Show(
                        "Cliente no encontrado.\n\n¿Desea registrarlo?",
                        "Cliente No Encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    clienteActual = null;
                    ventaActual.Cliente = "Cliente General";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton agregar producto al carrito
        private async void BtnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtBuscarPorCodigo.Text.Trim();

                if (string.IsNullOrEmpty(codigo) || codigo == "Ingresa el Codigo")
                {
                    MessageBox.Show("Ingrese un codigo de producto", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cantidad = (int)nmrCantidadProducto.Value;

                //TODO: Agregar producto al carrito (USA EL SERVICIO)
                await ventaService.AgregarProductoAsync(ventaActual, codigo, cantidad);

                //TODO: Limpiar campos
                txtBuscarPorCodigo.Text = "Ingresa el Codigo";
                txtBuscarPorCodigo.ForeColor = Color.LightGray;
                nmrCantidadProducto.Value = 1;
            }
            catch (CodigoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Codigo Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ProductoAgotadoException ex)
            {
                MessageBox.Show(ex.Message, "Stock Insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton quitar producto del carrito
        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto del carrito", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int index = dataGridView4.SelectedRows[0].Index;
                ventaActual.Items.RemoveAt(index);
                ActualizarInterfazVenta();

                lblEstadoCargando.Text = "Producto removido del carrito";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton procesar venta
        private async void BtnProcesarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Validacion obligatoria de productos en el carrito
                if (ventaActual.Items.Count == 0)
                {
                    MessageBox.Show("El carrito esta vacío", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //TODO: Validacion obligatoria de cliente en la venta
                if (clienteActual == null)
                {
                    MessageBox.Show(
                        "Debe agregar un cliente a la venta.\n\n" +
                        "Ingrese el RNC del cliente y presione el boton BUSCAR.",
                        "Cliente Requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                //TODO: Establecer metodo de pago
                ventaActual.MetodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";

                //TODO: Solicitar monto pagado
                string inputMonto = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Cliente: {clienteActual.Nombre} ({clienteActual.TipoCliente})\n" +
                    $"Descuento aplicado: {clienteActual.PorcentajeDescuento:P0}\n\n" +
                    $"Total a pagar: {ventaActual.Total.AFormatoDominicano()}\n\n" +
                    $"Ingrese el monto recibido:",
                    "Procesar Pago",
                    ventaActual.Total.ToString("F2")
                );

                if (string.IsNullOrEmpty(inputMonto)) return;

                //TODO: Validar monto pagado
                if (!decimal.TryParse(inputMonto, out decimal montoPagado))
                {
                    MessageBox.Show("Monto invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //TODO: Si es tarjeta, validar (ASYNC REQUERIDO)
                if (ventaActual.MetodoPago == "Tarjeta")
                {
                    string numeroTarjeta = Microsoft.VisualBasic.Interaction.InputBox(
                        "Ingrese los ultimos 4 dígitos de la tarjeta:",
                        "Validación de Tarjeta"
                    );

                    if (string.IsNullOrEmpty(numeroTarjeta)) return;

                    lblEstadoCargando.Text = "Validando tarjeta...";
                    bool esValida = await ventaService.ValidarTarjetaAsync(numeroTarjeta.PadLeft(16, '0'));

                    if (!esValida)
                    {
                        MessageBox.Show("Tarjeta rechazada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblEstadoCargando.Text = "Tarjeta rechazada";
                        return;
                    }

                    lblEstadoCargando.Text = "Tarjeta aprobada ✓";
                }

                //TODO: Procesar venta Try-Cacht-finally con Rollback
                lblEstadoCargando.Text = "Procesando venta...";
                await ventaService.ProcesarVentaAsync(ventaActual, montoPagado, clienteActual);

                //TODO: El evento VentaCompletada se dispara automaticamente
            }
            catch (MontoInsuficienteException ex)
            {
                MessageBox.Show(ex.Message, "Pago Insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstadoCargando.Text = "Venta no procesada";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar venta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstadoCargando.Text = "Error en la venta";
            }
        }

        //TODO: Boton cancelar venta
        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Está seguro de cancelar la venta actual?\n\n" +
                $"Se perderán {ventaActual.Items.Count} productos del carrito.",
                "Confirmar Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                InicializarNuevaVenta();
                ActualizarInterfazVenta();
                MessageBox.Show("Venta cancelada", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //TODO: Actualizar interfaz del carrito de ventas
        private void ActualizarInterfazVenta()
        {
            //TODO: Actualizar DataGridView del carrito
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = ventaActual.Items.Select(i => new
            {
                Código = i.Producto.Codigo,
                Producto = i.Producto.Nombre,
                Cantidad = i.Cantidad,
                Precio = i.PrecioUnitario,
                Subtotal = i.Subtotal,
                ITBIS = i.ITBIS,
                Total = i.Total
            }).ToList();

            //TODO: Actualizar totales
            lblMontoSubtotal.Text = ventaActual.Subtotal.AFormatoDominicano();
            lblMontoITBIS.Text = ventaActual.ITBIS.AFormatoDominicano();
            lblMontoTotal.Text = ventaActual.Total.AFormatoDominicano();
        }

        #endregion

        #region TAB REPORTES

        //TODO: Boton cargar reporte del dia
        private async void BtnCargarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpFecha.Value.Date;

                lblEstadoCargando.Text = "Cargando reporte...";
                prbProgreso.Value = 0;

                //TODO: Obtener estadísticas del día
                var estadisticas = await ventaService.ObtenerEstadisticasDelDiaAsync(fecha);

                prbProgreso.Value = 50;

                //TODO: Obtener ventas para el DataGridView
                var ventas = await ventaService.ObtenerVentasDelDiaAsync(fecha);

                prbProgreso.Value = 100;

                //TODO: Actualizar interfaz
                lblCantidadVentasFinal.Text = estadisticas["CantidadVentas"].ToString();
                lblSubtotalGenealNumero.Text = ((decimal)estadisticas["SubtotalGeneral"]).AFormatoDominicano();
                lblITBISFinal.Text = ((decimal)estadisticas["ITBISGeneral"]).AFormatoDominicano();
                lblTotalGeneralFinal.Text = ((decimal)estadisticas["TotalGeneral"]).AFormatoDominicano();

                //TODO: Cargar ventas en DataGridView
                dgvReporteVentas.DataSource = ventas.Select(v => new
                {
                    VentaID = v.VentaID,
                    Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    Cliente = v.NombreCliente,        
                    TipoCliente = v.TipoCliente,       
                    MetodoPago = v.MetodoPago,
                    Subtotal = v.Subtotal,
                    ITBIS = v.ITBIS,
                    Descuento = v.Descuento,
                    Total = v.Total
                }).ToList();

                lblEstadoCargando.Text = "Reporte cargado";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstadoCargando.Text = "Error al cargar reporte";
            }
        }

        //TODO: Boton recalcular reporte con PLINQ
        private async void BtnRecalcularPlinq_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpFecha.Value.Date;

                lblEstadoCargando.Text = "Recalculando con PLINQ...";

                //TODO: Usar PLINQ para recalcular (REQUISITO OBLIGATORIO)
                var reporte = await ventaService.GenerarReporteParaleloAsync(fecha);

                lblSubtotalGenealNumero.Text = reporte["TotalSubtotal"].AFormatoDominicano();
                lblITBISFinal.Text = reporte["TotalITBIS"].AFormatoDominicano();
                lblTotalGeneralFinal.Text = reporte["TotalVentas"].AFormatoDominicano();

                MessageBox.Show(
                    $"REPORTE RECALCULADO CON PLINQ\n\n" +
                    $"Total en Efectivo: {reporte["VentasEfectivo"].AFormatoDominicano()}\n" +
                    $"Total General: {reporte["TotalVentas"].AFormatoDominicano()}",
                    "Recálculo Completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                lblEstadoCargando.Text = "Recalculado con PLINQ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TAB CLIENTES

        //TODO: Boton buscar cliente por RNC
        private async void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string rnc = txtRncCliente.Text.Trim();

                if (string.IsNullOrEmpty(rnc) || rnc == "Ingrese RNC del Cliente")
                {
                    await CargarClientesEnGrid();
                    return;
                }

                var cliente = await clienteRepo.BuscarPorRNCAsync(rnc);

                if (cliente != null)
                {
                    MessageBox.Show(
                        $"Cliente encontrado:\n\n" +
                        $"Nombre: {cliente.Nombre}\n" +
                        $"RNC: {cliente.RNC}\n" +
                        $"Tipo: {cliente.TipoCliente}",
                        "Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Busqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton registrar nuevo cliente
        private async void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtIngreseNombreCliente.Text.Trim();
                string rnc = txtIngreseRNC.Text.Trim();
                string tipoCliente = cmbIngreseTipoCliente.SelectedItem?.ToString() ?? "General";

                //TODO: Validar nombre obligatorio
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del cliente", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //TODO: Validar RNC (11 digitos o vacio)
                if (!string.IsNullOrEmpty(rnc) && rnc.Length != 11)
                {
                    MessageBox.Show("El RNC debe tener solo 11 dígitos",
                        "RNC Inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoCliente = new Cliente
                {
                    Nombre = nombre,
                    RNC = rnc,
                    TipoCliente = tipoCliente
                };

                int clienteId = await clienteRepo.GuardarClienteAsync(nuevoCliente);

                MessageBox.Show($"Cliente registrado exitosamente\nID: {clienteId}", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //TODO: Limpiar campos
                txtIngreseNombreCliente.Clear();
                txtIngreseRNC.Clear();
                cmbIngreseTipoCliente.SelectedIndex = 0;

                //TODO: Recargar grid
                await CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar cliente: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: Boton quitar cliente (NO IMPLEMENTADO POR EL MOMENTO)
        private async void BtnQuitarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de eliminar cliente no implementada por seguridad.\n" +
                "En producción requeriría validaciones adicionales.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //TODO: Cargar clientes en DataGridView
        private async Task CargarClientesEnGrid()
        {
            try
            {
                var clientes = await clienteRepo.ObtenerTodosAsync();
                dataGridView5.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region EVENTOS DE TEXTBOX
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
        

        private void txtRNCdeClienteParaCarrito_Enter(object sender, EventArgs e)
        {
            if (txtRNCdeClienteParaCarrito.Text == "Ingrese RNC del Cliente")
            {
                txtRNCdeClienteParaCarrito.Text = "";
                txtRNCdeClienteParaCarrito.ForeColor = Color.LightGray;
            }
        }

        private void txtRNCdeClienteParaCarrito_Leave(object sender, EventArgs e)
        {
            if (txtRNCdeClienteParaCarrito.Text == "")
            {
                txtRNCdeClienteParaCarrito.Text = "Ingrese RNC del Cliente";
                txtRNCdeClienteParaCarrito.ForeColor = Color.LightGray;
            }
        }
        #endregion

        #region KEY PRESS VALIDATIONS

        //TODO: Permitir solo numeros en RNC
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO: Permitir solo numeros y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TODO: Solo letras y espacios en nombres de clientes
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO: Permitir letras, espacios y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        #endregion

        #region SISTEMA

        //TODO: Boton salir del sistema
        private void BtnSalirDelSistema_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
