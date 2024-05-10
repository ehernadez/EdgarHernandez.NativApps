DECLARE @NotRemove BIT = 0;

SELECT COUNT(*)
  FROM [Products]
  WHERE [Remove] = @NotRemove