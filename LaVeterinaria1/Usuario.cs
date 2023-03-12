using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaVeterinaria1
{
    public class Usuario
    {
    }

    public class Cliente
    {
        private int Key, Identificacion, Cell;
        private string Nombre, Appellidos, Direccion;

        public Cliente()
        {
            this.Key = 0;
            this.Identificacion = 0;
            this.Cell = 0;
            this.Nombre = "";
            this.Appellidos = "";
            this.Direccion = "";
        }
        public Cliente(int Key, int Identificacion, int Cell, string Nombre, string Appellidos, string Direccion)
        {
            this.Key = Key;
            this.Identificacion = Identificacion;
            this.Cell = Cell;
            this.Nombre = Nombre;
            this.Appellidos = Appellidos;
            this.Direccion = Direccion;
        }
        public static bool Guardar_Cliente(Cliente Cliente)
        {
            Cliente.setKey(Return_Key());
            if (Verificar_IdCliente(Cliente.getIdentificacion()) != true)
            { 
                StreamWriter writer;
                string RutaArchuivo = "Clientes.txt";
                if (File.Exists(RutaArchuivo))
                {
                    writer = File.AppendText(RutaArchuivo);
                }
                else
                {
                    List<Cliente> Usuari;
                    writer = new StreamWriter(RutaArchuivo);
                }
                string resultado = Cliente.Return_Info();
                writer.WriteLine(resultado);
                writer.Close();
                return true;
            }else { return false; }
        }
        public string Return_Info()
        {
            string Resultado = Key + ";" +  Identificacion + ";" + Cell + ";" + Nombre + ";" + Appellidos + ";" + Direccion;
            return Resultado;
        }
        public static List<Cliente> Cargar_Cliente()
        {
            StreamReader reader = new StreamReader("Clientes.txt");
            List<Cliente> Cliente = new List<Cliente>();
            Cliente Client;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] valores = line.Split(';');
                Client = new Cliente(Convert.ToInt16(valores[0]), Convert.ToInt16(valores[1]), Convert.ToInt16(valores[2]), valores[3], valores[4], valores[5]);
                Cliente.Add(Client);
            }
            reader.Close();
            return Cliente;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Cliente> Cliente = Cargar_Cliente();
            foreach (Cliente Client in Cliente)
            {
                int ID = Client.getIdentificacion();
                if (IdCliente == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Return_Key()
        {
            if (Existencia_Archivo())
            {
                StreamReader reader = new StreamReader("Clientes.txt");
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    List<Cliente> Clientes = Cargar_Cliente();
                    Cliente Cliente = Clientes[Clientes.Count - 1];
                    int key = Cliente.getKey() + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
                return 1;
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Clientes.txt");
        }
        public int getKey()
        {
            return this.Key;
        }
        public int setKey(int Key)
        {
            return this.Key = Key;
        }
        public int getIdentificacion()
        {
            return this.Identificacion;
        }
        public int setIdentificacion(int Identificacion)
        {
            return this.Identificacion = Identificacion;
        }
    }

    public class Mascota
    {
        private string Nombre, TipoAnimal, Raza;
        private int Key, Peso, Medida, IdCliente;

        public Mascota()
        {
            this.Key = 0;
            this.Nombre = "";
            this.TipoAnimal = "";
            this.Raza = "";
            this.Peso = 0;
            this.Medida = 0;
            this.IdCliente = 0;
        }
        public Mascota(int Key, string Nombre, string TipoAnimal, string Raza, int Peso, int Medida, int IdCliente)
        {
            this.Key = Key;
            this.Nombre = Nombre;
            this.TipoAnimal = TipoAnimal;
            this.Raza = Raza;
            this.Peso = Peso;
            this.Medida = Medida;
            this.IdCliente = IdCliente;
        }
        public static bool Guardar_Mascota(Mascota Mascota)
        {
            Mascota.setKey(Return_Key());
            if (Verificar_IdCliente(Mascota.getIdCliente()) != true)
            {
                StreamWriter writer;
                string RutaArchuivo = "Mascotas.txt";
                if (File.Exists(RutaArchuivo))
                {
                    writer = File.AppendText(RutaArchuivo);
                }
                else
                {
                    List<Cliente> Usuari;
                    writer = new StreamWriter(RutaArchuivo);
                }
                string resultado = Mascota.Return_Info();
                writer.WriteLine(resultado);
                writer.Close();
                return true;
            }
            else { return false; }
        }
        public string Return_Info()
        {
            string Resultado = Key + ";" + Nombre + ";" + TipoAnimal + ";" + Raza + ";" + Peso + ";" + Medida + ";" + IdCliente;
            return Resultado;
        }
        public static List<Mascota> Cargar_Mascota()
        {
            StreamReader reader = new StreamReader("Mascotas.txt");
            List<Mascota> Mascota = new List<Mascota>();
            Mascota Pet;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] valores = line.Split(';');
                Pet = new Mascota(Convert.ToInt16(valores[0]), valores[1], valores[2], valores[3], Convert.ToInt16(valores[4]), Convert.ToInt16(valores[5]), Convert.ToInt16(valores[6]));
                Mascota.Add(Pet);
            }
            reader.Close();
            return Mascota;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Mascota> Mascota = Cargar_Mascota();
            foreach (Mascota Pet in Mascota)
            {
                int ID = Pet.getIdCliente();
                if (IdCliente == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Return_Key()
        {
            if (Existencia_Archivo())
            {
                StreamReader reader = new StreamReader("Mascotas.txt");
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    List<Mascota> Mascotas = Cargar_Mascota();
                    Mascota Mascota = Mascotas[Mascotas.Count - 1];
                    int key = Mascota.getKey() + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
                return 1;
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Mascotas.txt");
        }
        public int getKey()
        {
            return this.Key;
        }
        public int setKey(int Key)
        {
            return this.Key = Key;
        }
        public int getIdCliente()
        {
            return this.IdCliente;
        }
        public int setIdCliente(int IdCliente)
        {
            return this.IdCliente = IdCliente;
        }
    }
}
