using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY2.API
{
  public  class Company
    {
        private string name;
        private string title;
        private string id;
        private string location = "";
        private string job_category = "";
        private string experience_level = "";
        private string required_education_level = "";
        private string salary = "";

      public string Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }


        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                this.title = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                this.location = value;
            }
        }

        public string Job_category
        {
            get
            {
                return job_category;
            }
            set
            {
                this.job_category = value;
            }
        }

        public string Experience_level
        {
            get
            {
                return experience_level;
            }
            set
            {
                this.experience_level = value;
            }
        }

        public string Required_education
        {
            get
            {
                return required_education_level;
            }
            set
            {
                this.required_education_level = value;
            }
        }
        public string Salary
        {
            get
            {
                return salary;
            }
            set
            {
                this.salary = value;
            }
        }
    }
}
