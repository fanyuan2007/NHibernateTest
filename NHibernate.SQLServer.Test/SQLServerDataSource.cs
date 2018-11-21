using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.SQLServer.Test
{
    public class SQLServerDataSource
    {
        private string _dataSourceFileName;
        private string _serverName;
        private string _databaseName;
        private string _username;
        private string _password;
        public string DataSourceFileName
        {
            get { return _dataSourceFileName; }
            set { _dataSourceFileName = value; }
        }

        public string ServerName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }

        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

        public static SQLServerDataSource createDefaultSqlDatasource()
        {
            var ds = new SQLServerDataSource
            {
                DataSourceFileName = "myTest",
                ServerName = "AVANNOBZHE01\\SQLSERVER2012HAN",
                DatabaseName = "TestDataBase",
                UserName = "LGS-NET\\ZHE",
                PassWord = ""
            };

            return ds;
        }
    }
}
