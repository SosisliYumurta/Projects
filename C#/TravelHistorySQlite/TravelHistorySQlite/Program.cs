using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHistorySQlite
{
    class Program
    {
        static SQLiteConnection sqlite_con;
        static void Main(string[] args)
        {
            int item = 0;
            sqlite_con = CreateConnection();
            Console.WriteLine("1. Display all data");
            Console.WriteLine("2. Travels to given places");
            Console.WriteLine("3. Insert data");
            Console.WriteLine("4. Delete data");
            Console.WriteLine("0. Exit data");
            while (true)
            {

               
                Console.Write
                    ("Choose a number [1,4]: ");
                item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    case 1:
                        Console.WriteLine("Display data.");
                        ReadData(sqlite_con);
                        
                        break;
                    case 2:
                        Console.WriteLine("Travels to given places");
                        Console.WriteLine("Write the place that you looking for");
                        string place = Console.ReadLine();
                        ReadDataPlaces(sqlite_con, place);
                        break;
                    case 3:
                        Console.WriteLine("Insert data");
                        sqlite_con = CreateConnection();
                        CreateTable(sqlite_con);
                        InsertData(sqlite_con);
                        break;
                    case 4:
                        Console.WriteLine("Delete data");
                        ReadData(sqlite_con);
                        Console.Write("which country would you like to delete. Please type the name of the country: ");
                        string placeName = Console.ReadLine();
                        DeletePlaces(sqlite_con, placeName);
                        break;
                    case 5:
                        Console.WriteLine("edit data");
                        break;
                    case 0:
                        Console.WriteLine("are you sure you want to exit? [y/Y,n/N]");
                        char finalSelection = char.Parse(Console.ReadLine());
                        if (finalSelection == 'y' || finalSelection == 'Y')
                        {
                            System.Environment.Exit(1);
                        }
                        break;
                    default:
                        Console.WriteLine("Please choose a number [0,4]");
                        break;


                }
            }

        }
       
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database no found");
            }
            return sqlite_conn;
        }
       public static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand cmd;
            string strCosts = "CREATE TABLE if not exists Costs(id INTEGER PRIMARY KEY AUTOINCREMENT, cost double, place_id INT)";
            string strPlaces = "CREATE TABLE if not exists places(id INTEGER PRIMARY KEY AUTOINCREMENT, place VARCHAR(20), date VARCHR(20))";
            cmd = conn.CreateCommand();

            cmd.CommandText = strCosts;
            cmd.ExecuteNonQuery();

            cmd.CommandText = strPlaces;
            cmd.ExecuteNonQuery();
        }
        static void EditData(SQLiteConnection con, string place)
        {

        }
        static void InsertData(SQLiteConnection conn)
        {
            Console.Write("Enter the place: ");
            string place = Console.ReadLine();
            Console.Write("Enter the date: ");
            string date1 = Console.ReadLine();
            Console.Write("Enter the cost: ");
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            double cost = Convert.ToDouble(Console.ReadLine(), provider);
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO places(place, date) VALUES('" + place + "','" + date1 + "' ); ";
            //Console.WriteLine(sqlite_cmd.CommandText);
            sqlite_cmd.ExecuteNonQuery();
            //------------------------
            SQLiteDataReader sqlite_datareader;
            //SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM places ";
            int place_id = 0;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                place_id = (int)sqlite_datareader.GetInt64(0);
            }
            //------------------------
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Costs(cost, place_id) VALUES(" + cost + "," + place_id + " ); ";
            Console.WriteLine(sqlite_cmd.CommandText);
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();
        }
        static void ReadData(SQLiteConnection conn)
        {
            try
            {
                sqlite_con.Open();
            }
            catch (Exception e)
            {
                
            }
            double average = 0;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT places.id, places.place, places.date, Costs.cost FROM places, Costs WHERE places.id = Costs.place_id";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int col0 = (int)sqlite_datareader.GetInt64(0);
                string col1 = sqlite_datareader.GetString(1);
                string col2 = sqlite_datareader.GetString(2);
                double col3 = sqlite_datareader.GetFloat(3);
                Console.WriteLine("{0} {1} {2} {3}", col0, col1, col2,col3);
                average += col3;

            }
            Console.WriteLine("average cost: {0}",average/4);
            conn.Close();
        }
        static void ReadDataPlaces(SQLiteConnection conn, string place)
        {
            try
            {
                sqlite_con.Open();
            }
            catch (Exception e)
            {
               
            }
            
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT places.place, places.date, Costs.cost FROM Places, Costs WHERE places.id = Costs.place_id and " + "'" + place + "' = places.place;";
            //Console.WriteLine(sqlite_cmd.CommandText);
            
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //int col0 = (int)sqlite_datareader.GetInt64(0);
                string col1 = sqlite_datareader.GetString(0);
                string col2 = sqlite_datareader.GetString(1);
                double col3 = sqlite_datareader.GetFloat(2);
                //string col3 = sqlite_datareader.GetString(2);
                Console.WriteLine("{0} {1} {2} ", col1, col2, col3);
            }
            conn.Close();
        }
        static void DeletePlaces(SQLiteConnection conn, string place)
        {
            try
            {
                sqlite_con.Open();
            }
            catch (Exception e)
            {
                
            }
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            SQLiteCommand sqlite_cmd_2;
            //sqlite_cmd_2 = conn.CreateCommand();
            sqlite_cmd.CommandText = "Delete FROM places WHERE places.place = '" + place + "' ;";
            //sqlite_cmd_2.CommandText = "Delete FROM Costs WHERE costs.place_id = " + place + " ;";
            //Console.WriteLine(sqlite_cmd.CommandText);
            sqlite_cmd.ExecuteNonQuery();
            //sqlite_cmd_2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
