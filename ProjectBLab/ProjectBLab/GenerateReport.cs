using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class GenerateReport
    {
        private string RegistrationNumber;
        private string ObtainMarks;
        private string CloName;
      

        public string RegistrationNumber1
        {
            get
            {
                return RegistrationNumber;
            }

            set
            {
                RegistrationNumber = value;
            }
        }

        public string ObtainMarks1
        {
            get
            {
                return ObtainMarks;
            }

            set
            {
                ObtainMarks = value;
            }
        }

        public string CloName1
        {
            get
            {
                return CloName;
            }

            set
            {
                CloName = value;
            }
        }

        public void CLOwiseReport()
        {
            string query = " Select sub2.RegistrationNumber,sub2.Name,sum(Sub2.Result) as ObtainMarks from " +
            "(Select sub.RegistrationNumber, sub.Name, Sub.MeasurementLevel, Sub.TotalMarks, (Sub.MeasurementLevel * Sub.TotalMarks) / 4.0 as Result From " +
            "(SELECT   S.RegistrationNumber, MeasurementLevel, TotalMarks, Clo.Name, R.Details " +
            "FROM StudentResult as SR " +
            "INNER JOIN Student as S ON StudentId = S.Id " +
            "INNER JOIN AssessmentComponent ON AssessmentComponentId = AssessmentComponent.Id " +
            "INNER JOIN RubricLevel As RL ON RL.Id = SR.RubricMeasurementId " +
            "INNER JOIN Rubric AS R ON R.Id = RL.RubricId " +
            "INNER JoIN Clo ON R.CloId = Clo.Id) as sub) as sub2 Group By RegistrationNumber , Name Order By RegistrationNumber";
            Connection c1 = new Connection();
            c1.ClowiseResultRecord(query);
            
        }
    }
}
