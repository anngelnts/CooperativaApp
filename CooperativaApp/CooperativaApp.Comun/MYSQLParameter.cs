using MySql.Data.MySqlClient;

namespace CooperativaApp.Comun
{
    public class MYSQLParameter
    {
        public string Name;
        public object Value;
        public MySqlDbType Type;
        public MYSQLParameter(string name, object value, MySqlDbType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
    }
}
