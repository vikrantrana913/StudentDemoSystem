using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDemoSystem.Models
{
    public class StudentDbContext
    {

        string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        public List<StudentDbModel> GetCountryById()
        {
            List<StudentDbModel> studentDbModels = new List<StudentDbModel>();

            using(SqlConnection con=new SqlConnection(cs))
            {
                using(SqlCommand cmd=new SqlCommand("",con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        studentDbModels.Add(new StudentDbModel 
                        {
                            CountryId = Convert.ToInt32(sdr["CountryId"]),
                            CountryName = Convert.ToString(sdr["CountryName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }

        public List<StudentDbModel> GetStateById()
        {
            List<StudentDbModel> studentDbModels = new List<StudentDbModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        studentDbModels.Add(new StudentDbModel
                        {
                            StateId = Convert.ToInt32(sdr["StateId"]),
                            StateName = Convert.ToString(sdr["StateName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }

        public List<StudentDbModel> GetCityById()
        {
            List<StudentDbModel> studentDbModels = new List<StudentDbModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        studentDbModels.Add(new StudentDbModel
                        {
                            CityId = Convert.ToInt32(sdr["CityId"]),
                            CityName = Convert.ToString(sdr["CityName"])
                        });
                    }
                }
            }
            return studentDbModels;
        }

    }
}