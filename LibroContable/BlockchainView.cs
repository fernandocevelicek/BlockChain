using Laboratorio3;
using LibroContable.Entidades;
using LibroContable.Persistencia;
using LibroContable.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroContable
{
    public partial class BlockchainView : Form
    {
        public BlockchainView()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            CargarFlowLayoutLibros();
        }

        private void CargarFlowLayoutLibros()
        {
            if (flowLayoutBlochainItem.Controls.Count > 0)
            {
                flowLayoutBlochainItem.Controls.Clear();
            }
            int index = 0;
            foreach (Block bloque in Program.mainBlockchain.Chain)
            {
                AgregarItemBlockchain(bloque.Data, index);
                index++;
            }
        }

        private void AgregarItemBlockchain(LibroDiario libro, int index)
        {
            BlockChainItem listItem = new BlockChainItem();
            listItem.IdLibro = index.ToString();
            listItem.FechaLibro = String.Format("{0:dd/MM/yyyy}", libro.fecha);
            listItem.Asientos = libro.asientos;
            flowLayoutBlochainItem.Controls.Add(listItem);
        }
    }
}
