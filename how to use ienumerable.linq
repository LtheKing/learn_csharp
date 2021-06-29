<Query Kind="Program" />

void Main()
{
	List<Teman> tm = new List<Teman>() {
		new Teman() {ID = 1, Alamat = "Bandung", Nama = "Tomo"},
		new Teman() {ID = 2, Alamat = "Jakarga", Nama = "Ashura"},
		new Teman() {ID = 3, Alamat = "England", Nama = "Bono"}
	};
	
	IEnumerable<Teman> query = from teman in tm
								select teman;

	query.Dump();

	//int

	List<int> listAngka = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

	IEnumerable<int> queryInt = from obj in listAngka
								where obj > 3
								select obj;

	//	Console.WriteLine(query);
	queryInt.Dump();

}

class Teman
{
	public int ID { get; set; }
	public string Nama { get; set; }
	public string Alamat { get; set; }
}

// Define other methods and classes here
