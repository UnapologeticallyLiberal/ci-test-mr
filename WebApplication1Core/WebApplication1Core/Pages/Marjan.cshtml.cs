using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;


namespace WebApplication1Core.Pages
{
    public class MarjanModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Nachricht von Sam 123!";
        }


        // test

        //// der geht mit Parameter
        //private void createPostgreConn2()
        //{

        //    //CREATE OR REPLACE FUNCTION getAdressTest_Net1()
        //    //  RETURNS TABLE(id uuid, name varchar, surname varchar) AS $$
        //    //BEGIN
        //    // RETURN QUERY
        //    // SELECT app_adress.id, app_adress.name, app_adress.surname FROM public.app_adress;
        //    //END; $$ 

        //    //LANGUAGE 'plpgsql';


        //    //Select getAdressTest_Net1();

        //    // PostgreSQL-style connection string
        //    string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
        //            "deweas96.de.intra.sto.com", "5432", "KaffeeKassenAppUser", "123456", "kaffeekassenapp");
        //    // Making connection with Npgsql provider
        //    NpgsqlConnection conn = new NpgsqlConnection(connstring);

        //    conn.Open();
        //    NpgsqlTransaction tran = conn.BeginTransaction();

        //    //NpgsqlCommand command = new NpgsqlCommand("getAdressTest_Net1", conn);
        //    NpgsqlCommand command = new NpgsqlCommand("getAdressTest_Net", conn);
        //    command.CommandType = CommandType.StoredProcedure;
        //    //command.Parameters.AddWithValue(":id", new Guid());
        //    //command.Parameters.AddWithValue(":name", "Hallo1");
        //    //command.Parameters.AddWithValue(":surname", "Hallo2");
        //    //command.Parameters.AddWithValue(":i", 5);
        //    command.ExecuteNonQuery();
        //    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);

        //    PostgresDataSet psDataset = new PostgresDataSet();
        //    da.Fill(psDataset, "app_adress");

        //    NpgsqlDataReader dr = command.ExecuteReader();
        //    //while (dr.Read())
        //    //{
        //    //    // do what you want with data, convert this to json or...
        //    //    Console.WriteLine(dr[0]);
        //    //}
        //    dr.Close();

        //    tran.Commit();
        //    conn.Close();
        //}

    }
}