using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Data.Connection
{
    public interface DataConnectionService
    {
        SQLiteConnection Connection { get; }
    }
}
