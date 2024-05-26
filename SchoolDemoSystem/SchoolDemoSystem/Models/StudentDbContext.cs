using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDemoSystem.Models
{
    public class StudentDbContext
    {

        string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        public List<Country> GetCountryById()
        {
            List<Country> studentDbModels= new List<Country>();

            using(SqlConnection con=new SqlConnection(cs))
            {
                using(SqlCommand cmd=new SqlCommand("",con))
                {
                    con.Open();
                    SqlDataReader sdr =cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        studentDbModels.Add(new Country
                        {
                            CountryId = Convert.ToInt32(sdr["CountryId"]),
                            CountryName = Convert.ToString(sdr["CountryName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }

        public List<State> GetStateById()
        {
            List<State> studentDbModels = new List<State>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        studentDbModels.Add(new State
                        {
                            StateId = Convert.ToInt32(sdr["StateId"]),
                            StateName = Convert.ToString(sdr["StateName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }

        public List<City> GetCityById()
        {
            List<City> studentDbModels = new List<City>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        studentDbModels.Add(new City
                        {
                            CityId = Convert.ToInt32(sdr["CityId"]),
                            CityName = Convert.ToString(sdr["CityName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }
        
        public void AddStudentData(StudentDbModel dbModel)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FullName", dbModel.FullName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dbModel.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", dbModel.Gender);
            cmd.Parameters.AddWithValue("@Address", dbModel.Address);
            cmd.Parameters.AddWithValue("@CountryId", dbModel.CountryId);
            cmd.Parameters.AddWithValue("@StateId", dbModel.StateId);
            cmd.Parameters.AddWithValue("@CityId", dbModel.CityId);
            cmd.Parameters.AddWithValue("@ContactNumber", dbModel.ContactNumber);
            cmd.Parameters.AddWithValue("@Email", dbModel.Email);
            cmd.Parameters.AddWithValue("Photo", dbModel.Photo);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }



    }
}