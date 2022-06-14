SELECT Id
	 , [Message]
	 , RepositoryId
	 , ContributorId
  FROM [Commits]
 ORDER
    BY id,[Message], RepositoryId, ContributorId
