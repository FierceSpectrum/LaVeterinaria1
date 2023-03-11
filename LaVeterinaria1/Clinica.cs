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
        private int IdMascota;
        private string NEfermedad;

        public Enfermedad()
        {
            this.IdMascota = 0;
            this.NEfermedad = "";
        }
        public Enfermedad(int IdMascota, string NEfermedad)
        {
            this.IdMascota = IdMascota;
            this.NEfermedad = NEfermedad;
        }
        public static void Guardar_Enfermedad(Enfermedad Enfermedad)
        {
            StreamWriter writer;
            bool var = Verificar_Archivo();
            if (var == true)
            {
                writer = File.AppendText("Enfermedads.txt");
            }
            else
            {
                writer = new StreamWriter("Enfermedads.txt");
            }
            string enfermedad = Enfermedad.Return_Info();
            writer.WriteLine(enfermedad);
            writer.Close();
        }
        public string Return_Info()
        {
            string Resultado = IdMascota + ";" + NEfermedad;
            return Resultado;
        }
        public static List<Enfermedad> Cargar_Enfermedad()
        {

            StreamReader reader = new StreamReader("Enfermedads.txt");
            List <Enfermedad> Enfermedad = new List<Enfermedad>();
            Enfermedad Disease;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] valores = line.Split(';');
                Disease = new Enfermedad(Convert.ToInt16(valores[0]), valores[1]);
                Enfermedad.Add(Disease);
            }
            reader.Close();
            return Enfermedad;
        }
        public bool Verificar_IdCliente(int IdCliente)
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
        public static bool Verificar_Archivo()
        {
            List<Enfermedad> Enfermedad;
            try
            {
                Enfermedad = Cargar_Enfermedad();
                return true;
            }
            catch
            {
                return false;
            }
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
        private int IdEfermedad;
        private string NMedicamento;
        public Medicamento()
        {
            this.IdEfermedad = 0;
            this.NMedicamento = "";
        }
        public Medicamento(int IdEfermedad, string NMedicamento)
        {
            this.IdEfermedad = IdEfermedad;
            this.NMedicamento = NMedicamento;
        }
        public static void Guardar_Medicamento(Medicamento Medicamento)
        {
            StreamWriter writer = new StreamWriter("Medicamentos.txt");
                string enfermedad = Medicamento.Return_Info();
                writer.WriteLine(enfermedad);
            writer.Close();
        }
        public string Return_Info()
        {
            string Resultado = IdEfermedad + ";" + NMedicamento;
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
                Medicine = new Medicamento(Convert.ToInt16(valores[0]), valores[1]);
                Medicamento.Add(Medicine);
            }
            reader.Close();
            return Medicamento;
        }
        public bool Verificar_IdCliente(int IdCliente)
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
