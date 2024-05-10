DECLARE @Remove BIT = 1;

UPDATE [Products]
SET  
     [Remove] = @Remove
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
