namespace NativApps.Core.Extensions
{
	public static class ObjectExtension
	{
		public static void ValidateValue(this object @object, string fieldName)
		{
			if (@object == null || (@object is string str && string.IsNullOrWhiteSpace(str)))
			{
				throw new ApplicationException($"El campo '{fieldName}' es requerido, no puede estar vacio");
			}
		}

		public static void ValidateParameter(this object @object, string fieldName)
		{
			if (@object == null)
			{
				throw new ApplicationException($"Ocurrio un error al procesar la peticion, el parametro '{fieldName}' puede estar vacio pero no puede ser Null");
			}
		}
	}
}
