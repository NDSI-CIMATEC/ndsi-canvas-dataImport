using NDSI_CanvasAPIConsumer.Controller;
using NDSI_CanvasAPIConsumer.Model.RAW;
using NDSI_CanvasAPIConsumer.Template.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSI_CanvasAPIConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Supporting Variables
            int runtime = 0;
            
            //Instantiating 
            Importer_API_Controller importControl = new Importer_API_Controller();

            while (runtime != 1)
            {
                using ()
                {
                    const string query = @"select * from UserLogin";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine(reader.ToString());
                    connection.Close();
                }

                //Logic to finalize the loop if so desired
                try
                {
                    runtime = int.Parse(Console.ReadLine());
                }
                catch { }
            }

            return;
        }
    }
}
