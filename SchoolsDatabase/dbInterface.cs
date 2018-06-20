using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/*Emer Campbell 2018*/

namespace SchoolsDatabase
{
    
    class dbInterface
    {
        /*declare variables to hold SQL statement for action, database location.  Declare datadapter to open requested table once connection established. Declare
          dataset to hold table values*/
        private string strAction;
        private string strConnect;
        System.Data.SqlClient.SqlDataAdapter dataAdapt;


        //set only method for strAction property
        public string StrAction
        {
            set { strAction = value; }
        }

        //set only method for strConnect property
        public string StrConnect
        {
            set { strConnect = value; }
        }

        // get only method for schoolsDataSet
        public System.Data.DataSet SchoolsDataSet
        {
            get { return schoolsDataSet(); }
        }

        //define and open new database connection using database location above. Fill data adapter with results of sqlAction query
        public System.Data.DataSet schoolsDataSet()
        {
            System.Data.SqlClient.SqlConnection schoolsConnection = new System.Data.SqlClient.SqlConnection(strConnect);
            schoolsConnection.Open();

            dataAdapt = new System.Data.SqlClient.SqlDataAdapter(strAction, schoolsConnection);

            System.Data.DataSet schoolsDataSet = new System.Data.DataSet();
            dataAdapt.Fill(schoolsDataSet, "tableData");
            schoolsConnection.Close();

            return schoolsDataSet;
        }

        //allow forms to update the data adaptor with changes in the current dataset table - used for editing records in the main form
        public void updateDB(System.Data.DataSet dataSet)
        {
            System.Data.SqlClient.SqlCommandBuilder commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapt);
            commandBuilder.DataAdapter.Update(dataSet.Tables[0]);
        }


    }
}
