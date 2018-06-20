using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/*Emer Campbell 2018*/


namespace SchoolsDatabase
{    
    public partial class frmView : Form
    {
     /* define object of dbInterface class and string variable to hold SQL for retrieving data from students table.  
        Declare dataset and datarow to hold retrieved student info.
        Declare control variables for record navigation */

        dbInterface studentTableConnection;
        string studentDetailsConString;

        DataSet studentsDS;
        DataRow studentsDR;

        int noRows;
        int currentRecordIndex = 0;

        /* define object of dbInterface class and string variable to hold SQL for retrieving data from studentsclasses.  
        Declare dataset to hold retrieved student classes info. */
        
        dbInterface studentClassesConnection;
        string studentClassesConString;

        DataSet studentClassesDS;

      
        
        public frmView()
        {
            InitializeComponent();
        }

        


        private void frmView_Load(object sender, EventArgs e)
        {
          /*use dbInterface to open a database connection and create datasets and datarows for retrieved data.  Set control variables based on retrieved data.
          use SQL code defined in properties to select data from students table database
          call method to navigate records*/
            try
            {
                studentTableConnection = new dbInterface();
                studentDetailsConString = Properties.Settings.Default.schoolConnectionString;

                studentTableConnection.StrConnect = studentDetailsConString;
                studentTableConnection.StrAction = Properties.Settings.Default.studentsSQL;

                studentsDS = studentTableConnection.SchoolsDataSet;

                noRows = studentsDS.Tables[0].Rows.Count;

                recordNavigation();

                //call method to update list view with details of current student
                updateListView();

            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);

            }      
                                  
        }
        
        //fill student details text boxes with values from data row.  dateRegistered must be captured and formatted to remove automatic timestamp
        private void recordNavigation()
        {        
            studentsDR = studentsDS.Tables[0].Rows[currentRecordIndex];
            
            DateTime dateRegistered = Convert.ToDateTime(studentsDR.ItemArray.GetValue(3));
            string dateOnly = dateRegistered.ToString("d");
                           
            txtStudentID.Text = studentsDR.ItemArray.GetValue(0).ToString();
            txtFirstName.Text = studentsDR.ItemArray.GetValue(1).ToString();
            txtSecondName.Text = studentsDR.ItemArray.GetValue(2).ToString();
            txtDateRegistered.Text = dateOnly;
            txtCourse.Text = studentsDR.ItemArray.GetValue(4).ToString();
            txtTelNumber.Text = studentsDR.ItemArray.GetValue(5).ToString();
            txtEmail.Text = studentsDR.ItemArray.GetValue(6).ToString();
        }

        //use current row number and count of number of rows in database to move to previous record by calling method from connection class.  Update List View.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentRecordIndex > 0 )
            {
                currentRecordIndex--;
                recordNavigation();
                lvStudentClasses.Items.Clear();
                updateListView();
            }
            else
            {
                MessageBox.Show("You have reached the last record");
            }

        }

        //use current row number and count of number of rows in database to move to next record by calling method from connection class.  Update List View.
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (currentRecordIndex != noRows - 1)
            {
                currentRecordIndex++;
                recordNavigation();
                lvStudentClasses.Items.Clear();
                updateListView();
            }
            else
            {
                MessageBox.Show("You have reached the last record");
            }
        }

       // Make student details text boxes read/write
        private void btnEditS_Click(object sender, EventArgs e)
        {
            btnEditS.Enabled = false;
            btnSDSave.Visible = true;
            btnSDCancel.Visible = true;
            readWriteTrue();
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
                        
        }


        //Two methods to enable/disable student details text boxes
        private void readWriteTrue()
        {
            txtStudentID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSecondName.ReadOnly = false;
            txtDateRegistered.ReadOnly = false;
            txtCourse.ReadOnly = false;
            txtTelNumber.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }

        private void readWriteFalse()
        {
            txtStudentID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtSecondName.ReadOnly = true;
            txtDateRegistered.ReadOnly = true;
            txtCourse.ReadOnly = true;
            txtTelNumber.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        //Edit current row in dataset with current data in text box.  Update database using methid in dbInterface class
        private void btnSDSave_Click(object sender, EventArgs e)
        {
            DataRow changedStudent = studentsDS.Tables[0].Rows[currentRecordIndex];
            changedStudent[0] = txtStudentID.Text;
            changedStudent[1] = txtFirstName.Text;
            changedStudent[2] = txtSecondName.Text;
            changedStudent[3] = txtDateRegistered.Text;
            changedStudent[4] = txtCourse.Text;
            changedStudent[5] = txtTelNumber.Text;
            changedStudent[6] = txtEmail.Text;
            
            try
            {
                recordNavigation();
                readWriteFalse();
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnSDSave.Visible = false;
                btnSDCancel.Visible = false;
                btnEditS.Enabled = true;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                studentTableConnection.updateDB(studentsDS);
                MessageBox.Show("Your changes have been saved");
            }

            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
        }

        
        private void btnSDCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Save/Cancel", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                recordNavigation();
                readWriteFalse();
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnSDSave.Visible = false;
                btnSDCancel.Visible = false;
                btnEditS.Enabled = true;
            }

           
        }

        //retrieve related info from student classes table and update list view
        private void updateListView()
        {
            
            try
            {
                studentClassesConnection = new dbInterface();
                studentClassesConString = Properties.Settings.Default.schoolConnectionString;

                studentClassesConnection.StrConnect = studentClassesConString;
                studentClassesConnection.StrAction = Properties.Settings.Default.studentCoursesSQL + "'" + txtStudentID.Text + "'";

                studentClassesDS = studentClassesConnection.SchoolsDataSet;

                ListViewItem studentCoursesLV = new ListViewItem();
                foreach (DataRow dR in studentClassesDS.Tables["tableData"].Rows)
                {
                    studentCoursesLV = lvStudentClasses.Items.Add(dR["className"].ToString());
                    studentCoursesLV.SubItems.Add(dR["teacher"].ToString());
                    studentCoursesLV.SubItems.Add(dR["room"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Student-Classes information not available at this time");
            }
        }



        
    }
}
