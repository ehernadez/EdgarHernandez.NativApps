using NativApps.Core.Extensions;
using NativApps.Core.Models.DTOs;
using NativApps.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativApps.Core.Helpers
{
	public static class MapProductHelper
	{
		public static ProductResponseDTO MapToProductResponseDTO(ProductModel product)
		{
			return new ProductResponseDTO
			{
				Id = product.Id,
				Name = product.Name,
				Category = product.Category,
				Price = product.Price,
				InitialQuantity = product.InitialQuantity,
				CreatedOn = product.CreatedOn
			};
		}

		public static ProductModel MapToProductmodel(ProductDto product)
		{
			product.Name.ValidateValue(nameof(product.Name));
			product.Price.ValidateValue(nameof(product.Price));
			product.InitialQuantity.ValidateValue(nameof(product.InitialQuantity));

			return new ProductModel
			{
				Name = product.Name,
				Category = product.Category,
				Price = product.Price,
				InitialQuantity = product.InitialQuantity
			};
		}
	}
}
