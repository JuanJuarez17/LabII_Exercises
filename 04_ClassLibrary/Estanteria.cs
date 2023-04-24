using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estanteria
{
    public class Producto
    {
        #region ATTRIBUTES
        private string codigoBarra;
        private string marca;
        private float precio;
        #endregion

        #region CONSTRUCTOR
        public Producto(string bufferCodigo, string bufferMarca, float bufferPrecio)
        {
            this.codigoBarra = bufferCodigo;
            this.marca = bufferMarca;
            this.precio = bufferPrecio;
        }
        #endregion

        #region GETTERS
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region METHODS
        public static string MostrarProducto(Producto buffer)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barra: {buffer.codigoBarra,14}");
            sb.AppendLine($"Marca: {buffer.marca,24}");
            sb.AppendLine($"Precio:{"",17}{buffer.precio:C2}");
            sb.Append("-------------------------------");
            return sb.ToString();
        }
        #endregion

        #region CONVERSION OPERATORS
        public static explicit operator string(Producto buffer)
        {
            return buffer.codigoBarra;
        }
        #endregion

        #region OPERATORS
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1 is not null && prod2 is not null)
            {
                if (prod1.codigoBarra == prod2.codigoBarra && prod1.marca == prod2.marca)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        public static bool operator ==(Producto prod1, string buffer)
        {
            if (prod1.marca == buffer)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto prod1, string buffer)
        {
            return !(prod1 == buffer);
        }
        #endregion
    }

    public class Estante
    {
        #region ATTRIBUTES
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region CONSTRUCTOR
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region GETTERS
        public Producto[] GetProducto()
        {
            return this.productos;
        }
        #endregion

        #region METHODS
        public static string MostrarEstante(Estante buffer)
        {
            int flagCharge = 0;
            Producto[] auxProd = buffer.GetProducto();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ESTANTE {"",19} N°{buffer.ubicacionEstante}");
            sb.AppendLine("---------- PRODUCTOS ----------");
            for (int i = 0; i < auxProd.Length; i++)
            {
                if (auxProd[i] is not null)
                {
                    sb.AppendLine(Producto.MostrarProducto(auxProd[i]));
                    flagCharge = 1;
                }
            }
            if (flagCharge == 0)
            {
                sb.AppendLine("-------- SIN PRODUCTOS --------");
            }
            return sb.ToString();
        }
        #endregion

        #region OPERATORS
        public static bool operator ==(Estante inputEstante, Producto inputProducto)
        {
            for (int i = 0; i < inputEstante.productos.Length; i++)
            {
                if (inputEstante.productos[i] == inputProducto) // Llama al operador prod == prod el cual compara marca y codigo barras
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante inputEstante, Producto inputProducto)
        {
            return !(inputEstante == inputProducto);
        }
        public static bool operator +(Estante inputEstante, Producto inputProducto)
        {
            if (inputEstante != inputProducto) // Verifico si el producto no se encuentra en el estante
            {
                for (int i = 0; i < inputEstante.productos.Length; i++)
                {
                    if (inputEstante.productos[i] is null)
                    {
                        inputEstante.productos[i] = inputProducto;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante inputEstante, Producto inputProducto)
        {
            if (inputEstante == inputProducto)
            {
                Estante rtnEstante = inputEstante;
                for (int i = 0; i < rtnEstante.productos.Length; i++)
                {
                    if (rtnEstante.productos[i] == inputProducto)
                    {
                        rtnEstante.productos[i] = null;
                    }
                }
                return rtnEstante;
            }
            return inputEstante;
        }
        #endregion
    }
}
