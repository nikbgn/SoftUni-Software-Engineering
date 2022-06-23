namespace T01InitialSetup
{
    public static class Queries
    {

        //Task 02 Query
        public const string VILLAINS_WITH_MORE_THAN_THREE_MINIONS = @"  SELECT v.[Name], COUNT(mv.VillainId) AS MinionsCount  
                                                                          FROM Villains AS v 
                                                                          JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                                                                      GROUP BY v.Id, v.[Name] 
                                                                        HAVING COUNT(mv.VillainId) > 3 
                                                                      ORDER BY COUNT(mv.VillainId)";

        //Task 03 Queries

        public const string VILLAIN_WITH_ID = @"SELECT Name FROM Villains WHERE Id = @Id";
        public const string MINIONS_OWNED_BY_VILLAIN_ID = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                                                     m.Name, 
                                                                     m.Age
                                                              FROM MinionsVillains AS mv
                                                              JOIN Minions As m ON mv.MinionId = m.Id
                                                             WHERE mv.VillainId = @Id
                                                          ORDER BY m.Name";



    }
}
