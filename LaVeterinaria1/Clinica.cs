using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaVeterinaria1
{
    public class Clinica
    {
    }

    public class Enfermedad
    {
        public int Key { get; set; }
        public int IdMascota { get; set; }
        public int KeyMascota { get; set; }
        public string NEfermedad { get; set; }

        public Enfermedad()
        {
            this.Key = 0;
            this.IdMascota = 0;
            this.NEfermedad = "";
            this.KeyMascota = 0;

        }
        public Enfermedad(int Key, int IdMascota, string NEfermedad, int KeyMascota)
        {
            this.Key = Key;
            this.IdMascota = IdMascota;
            this.NEfermedad = NEfermedad;
            this.KeyMascota = KeyMascota;
        }
        public static bool Guardar_Enfermedad(Enfermedad Enfermedad)
        {
            Enfermedad.Key = Return_Key();
            if (Verificar_IdCliente(Enfermedad.IdMascota))
            {
                StreamWriter writer;
                string RutaArchuivo = "Enfermedades.txt";
                if (File.Exists(RutaArchuivo))
                {
                    writer = File.AppendText(RutaArchuivo);
                }
                else
                {
                    List<Enfermedad> Usuari;
                    writer = new StreamWriter(RutaArchuivo);
                }
                string resultado = Enfermedad.Return_Info();
                writer.WriteLine(resultado);
                writer.Close();
                return true;
            }
            else { return false; }
        }
        public static void EliminarArchivo(List<Enfermedad> Enfermedad)
        {
            StreamWriter writer = new StreamWriter("Enfermedades.txt");
            int Keys = 1;
            foreach (Enfermedad enfermedad in Enfermedad)
            {
                enfermedad.Key = Keys;
                string resultado = enfermedad.Return_Info();
                writer.WriteLine(resultado);
                Keys++;
            }
            writer.Close();
        }
        public string Return_Info()
        {
            string Resultado = Key + ";" + IdMascota + ";" + NEfermedad + ";" + KeyMascota;
            return Resultado;
        }
        public static List<Enfermedad> Cargar_Enfermedad()
        {
            StreamReader reader = new StreamReader("Enfermedades.txt");
            List <Enfermedad> Enfermedad = new List<Enfermedad>();
            Enfermedad Disease;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] valores = line.Split(';');
                Disease = new Enfermedad(Convert.ToInt16(valores[0]), Convert.ToInt16(valores[1]), valores[2], Convert.ToInt16(valores[3]));
                Enfermedad.Add(Disease);
            }
            reader.Close();
            return Enfermedad;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Mascota> Mascotas = Mascota.Cargar_Mascota();
            foreach (Mascota Mascota in Mascotas)
            {
                int ID = Mascota.IdCliente;
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
                StreamReader reader = new StreamReader("Enfermedades.txt");
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    List<Enfermedad> Enfermedads = Cargar_Enfermedad();
                    Enfermedad Enfermedad = Enfermedads[Enfermedads.Count - 1];
                    int key = Enfermedad.Key + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Enfermedades.txt");
        }
    }
    public class Medicamento
    {
        public int Key { get; set; }
        public int IdEfermedad { get; set; }
        public int KeyEnfermedad { get; set; }
        public string NMedicamento { get; set; }
        public Medicamento()
        {
            this.Key = 0;
            this.IdEfermedad = 0;
            this.NMedicamento = "";
            this.KeyEnfermedad = 0;
        }
        public Medicamento(int Key, int IdEfermedad, string NMedicamento, int KeyEnfermedad)
        {
            this.Key = Key;
            this.IdEfermedad = IdEfermedad;
            this.NMedicamento = NMedicamento;
            this.KeyEnfermedad = KeyEnfermedad;
        }
        public static bool Guardar_Medicamento(Medicamento Medicamento)
        {
            Medicamento.Key = Return_Key();
            if (Verificar_IdCliente(Medicamento.IdEfermedad))
            {
                StreamWriter writer;
                string RutaArchuivo = "Medicamentos.txt";
                if (File.Exists(RutaArchuivo))
                {
                    writer = File.AppendText(RutaArchuivo);
                }
                else
                {
                    List<Medicamento> Usuari;
                    writer = new StreamWriter(RutaArchuivo);
                }
                string resultado = Medicamento.Return_Info();
                writer.WriteLine(resultado);
                writer.Close();
                return true;
            }
            else { return false; }
        }
        public static void EliminarArchivo(List<Medicamento> Medicamento)
        {
            StreamWriter writer = new StreamWriter("Medicamentos.txt");
            int Keys = 1;
            foreach (Medicamento medicamento in Medicamento)
            {
                medicamento.Key = Keys;
                string resultado = medicamento.Return_Info();
                writer.WriteLine(resultado);
                Keys++;
            }
            writer.Close();
        }
        public string Return_Info()
        {
            string Resultado = Key + ";" + IdEfermedad + ";" + NMedicamento + ";" + KeyEnfermedad;
            return Resultado;
        }
        public static List<Medicamento> Cargar_Medicamento()
        {
            StreamReader reader = new StreamReader("Medicamentos.txt");
            List<Medicamento> Medicamento = new List<Medicamento>();
            Medicamento Medicine;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] valores = line.Split(';');
                Medicine = new Medicamento(Convert.ToInt16(valores[0]), Convert.ToInt16(valores[1]), valores[2], Convert.ToInt16(valores[3]));
                Medicamento.Add(Medicine);
            }
            reader.Close();
            return Medicamento;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Enfermedad> Enfermedades = Enfermedad.Cargar_Enfermedad();
            foreach (Enfermedad Enfermedad in Enfermedades)
            {
                if (IdCliente == Enfermedad.IdMascota)
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
                StreamReader reader = new StreamReader("Medicamentos.txt");
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    List<Medicamento> Medicamentos = Cargar_Medicamento();
                    Medicamento Medicamento = Medicamentos[Medicamentos.Count - 1];
                    int key = Medicamento.Key + 1;
                    reader.Close();
                    return key;
                }
                else { reader.Close(); return 1; }
            }
            else { return 1; }
        }
        public static bool Existencia_Archivo()
        {
            return File.Exists("Medicamentos.txt");
        }
    }
}
