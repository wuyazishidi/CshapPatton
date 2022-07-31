using System;
using System.Data;
using System.Data.OleDb;

namespace TemplateMethodPattern {
    abstract class DataObject {
        abstract public void Connect();
        abstract public void Select();
        abstract public void Process();
        abstract public void Disconnect();

        public void Run() {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    class CustomerDataObject : DataObject {
        private string connectionString = "provider=Microsoft.JET.OLEDB.4.0;" + "data source=c:\\nwind.mdb";
        private string commandString;
        private DataSet dataSet;
        public override void Connect() {

        }

        public override void Disconnect() {
        }

        public override void Process() {
            DataTable dataTable = dataSet.Tables["Customers"];
            foreach (DataRow dataRow in dataTable.Rows) {
                Console.WriteLine(dataRow["CompanyName"]);
            }
        }

        public override void Select() {
            commandString = "select CompanyName from Customers";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandString,connectionString);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet,"Customers");
        }
    }
}
