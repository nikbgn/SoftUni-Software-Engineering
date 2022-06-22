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





    }
}
