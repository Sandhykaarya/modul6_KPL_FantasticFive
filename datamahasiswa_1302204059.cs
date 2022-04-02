using System.Text.Json;

public class DataMahasiswa_1302204059 //  Muhammad Abieb Basnuril 1302204059
{
    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string courses { get; set; }
    }

    public void ReadJSON() // metode parsing untuk deserialisasi
    {
        string file = "jurnal6_1_1302204059.json";

        string dataStr = File.ReadAllText(file);

        DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);

        Console.WriteLine($"Nama depan {dataMahasiswa.firstName} nama belakang {dataMahasiswa.lastName} gender {dataMahasiswa.gender} beralamat di {dataMahasiswa.address} mengambil matkul {dataMahasiswa.courses}");
    }
}
//  Muhammad Abieb Basnuril 1302204059