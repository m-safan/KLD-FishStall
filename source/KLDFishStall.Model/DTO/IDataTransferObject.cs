using System;
using System.Collections.Generic;
using System.Text;

namespace KLDFishStall.Model.DTO
{
    public interface IDataTransferObject<T> where T : class
    {
        T Map();
    }
}
