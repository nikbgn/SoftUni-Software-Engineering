namespace T02VillainNames
{
    using System;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using T01InitialSetup;

    public class StartUp
    {
        static async Task Main(string[] args)
        {
            await using SqlConnection sqlConnection =
                new SqlConnection(Config.CONNECTION_STRING);

            await sqlConnection.OpenAsync();

            await PrintVillainsWithMoreThanThreeMinions(sqlConnection);

            await sqlConnection.CloseAsync();
        }

        private static async Task PrintVillainsWithMoreThanThreeMinions(SqlConnection sqlConnection)
        {
            SqlCommand command = new SqlCommand(Queries.VILLAINS_WITH_MORE_THAN_THREE_MINIONS,sqlConnection);
            SqlDataReader sqlDataReader = await command.ExecuteReaderAsync();
            await using (sqlDataReader)
            {
                while (await sqlDataReader.ReadAsync())
                {
                    string villainName = sqlDataReader.GetString(0);
                    int minionsCount = sqlDataReader.GetInt32(1);
                    Console.WriteLine($"{villainName} - {minionsCount}");
                }
            }

        }
    }
}
