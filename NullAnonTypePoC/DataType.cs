using System.Collections.Generic;

namespace NullAnonTypePoC;

public class DataType
{
    public ICollection<DataField> DataFields { get; set; }
    public string? BaseTypes { get; set; }
}