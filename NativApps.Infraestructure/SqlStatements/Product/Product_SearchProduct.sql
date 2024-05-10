DECLARE @NotRemove BIT = 0;

SELECT [Id]
      ,[Name]
      ,[Category]
      ,[Detail]
      ,[Price]
      ,[InitialQuantity]
      ,[AvailableQuantity]
      ,[CreatedBy]
      ,[CreatedOn]
      ,[ModifiedBy]
      ,[ModifiedOn]
  FROM [Products]
  WHERE ([Name] LIKE '%' + @Search + '%' AND @Search IS NOT NULL)
  AND (@PriceMin IS NULL OR [Price] >= @PriceMin) AND (@PriceMax IS NULL OR [Price] <= @PriceMax)
  AND [Remove] = @NotRemove
  ORDER BY
	[{0}] {1}
    OFFSET 
	    ((@PageIndex - 1) * @PageSize) ROWS
    FETCH NEXT
	    @PageSize ROWS ONLY;