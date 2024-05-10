DECLARE @NotRemove BIT = 0;

SELECT COUNT(*)
  FROM [Products]
  WHERE ([Name] LIKE '%' + @Search + '%' AND @Search IS NOT NULL)
  AND (@PriceMin IS NULL OR [Price] >= @PriceMin) AND (@PriceMax IS NULL OR [Price] <= @PriceMax)
  AND [Remove] = @NotRemove