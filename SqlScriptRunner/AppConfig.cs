using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlScriptRunner
{
    [Serializable]
    public class AppConfig
    {
        public string ConnectionString { get; set; }
        public string ScriptFolder { get; set; }
    }
}
