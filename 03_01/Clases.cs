using System.Text;

namespace _03_01
{
    // **** CLASE **** //
    internal class Cuenta
    {
        // **** ATRIBUTOS **** //
        private string titular;
        private decimal cantidad;

        // **** METODOS **** //

        // CONSTRUCTOR
        public Cuenta(string titular, decimal cantidad)
        {
            AsignarTitular(titular);
            AsignarCantidad(cantidad);

            /*
            //En caso de no tener Setters
            this.titular = titular.ToUpper();
            this.cantidad = cantidad;
            // Click derecho fondo - Acciones rapidas - Crear constructor automaticamente o Click derecho atributos - Crear constructor
            */
        }

        // SETTER
        public void AsignarTitular(string titular)
        {
            if (string.IsNullOrWhiteSpace(titular))
            {
                titular = "Sin datos";
            }
            this.titular = titular.ToUpper();
        }
        public void AsignarCantidad(decimal cantidad)
        {
            if (cantidad < 0)
            {
                cantidad = 0;
            }
            this.cantidad = cantidad;
        }

        // GETTER
        public string ObtenerTitular()
        {
            return this.titular;
        }

        public decimal ObtenerCantidad()
        {
            return this.cantidad;
        }

        // MOSTRAR
        public string ObtenerCuenta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DE LA CUENTA");
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Cantidad: {cantidad:C2}");
            return sb.ToString();
        }

        // FUNCIONES

        public void IngresarCantidad(decimal monto)
        {
            if (monto < 0)
            {
                monto = 0;
            }
            this.cantidad += monto;
        }

        public void RetirarCantidad(decimal monto)
        {
            if (monto < 0)
            {
                monto = -1 * monto;
            }
            this.cantidad -= monto;
        }

    }
}
