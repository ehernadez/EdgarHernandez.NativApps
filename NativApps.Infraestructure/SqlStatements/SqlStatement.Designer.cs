﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NativApps.Infraestructure.SqlStatements {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlStatement {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlStatement() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NativApps.Infraestructure.SqlStatements.SqlStatement", typeof(SqlStatement).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DECLARE @NotRemove BIT = 0;
        ///
        ///SELECT COUNT(*)
        ///  FROM [Products]
        ///  WHERE [Remove] = @NotRemove.
        /// </summary>
        internal static string Product_CountTotalRecords {
            get {
                return ResourceManager.GetString("Product_CountTotalRecords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO [Products]
        ///    (
        ///      [Name]
        ///     ,[Category]
        ///     ,[Detail]
        ///     ,[Price]
        ///     ,[InitialQuantity]
        ///     ,[AvailableQuantity]
        ///     ,[CreatedBy]
        ///     ,[CreatedOn]
        ///    )
        ///VALUES
        ///    (
        ///      @Name
        ///     ,@Category
        ///     ,@Detail
        ///     ,@Price
        ///     ,@InitialQuantity
        ///     ,@AvailableQuantity
        ///     ,@CreatedBy
        ///     ,@CreatedOn
        ///	); .
        /// </summary>
        internal static string Product_Create {
            get {
                return ResourceManager.GetString("Product_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DECLARE @Remove BIT = 1;
        ///
        ///UPDATE [Products]
        ///SET  
        ///     [Remove] = @Remove
        ///    ,[ModifiedBy] = @ModifiedBy
        ///    ,[ModifiedOn] = @ModifiedOn
        ///WHERE
        ///    [Id] = @Id;
        ///.
        /// </summary>
        internal static string Product_Delete {
            get {
                return ResourceManager.GetString("Product_Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DECLARE @NotRemove BIT = 0;
        ///
        ///SELECT [Id]
        ///      ,[Name]
        ///      ,[Category]
        ///      ,[Detail]
        ///      ,[Price]
        ///      ,[InitialQuantity]
        ///      ,[AvailableQuantity]
        ///      ,[CreatedBy]
        ///      ,[CreatedOn]
        ///      ,[ModifiedBy]
        ///      ,[ModifiedOn]
        ///  FROM [Products]
        ///  WHERE [Remove] = @NotRemove
        ///  ORDER BY
        ///	[{0}] {1}
        ///    OFFSET 
        ///	    ((@PageIndex - 1) * @PageSize) ROWS
        ///    FETCH NEXT
        ///	    @PageSize ROWS ONLY;.
        /// </summary>
        internal static string Product_GetAll {
            get {
                return ResourceManager.GetString("Product_GetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DECLARE @NotRemove BIT = 0;
        ///
        ///SELECT COUNT(*)
        ///  FROM [Products]
        ///  WHERE ([Name] LIKE &apos;%&apos; + @Search + &apos;%&apos; AND @Search IS NOT NULL)
        ///  AND (@PriceMin IS NULL OR [Price] &gt;= @PriceMin) AND (@PriceMax IS NULL OR [Price] &lt;= @PriceMax)
        ///  AND [Remove] = @NotRemove.
        /// </summary>
        internal static string Product_Search_CountTotalRecords {
            get {
                return ResourceManager.GetString("Product_Search_CountTotalRecords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DECLARE @NotRemove BIT = 0;
        ///
        ///SELECT [Id]
        ///      ,[Name]
        ///      ,[Category]
        ///      ,[Detail]
        ///      ,[Price]
        ///      ,[InitialQuantity]
        ///      ,[AvailableQuantity]
        ///      ,[CreatedBy]
        ///      ,[CreatedOn]
        ///      ,[ModifiedBy]
        ///      ,[ModifiedOn]
        ///  FROM [Products]
        ///  WHERE ([Name] LIKE &apos;%&apos; + @Search + &apos;%&apos; AND @Search IS NOT NULL)
        ///  AND (@PriceMin IS NULL OR [Price] &gt;= @PriceMin) AND (@PriceMax IS NULL OR [Price] &lt;= @PriceMax)
        ///  AND [Remove] = @NotRemove
        ///  ORDER BY
        ///	[{0}] {1}
        ///    OFFSET 
        ///	    ((@PageIn [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string Product_SearchProduct {
            get {
                return ResourceManager.GetString("Product_SearchProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE [Products]
        ///SET  
        ///     [Name] = @Name
        ///    ,[Category] = @Category
        ///    ,[Detail] = @Detail
        ///    ,[Price] = @Price
        ///    ,[InitialQuantity] = @InitialQuantity
        ///    ,[AvailableQuantity] = @AvailableQuantity
        ///    ,[ModifiedBy] = @ModifiedBy
        ///    ,[ModifiedOn] = @ModifiedOn
        ///WHERE
        ///    [Id] = @Id;
        ///.
        /// </summary>
        internal static string Product_Update {
            get {
                return ResourceManager.GetString("Product_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT [Id]
        ///      ,[Role]
        ///  FROM [Users]
        ///WHERE [UserName] = @UserName 
        ///And [Password] = @Password;.
        /// </summary>
        internal static string SignIn {
            get {
                return ResourceManager.GetString("SignIn", resourceCulture);
            }
        }
    }
}
