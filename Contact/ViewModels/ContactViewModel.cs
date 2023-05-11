using Contact.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.ViewModels
{
    public class ContactViewModel
    {
        public DbConn dbConn = new DbConn();

        #region Select 

        public DataTable Select()
        {
            // Connection Database 
            SqlConnection conn = new SqlConnection(dbConn.myConnection);

            DataTable dt = new DataTable();

            try
            {
                // Writing SQL Query
                string sql = "SELECT * FROM tbl_contatti";

                // Creating cmd Using SQL an conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Creating SQL DataAdapter Using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Connection
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                throw new Exception("Errore!", ex);
            }
            finally 
            { 
                conn.Close(); 
            }
            
            return dt;
        }

        #endregion

        #region Insert

        public bool Insert(Contatti contactVm)
        {
            // Creating a default return and setting its value to false
            bool IsSucess = false;

            // Connection Database 
            SqlConnection conn = new SqlConnection(dbConn.myConnection);
            
            
            try
            {
                string sql = "INSERT INTO tbl_contatti " +
                    "(Nome, Cognome, Contatto, Indirizzo, Genere)" +
                    " VALUES " +
                    "(@Nome, @Cognome, @Contatto, @Indirizzo, @Genere)";

                // Creating SQL Command Using SQl and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome",      contactVm.Nome);
                cmd.Parameters.AddWithValue("@Cognome",   contactVm.Cognome);
                cmd.Parameters.AddWithValue("@Contatto",  contactVm.Contatto);
                cmd.Parameters.AddWithValue("@Indirizzo", contactVm.Indirizzo);
                cmd.Parameters.AddWithValue("@Genere",    contactVm.Genere);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                /* 
                 * if the query runs sucessfylly 
                 * hten value of rows will be greater 
                 * than zero else its value be 0
                 */
                if (rows > 0)
                {
                    IsSucess = true;
                }
                else
                {
                    IsSucess = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore!", ex);
            }
            finally
            {
                conn.Close();
            }

            return IsSucess;
        }

        #endregion

        #region Update

        public bool Uptade(Contatti contactVm)
        {
            // Creating a default return and setting its value to false
            bool IsSucess = false;

            // Connection Database 
            SqlConnection conn = new SqlConnection(dbConn.myConnection);


            try   
            {

               string strquery = "UPDATE tbl_contatti SET Nome = @Nome, Cognome = @Cognome, Contatto = @Contatto, Indirizzo = @Indirizzo, Genere = @Genere WHERE ContactID = @ContactID";



                // Creating SQL Command Using SQl and conn
                SqlCommand cmd = new SqlCommand(strquery, conn);

                cmd.Parameters.AddWithValue("@Nome",      contactVm.Nome);
                cmd.Parameters.AddWithValue("@ContactID", contactVm.ContactID);
                cmd.Parameters.AddWithValue("@Cognome",   contactVm.Cognome);
                cmd.Parameters.AddWithValue("@Contatto",  contactVm.Contatto);
                cmd.Parameters.AddWithValue("@Indirizzo", contactVm.Indirizzo);
                cmd.Parameters.AddWithValue("@Genere",    contactVm.Genere);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSucess = true;
                }
                else
                {
                    IsSucess = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error!", ex);
            }
            finally
            {
                conn.Close();
            }

            return IsSucess;
        }

        #endregion

        #region Delete

        public bool Delete(Contatti contatti)
        {
            bool IsSucess = false;

            SqlConnection conn = new SqlConnection(dbConn.myConnection);

            try
            {
                string sql = "DELETE FROM tbl_contatti WHERE ContactID = @ContactID";

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("ContactID", contatti.ContactID);

                conn.Open() ;
                
                int rows = command.ExecuteNonQuery();
                
                if (rows > 0)
                    IsSucess = true;
                else
                    IsSucess = false;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore!", ex);
            }
            finally
            {
                conn.Close();
            }

            return IsSucess;
        }

        #endregion
    }
}
