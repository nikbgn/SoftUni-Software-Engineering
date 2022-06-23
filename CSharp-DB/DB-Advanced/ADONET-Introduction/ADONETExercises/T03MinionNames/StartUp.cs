namespace T03MinionNames
{
    using System;
    using System.Data.SqlClient;
    using T01InitialSetup;

    public class StartUp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter ID: ");
            int ID = int.Parse(Console.ReadLine());
           using SqlConnection sqlConnection =
                new SqlConnection(Config.CONNECTION_STRING);

            sqlConnection.Open();

            PrintVillainById(sqlConnection,ID);
            PrintMinionsInfoFromVillianById(sqlConnection,ID);



            sqlConnection.Close();


        }


        private static void PrintVillainById(SqlConnection sqlConnection, int ID)
        {
            SqlCommand sqlCommand = new SqlCommand(Queries.VILLAIN_WITH_ID, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", ID);
            object result = sqlCommand.ExecuteScalar();
            if (result == null)
            {
                Console.WriteLine($"No villain with the ID {ID} exists in the database.");
                sqlConnection.Close();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine($"Villain: {(string)result}");
            }
        }

        private static void PrintMinionsInfoFromVillianById(SqlConnection sqlConnection, int ID)
        {
            SqlCommand sqlCommand = new SqlCommand(Queries.MINIONS_OWNED_BY_VILLAIN_ID, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", ID);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            using (sqlDataReader)
            {
                if (sqlDataReader.HasRows == false)
                {
                    Console.WriteLine("(no minions)");
                    return;
                }
                while (sqlDataReader.Read())
                {
                    Int64 rowNum = sqlDataReader.GetInt64(0);
                    string minionName = sqlDataReader.GetString(1);
                    int minionAge = sqlDataReader.GetInt32(2);
                    Console.WriteLine($"{rowNum}. {minionName} {minionAge}");
                }
            }
        }

    }
}
