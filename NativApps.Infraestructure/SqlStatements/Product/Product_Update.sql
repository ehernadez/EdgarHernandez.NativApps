UPDATE [Products]
SET  
     [Name] = @Name
    ,[Category] = @Category
    ,[Detail] = @Detail
    ,[Price] = @Price
    ,[InitialQuantity] = @InitialQuantity
    ,[AvailableQuantity] = @AvailableQuantity
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
