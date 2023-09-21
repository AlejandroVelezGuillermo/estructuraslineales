using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace estructuras_lineales
{
    public partial class Form1 : Form
    {
        // Definimos la estructura de un nodo de la lista enlazada
        private class Nodo
        {
            public int Valor;
            public Nodo Siguiente;

            public Nodo(int valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        private Nodo cabeza; // El primer nodo de la lista enlazada
        public Form1()
        {
            InitializeComponent();
            cabeza = null; // Inicialmente, la lista está vacía
        }

        private void AgregarElemento_Click(object sender, EventArgs e)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo nodoActual = cabeza;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                nodoActual.Siguiente = nuevoNodo;
            }
        }

        private void EliminarElemento_Click(object sender, EventArgs e)
        {
            if (cabeza == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            if (cabeza.Valor == valor)
            {
                cabeza = cabeza.Siguiente;
                return;
            }

            Nodo nodoActual = cabeza;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Valor == valor)
                {
                    nodoActual.Siguiente = nodoActual.Siguiente.Siguiente;
                    return;
                }
                nodoActual = nodoActual.Siguiente;
            }

            MessageBox.Show("El elemento no se encontró en la lista.");
        }
        // Función para mostrar los elementos de la lista en un ListBox
        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Nodo nodoActual = cabeza;
            while (nodoActual != null)
            {
                listBox1.Items.Add(nodoActual.Valor);
                nodoActual = nodoActual.Siguiente;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBox1.Text);
            AgregarElemento(valor);
            MostrarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBox2.Text);
            EliminarElemento(valor);
            MostrarLista();
        }
    }
}
