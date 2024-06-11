using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        //va a añadir la informacion del producto para que el cliente lo vea
        private void ComProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            String nom;
            float precio;
            cod = ComProducto.SelectedIndex;
            nom = ComProducto.SelectedItem.ToString();
            precio = ComProducto.SelectedIndex;
            //informacion de cada PRODUCTO en existencia
            //este es el CODIGO de bareras del PRODUCTO
            switch(cod)
            {
                case 0: IebCodigo.Text = "0011";break;
                case 1: IebCodigo.Text = "0022";break;
                case 2: IebCodigo.Text = "0033";break;
                case 3: IebCodigo.Text = "0044";break;
                case 4: IebCodigo.Text = "0055";break;
                case 5: IebCodigo.Text = "0066";break;
                case 6: IebCodigo.Text = "0077";break;
                case 7: IebCodigo.Text = "0088";break;
                case 8: IebCodigo.Text = "0099";break;
                default: IebCodigo.Text = "0010";break;
            }
            //este es el NOMBRE del PRODUCTO
            switch(nom)
            {
                case "Playera": IebNombre.Text = "Playera";break;
                case "Gorra": IebNombre.Text = "Gorra"; break;
                case "Pantalon": IebNombre.Text = "Pantalon";break;
                case "Calcetines": IebNombre.Text = "Calcetines";break;
                case "Chanclas": IebNombre.Text = "Chanclas";break;
                case "Chamarra": IebNombre.Text = "Chamarra";break;
                case "Tennis": IebNombre.Text = "Tennis";break;
                case "Boxers": IebNombre.Text = "Boxer";break;
                case "Calzoncillos": IebNombre.Text = "Calzoncillos";break;
                default: IebNombre.Text = "Camisa"; break;
            }
            //esta parte muestra el PRECIO
            switch(precio)
            {
                case 0: IebPrecio.Text = "50";break;
                case 1: IebPrecio.Text = "70";break;
                case 2: IebPrecio.Text = "100";break;
                case 3: IebPrecio.Text = "30";break;
                case 4: IebPrecio.Text = "120";break;
                case 5: IebPrecio.Text = "500";break;
                case 6: IebPrecio.Text = "1500";break;
                case 7: IebPrecio.Text = "100";break;
                case 8: IebPrecio.Text = "90";break;
                default: IebPrecio.Text = "60";break;
            }
        }
        //agrregara los productos a una lista 
        private void ButAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(DgbLista);

            file.Cells[0].Value = IebCodigo.Text;
            file.Cells[1].Value = IebNombre.Text;
            file.Cells[2].Value = IebPrecio.Text;
            file.Cells[3].Value = IebCantidad.Text;
            file.Cells[4].Value = (float.Parse(IebPrecio.Text) * float.Parse(IebCantidad.Text));
            
            DgbLista.Rows.Add(file);

            IebCodigo.Text = IebNombre.Text = IebPrecio.Text = IebCantidad.Text = "";

            IebPagar_Click();
        }
        //esto sirve para SUMAR la cantidad de los productos
        //si no colocas la CANTIDAD se corta el PROGRAMA
        public void IebPagar_Click()
        {
            float costot = 0;
            float contador = 0;

            contador = DgbLista.RowCount;
            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(DgbLista.Rows[i].Cells[4].Value.ToString());
            }
            IebPagar.Text = costot.ToString();
        }
        //Esto es para elimar un producto de la lsita
        private void ButEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Eliminar el Producto?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    DgbLista.Rows.Remove(DgbLista.CurrentRow);

                }

            }
            catch{}
   
        }

        private void IebEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IebDevolucion.Text = (float.Parse(IebEfectivo.Text) - float.Parse(IebPagar.Text)).ToString();
            }
            catch {}
        }
        //Esatas lineas de codigo Iimprimiran un Ticket en los documentos
        private void IebVEnder_Click(object sender, EventArgs e)
        {
            ClsFactura.CreaTicket Ticket1 = new ClsFactura.CreaTicket();

            Ticket1.TextoCentro("Cuidado con el Perro"); 
            Ticket1.TextoCentro("==================================");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); 
            Ticket1.TextoIzquierda("No Fac:011000010110111001101111");
            //esto mostrara la fecha ya la hora establecida en su PC o Laptop
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: Juanito Alcachofa");
            Ticket1.TextoIzquierda("");
            ClsFactura.CreaTicket.LineasGuion();

            ClsFactura.CreaTicket.EncabezadoVenta();
            ClsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in DgbLista.Rows)
            {
                // Producto                     //Precio                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString()));
            }


            ClsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(IebPagar.Text));
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado: ", double.Parse(IebEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto: ", double.Parse(IebDevolucion.Text));

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("==================================");
            Ticket1.TextoCentro("*     Gracias por la compra    *");

            Ticket1.TextoCentro("==================================");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);
            //esto hace que s emuestre un mensaje antes de que se cierre completamente el programa
            MessageBox.Show("Gracias por su Compra");
            //esto es para cerrar el todo
            this.Close();
        }

        private void DgbLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
