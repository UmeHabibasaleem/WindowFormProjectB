using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    /// This Class used to hold the temporary data storage of all the classes types used in this Project to move the data across the database ang GUI.
    /// </summary>
    class ListofClasses
    {
        /// <summary>
        /// All the static list of all the classess types with their Getter and Setter
        /// </summary>
        public static List<StudentClass> studentList = new List<StudentClass>();
        public static List<CLOClass> cLOList = new List<CLOClass>();
        public static List<RubricsClass> rubList = new List<RubricsClass>();
        public static List<string> cloname = new List<string>();
        private static List<string> ASSname = new List<string>();
        private static List<string> studentname = new List<string>();
        private static List<string> Assessment = new List<string>();
        private static List<RubricLevelClass> rLC = new List<RubricLevelClass>();
        private static List<AssessmentClass> ASSC = new List<AssessmentClass>();
        private static List<AssessmentComClass> ASSCom = new List<AssessmentComClass>();
        private static List<StudentResultClass> STR = new List<StudentResultClass>();
        private static List<ClassAttendence> CA = new List<ClassAttendence>();
        private static List<StudentAttendenceClass> SAC = new List<StudentAttendenceClass>();
        private static List<string> AttendenceDate = new List<string>();
        private static List<GenerateReport> CloReport = new List<GenerateReport>();
        internal List<CLOClass> CLOList
        {
            get
            {
                return cLOList;
            }

            set
            {
                cLOList = value;
            }
        }

        internal List<StudentClass> StudentList
        {
            get
            {
                return studentList;
            }

            set
            {
                studentList = value;
            }
        }

        internal List<RubricsClass> RubList
        {
            get
            {
                return rubList;
            }

            set
            {
                rubList = value;
            }
        }

        internal List<string> Cloname
        {
            get
            {
                return cloname;
            }

            set
            {
                cloname = value;
            }
        }

        internal  List<RubricLevelClass> RLC
        {
            get
            {
                return rLC;
            }

            set
            {
                rLC = value;
            }
        }

        internal  List<AssessmentClass> ASSC1
        {
            get
            {
                return ASSC;
            }

            set
            {
                ASSC = value;
            }
        }

        internal List<AssessmentComClass> ASSCom1
        {
            get
            {
                return ASSCom;
            }

            set
            {
                ASSCom = value;
            }
        }

        internal  List<StudentResultClass> STR1
        {
            get
            {
                return STR;
            }

            set
            {
                STR = value;
            }
        }

       

        public  List<string> ASSname1
        {
            get
            {
                return ASSname;
            }

            set
            {
                ASSname = value;
            }
        }

        public  List<string> Studentname
        {
            get
            {
                return studentname;
            }

            set
            {
                studentname = value;
            }
        }

        public  List<string> Assessment1
        {
            get
            {
                return Assessment;
            }

            set
            {
                Assessment = value;
            }
        }

        internal  List<ClassAttendence> CA1
        {
            get
            {
                return CA;
            }

            set
            {
                CA = value;
            }
        }

        internal  List<StudentAttendenceClass> SAC1
        {
            get
            {
                return SAC;
            }

            set
            {
                SAC = value;
            }
        }

        public List<string> AttendenceDate1
        {
            get
            {
                return AttendenceDate;
            }

            set
            {
                AttendenceDate = value;
            }
        }

        internal  List<GenerateReport> CloReport1
        {
            get
            {
                return CloReport;
            }

            set
            {
                CloReport = value;
            }
        }
        /// <summary>
        /// this function used to add student in the studentList
        /// </summary>
        /// <param name="st">student of type StudentClass</param>
        public void addIntolist( StudentClass st)
        {
            studentList.Add(st);
        }

        /// <summary>
        /// this function used to Remove tne student from the studentList
        /// </summary>
        /// <param name="id">Indicate the id of the student</param>
        public void remove(int id)
        {
            studentList.RemoveAt(id);
        }

        /// <summary>
        /// this function used to add tne  Clo from the CLO list
        /// </summary>
        /// <param name="cl">Clo of the CLOClass type</param>
        public void AddIntoCLoList(CLOClass cl)
        {
            CLOList.Add(cl);
        }

        /// <summary>
        /// this function used to Remove tne  Clo from the CLOList
        /// </summary>
        /// <param name="id">Indicate the id of the CLo</param>
        public void RemoveFromCLO(int id)
        {
            CLOList.RemoveAt(id);
        }

        /// <summary>
        /// this function used to Add tne  Rubric in the RubricList
        /// </summary>
        /// <param name="cl">Indicate the object of Rubric type</param>
        public void AddIntoRubricList(RubricsClass cl)
        {
            rubList.Add(cl);
        }

        /// <summary>
        /// this function used to Remove tne  Rubric from the RubricList
        /// </summary>
        public void RemoveFromRubrics()
        {
            rubList.Clear();
        }

        /// <summary>
        /// this function used to Add tne  StudentName from the Student
        /// </summary>
        /// <param name="cl">Indicate the name of student</param>
        public void AddIntoStudentnameList(string cl)
        {
           studentname.Add(cl);
        }

        /// <summary>
        /// This function used to Add tne  AssessmentID from the Assessment
        /// </summary>
        /// <param name="cl">Indicate the Assessment Title</param>
        public void AddIntoAssnameList(string cl)
        {
            ASSname.Add(cl);
        }

        /// <summary>
        /// This function used to Add tne  AttendenceDate from Attendance
        /// </summary>
        /// <param name="cl">Indicate the AttendanceDate</param>
        public void AddIntoAttendenceDate(string cl)
        {
            AttendenceDate.Add(cl);
        }

        /// <summary>
        /// This function used to Add in tne  ClonaName from the CLOLIst
        /// </summary>
        /// <param name="cl">INdicate the name of clo</param>
        public void AddIntoCLOnameList(string cl)
        {
            Cloname.Add(cl);
        }

        /// <summary>
        /// This function used to Add in  tne  Assessment list
        /// </summary>
        /// <param name="cl">Object of Assessment type</param>
        public void AddIntoAssesssment(string cl)
        {
            Assessment.Add(cl);
        }

        /// <summary>
        /// This function used to Add tne  RubricLevel in the RubricLevelList
        /// </summary>
        /// <param name="rl">Object of the Rubric</param>
        public void AddRubricLevelList(RubricLevelClass rl)
        {
            RLC.Add(rl);
        }

        /// <summary>
        /// This function used to Remove tne  RubricLevel from the RubricLevelList
        /// </summary>
        public void RemoveFromRubricLevel()
        {
            RLC.Clear();
        }

        /// <summary>
        /// This function used to ADD tne  Assessment in  the AssessmentList
        /// </summary>
        /// <param name="rl"></param>
        public void AddASSList(AssessmentClass rl)
        {
            ASSC.Add(rl);
        }

        /// <summary>
        /// this function used to Remove tne  student from the studentList
        /// </summary>
        public void RemoveFromASS()
        {
            ASSC.Clear();
        }


        /// <summary>
        /// this function used to Add tne  AssessmentComponent in the Assessment Component ClassList
        /// </summary>
        /// <param name="ACC">Indicate the object of the Assessmentcomponent class type</param>
        public void AddASSComList(AssessmentComClass ACC)
        {
            ASSCom.Add(ACC);
        }

        /// <summary>
        ///  This function used to remove tne AssessmentComponent from the AssessmentComponentList
        /// </summary>
        public void RemoveFromASSCom()
        {
            ASSCom.Clear();
        }

        /// <summary>
        ///  This function used to Add tne Student Result  in the StudentResultList
        /// </summary>
        /// <param name="SR">Indicate the object of type StudentResultClass</param>
        public void AddSTRList(StudentResultClass SR)
        {
            STR.Add(SR);
        }

        /// <summary>
        ///  This function used to Remove tne  StudentResult
        /// </summary>
        public void RemoveFromSTR()
        {
            STR.Clear();
        }

        /// <summary>
        ///  This function used to Add tne  Attendence in the ClassAttemndence
        /// </summary>
        /// <param name="st">Object of type ClassAttendence</param>
        public void addIntoAttendence(ClassAttendence st)
        {
            CA.Add(st);
        }

        /// <summary>
        ///  This function used to Add  Student Aytendancein the StudentAttendenceClass
        /// </summary>
        /// <param name="st">Indicate the object of type StudentAttendanceClass</param>
        public void addIntoStudentAttendence(StudentAttendenceClass st)
        {
            SAC.Add(st);
        }

        /// <summary>
        ///  This function used to Add the generate Report in the CloReport Class
        /// </summary>
        /// <param name="gr">Indicate the object of type GenerateReport</param>
        public void addIntoCloReport(GenerateReport gr)
        {
            CloReport.Add(gr);
        }
    
}
}
