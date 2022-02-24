using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Archi.Library.Core
{
    public class SwaggerExcludeFilter : Swashbuckle.AspNetCore.SwaggerGen.ISchemaFilter
    {  
        /*public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            if (schema?.properties == null || type == null)
                return;

            var excludedProperties = type.GetProperties()
                                         .Where(t =>
                                                t.GetCustomAttribute<SwaggerExcludeAttribute>()
                                                != null);

            foreach (var excludedProperty in excludedProperties)
            {
                if (schema.properties.ContainsKey(excludedProperty.Name))
                    schema.properties.Remove(excludedProperty.Name);
            }
        }*/

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
           
        }
    }
}
