SELECT [Id]
      ,[Role]
  FROM [Users]
WHERE [UserName] = @UserName 
And [Password] = @Password;