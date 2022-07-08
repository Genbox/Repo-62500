#nullable enable
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NullAnonTypePoC.Code;

internal class DataTypeInfoManager
{
    private async Task<IList<DataTypeInfo>> GetTypesByIdsAsync()
    {
        List<DataType> dataTypes = new List<DataType>();

        var dbTypes = dataTypes
                      .Select(s => new
                      {
                          s.BaseTypes,
                          s.DataFields
                      });

        List<DataTypeInfo> res = new List<DataTypeInfo>();

        foreach (var dbType in dbTypes)
        {
            DataTypeInfo typeInfo = new DataTypeInfo();

            foreach (DataField field in dbType.DataFields)
            {
                typeInfo.Fields.Add(field.Name, new DataTypeFieldInfo
                {
                    Description = field.Description,
                });
            }

            res.Add(typeInfo);
        }

        return res;
    }
}