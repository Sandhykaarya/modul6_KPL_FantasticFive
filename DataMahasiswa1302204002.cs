using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_FantasticFive_47
{
    internal class DataMahasiswa1302204002
    {
        public class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string courses { get; set; }
        }

        public void ReadJSON()
        {
            string JsonFile = "jurnal6_1_1302204002.json";

            string data = File.ReadAllText(JsonFile);

            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(data);

            Console.WriteLine($"Nama depan {dataMahasiswa.firstName} nama belakang {dataMahasiswa.lastName} gender {dataMahasiswa.gender} beralamat di {dataMahasiswa.address} mengambil matkul {dataMahasiswa.courses}");
        }
    }

}
