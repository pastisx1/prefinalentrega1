namespace clases

{

    class Probarcreationclases

    {

        static void Main(string[] args)

        {

            Usuario user = new Usuario();

            Producto prod = new Producto();

            Console.WriteLine("Productos inicia con el id:{0}", prod.id);

        }

    }

    public class Usuario

    {

        private int id;

        private string nombre;

        private string apellido;

        private string nombredeusuario;

        private string contraseña;

        private string email;

        public Usuario()

        {

            id = 0;

            nombre = String.Empty;

            apellido = String.Empty;

            nombredeusuario = String.Empty;

            contraseña = String.Empty;

            email = String.Empty;

        }

    }
    public class ProductoVendido

    {

        private int id;

        private int idProducto;

        private double Stock;

        private int idVenta;

    }

    public class Venta

    {

        private int id;

        private string vendidos;

    }

    public class Producto

    {

        public int id;

        private string descripcion;

        private double costo;

        private double precioVenta;

        private int idUsuario;

        private double stock;

        public Producto()

        {

            id = 1;

            descripcion = String.Empty;

            costo = 0;

            precioVenta = 0;

            idUsuario = 0;

            stock = 0;

        }

    }
}