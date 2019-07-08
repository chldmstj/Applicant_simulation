using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TRY2.API
{
    class Parsing
    {
        public List<Company> Parsing_Title(string url)
        {

            string Urlstring = "https://api.saramin.co.kr/job-search?job_type=1&count=30&job_category="+url;
            XmlTextReader reader = new XmlTextReader(Urlstring);
            bool id = false;
            bool title = false;
            bool name = false;
            bool location = false;
            bool job_category = false;
            bool experience_level = false;
            bool required_education_level = false;
            bool salary = false;
            string Name_s = "";
            string Title_s = "";
            string ID = "";
          
            string Location_s = "";
            string Job_category_s = "";
            string Experience_level_s = "";
            string Required_education_level_s = "";
            string Salary_s = "";
            List<Company> companies = new List<Company>();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        if (reader.Name == "id")id = true;
                        if (reader.Name == "name") name = true;
                        if (reader.Name == "title") title = true;
                        if (reader.Name == "location") location = true;
                        if (reader.Name == "job-category") job_category = true;
                        if (reader.Name == "experience-level") experience_level = true;
                        if (reader.Name == "required-education-level") required_education_level = true;
                        if (reader.Name == "salary") salary = true;

                        break;

                    case XmlNodeType.CDATA:
                        if (name) Name_s = reader.Value;
                        if (title) Title_s = reader.Value;
                        if (location) Location_s = reader.Value;
                        break;

                    case XmlNodeType.Text:

                        if (id) ID = reader.Value;
                        if (job_category) Job_category_s = reader.Value;
                        if (experience_level) Experience_level_s = reader.Value;
                        if (required_education_level) Required_education_level_s = reader.Value;
                        if (salary) Salary_s = reader.Value;
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "job")
                        {
                            companies.Add(new Company() { Id = ID, Name = Name_s, Title = Title_s,Location=Location_s,Job_category=Job_category_s,
                            Experience_level=Experience_level_s,Required_education=Required_education_level_s,Salary=Salary_s});


                        }
                        if (id) id = false;
                        if (name) name = false;
                        if (title) title = false;
                        if (location) location = false;
                        if (job_category) job_category = false;
                        if (experience_level) experience_level = false;
                        if (required_education_level) required_education_level = false;
                        if (salary) salary = false;
                        break;

                     
                }

           
            }

            return companies;

        }
        

    }
}
