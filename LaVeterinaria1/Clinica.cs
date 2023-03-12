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
        private int Key, IdMascota;
        private string NEfermedad;

        public Enfermedad()
        {
            this.Key = 0;
            this.IdMascota = 0;
            this.NEfermedad = "";
        }
        public Enfermedad(int Key, int IdMascota, string NEfermedad)
        {
            this.Key = Key;
            this.IdMascota = IdMascota;
            this.NEfermedad = NEfermedad;
        }
        public static bool Guardar_Enfermedad(Enfermedad Enfermedad)
        {
            Enfermedad.setKey(Return_Key());
            if (Verificar_IdCliente(Enfermedad.getIdMascota()) != true)
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
        public string Return_Info()
        {
            string Resultado = Key + ";" + IdMascota + ";" + NEfermedad;
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
                Disease = new Enfermedad(Convert.ToInt16(valores[0]), Convert.ToInt16(valores[1]), valores[2]);
                Enfermedad.Add(Disease);
            }
            reader.Close();
            return Enfermedad;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Enfermedad> Enfermedad = Cargar_Enfermedad();
            foreach (Enfermedad Disease in Enfermedad)
            {
                int ID = Disease.getIdMascota();
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
                    int key = Enfermedad.getKey() + 1;
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
            return File.Exists("Enfermedades.txt");
        }
        public int getKey()
        {
            return this.Key;
        }
        public int setKey(int Key)
        {
            return this.Key = Key;
        }
        public int getIdMascota()
        {
            return this.IdMascota;
        }
        public int setIdMascota(int IdMascota)
        {
            return this.IdMascota = IdMascota;
        }
    }
    public class Medicamento
    {
        private int Key, IdEfermedad;
        private string NMedicamento;
        public Medicamento()
        {
            this.Key = 0;
            this.IdEfermedad = 0;
            this.NMedicamento = "";
        }
        public Medicamento(int Key, int IdEfermedad, string NMedicamento)
        {
            this.Key = Key;
            this.IdEfermedad = IdEfermedad;
            this.NMedicamento = NMedicamento;
        }
        public static bool Guardar_Medicamento(Medicamento Medicamento)
        {
            Medicamento.setKey(Return_Key());
            if (Verificar_IdCliente(Medicamento.getIdEfermedad()) != true)
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
        public string Return_Info()
        {
            string Resultado = Key + ";" + IdEfermedad + ";" + NMedicamento;
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
                Medicine = new Medicamento(Convert.ToInt16(valores[0]), Convert.ToInt16(valores[1]), valores[2]);
                Medicamento.Add(Medicine);
            }
            reader.Close();
            return Medicamento;
        }
        public static bool Verificar_IdCliente(int IdCliente)
        {
            List<Medicamento> Medicamento = Cargar_Medicamento();
            foreach (Medicamento Medicine in Medicamento)
            {
                int ID = Medicine.getIdEfermedad();
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
                StreamReader reader = new StreamReader("Medicamentos.txt");
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    List<Medicamento> Medicamentos = Cargar_Medicamento();
                    Medicamento Medicamento = Medicamentos[Medicamentos.Count - 1];
                    int key = Medicamento.getKey() + 1;
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
            return File.Exists("Medicamentos.txt");
        }
        public int getKey()
        {
            return this.Key;
        }
        public int setKey(int Key)
        {
            return this.Key = Key;
        }
        public int getIdEfermedad()
        {
            return this.IdEfermedad;
        }
        public int setIdEfermedad(int IdEfermedad)
        {
            return this.IdEfermedad = IdEfermedad;
        }

    }
}
