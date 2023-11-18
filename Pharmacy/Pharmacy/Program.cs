using System;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding=System.Text.Encoding.UTF8;
            string connection = "Server=DESKTOP-QOKRM5K;Database=Pharmacy;Integrated Security=True;";
            using SqlConnection conSql= new SqlConnection(connection);
            if(conSql.State!=ConnectionState.Open)
            {
                conSql.Open();  
            }

            SqlCommand cmd=conSql.CreateCommand();
            #region CreateMedicineProcedure
            //string use_exec = "exec CreateMedicine @MedicineName,@MedicinePrice,@MedicineProDate,@MedicineExpDate,@MedicinePurpose_Id,@MedicineType_Id";
            //cmd.CommandText=use_exec;
            //cmd.Parameters.AddWithValue("@MedicineName", "Medicine100");
            //cmd.Parameters.AddWithValue("@MedicinePrice", 22.5);
            //cmd.Parameters.AddWithValue("@MedicineProDate", 2023 - 12 - 12);
            //cmd.Parameters.AddWithValue("@MedicineExpDate", 2023 - 10 - 10);
            //cmd.Parameters.AddWithValue("@MedicinePurpose_Id", 3);
            //cmd.Parameters.AddWithValue("@MedicineType_Id", 1);

            //int rows=cmd.ExecuteNonQuery();
            //if(rows > 0)
            //{
            //    Console.WriteLine("Derman elave edildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Xeta:Elave edilmedi!");
            //}
            #endregion

            #region UpdateMedicinePriceProcedure
            //string medicine_detail_update_price = "exec Medicine_Detail_Update_Price @medicine_name,@medicine_new_price";
            //cmd.CommandText=medicine_detail_update_price;
            //cmd.Parameters.AddWithValue("@medicine_name", "Medicine22");
            //cmd.Parameters.AddWithValue("medicine_new_price", "22");
            //int update_rows=cmd.ExecuteNonQuery();
            //if(update_rows > 0 )
            //{
            //    Console.WriteLine("Update edildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Xeta:Update edile bilmedi!");
            //}
            #endregion

            #region UpdateProdateProcedure
            //string update_prodate = "exec Medicine_Details_Update_Proddate @Medicine_Name,@Medicine_New_Proddate";
            //cmd.CommandText = update_prodate;
            //cmd.Parameters.AddWithValue("Medicine_Name", "Medicine2");
            //cmd.Parameters.AddWithValue("@Medicine_New_Proddate", "09-10-2023");
            //int rows_prodate = cmd.ExecuteNonQuery();
            //if (rows_prodate > 0)
            //{
            //    Console.WriteLine("Update edildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Xeta:Update edilmedi!");
            //}

            #endregion

            #region UpdateExpProcedure
            //string update_expdate = "exec Medicine_Details_ExpDate @MedicineName,@Medicine_new_ExpDate";
            //cmd.CommandText = update_expdate;
            //cmd.Parameters.AddWithValue("@MedicineName", "Medicine22");
            //cmd.Parameters.AddWithValue("@Medicine_new_ExpDate", "11-11-2024");
            //int expdate_rows = cmd.ExecuteNonQuery();
            //if (expdate_rows > 0)
            //{
            //    Console.WriteLine("Update edildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Xeta:Update edilmedi!");
            //}
            #endregion

            #region SearchMedicineByName
            //cmd.Connection = conSql;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SearchMedicineByName";
            //cmd.Parameters.AddWithValue("@medname", "Med");
            //using(SqlDataReader reader=cmd.ExecuteReader())
            //{
            //    Console.WriteLine("MedicineName\tMedicinePrice");
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"{reader["MedicineName"]}\t || \t {reader["MedicinePrice"]}");
            //    }
            //}

            #endregion

            if (conSql.State!=ConnectionState.Closed)
            { conSql.Close(); }
        }
    }
}
