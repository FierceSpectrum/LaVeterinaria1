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
        public int Key { get; set; }
        public int Identificacion { get; set; }
        public int Cell { get; set; }
        public string Nombre { get; set; }
        public string Appellidos { get; set; }
        public string Direccion { get; set; }

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
            Cliente.Key = Return_Key();
            if (Verificar_IdCliente(Cliente.Identificacion) != true)
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
        public static void EliminarArchivo(List<Cliente> Cliente)
        {
            StreamWriter writer = new StreamWriter("Clientes.txt");
            int Keys = 1;
            foreach (Cliente cliente in Cliente)
            {
                cliente.Key = Keys;
                string resultado = cliente.Return_Info();
                writer.WriteLine(resultado);
                Keys++;
            }
            writer.Close();
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
                Client = new Cliente(Convert.ToInt32(valores[0]), Convert.ToInt32(valores[1]), Convert.ToInt32(valores[2]), valores[3], valores[4], valores[5]);
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
                int ID = Client.Identificacion;
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
                    int key = Cliente.Key + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Clientes.txt");
        }
    }

    public class Mascota
    {
        public string Nombre { get; set; }
        public string TipoAnimal { get; set; }
        public string Raza { get; set; }
        public int Key { get; set; }
        public int Peso { get; set; }
        public int Medida { get; set; }
        public int IdCliente { get; set; }

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
            Mascota.Key = (Return_Key());
            if (Verificar_IdCliente(Mascota.IdCliente))
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
        public static void EliminarArchivo(List<Mascota> Mascota)
        {
            StreamWriter writer = new StreamWriter("Mascotas.txt");
            int Keys = 1;
            foreach (Mascota mascota in Mascota)
            {
                mascota.Key = Keys;
                string resultado = mascota.Return_Info();
                writer.WriteLine(resultado);
                Keys++;
            }
            writer.Close();
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
            List<Cliente> Clientes = Cliente.Cargar_Cliente();
            foreach (Cliente Cliente in Clientes)
            {
                int ID = Cliente.Identificacion;
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
                    int key = Mascota.Key + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Mascotas.txt");
        }
    }
}
