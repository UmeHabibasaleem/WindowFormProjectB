using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class ListofClasses
    {
        public static List<StudentClass> studentList = new List<StudentClass>();
        public static List<CLOClass> cLOList = new List<CLOClass>();
        public static List<RubricsClass> rubList = new List<RubricsClass>();
        public static List<string> cloname = new List<string>();
        private static List<string> ASSname = new List<string>();
        private static List<string> studentname = new List<string>();
        private static List<RubricLevelClass> rLC = new List<RubricLevelClass>();
        private static List<AssessmentClass> ASSC = new List<AssessmentClass>();
        private static List<AssessmentComClass> ASSCom = new List<AssessmentComClass>();
        private static List<StudentResultClass> STR = new List<StudentResultClass>();
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

        public void addIntolist( StudentClass st)
        {
            studentList.Add(st);
        }
        public void remove(int id)
        {
            studentList.RemoveAt(id);
        }
        public void AddIntoCLoList(CLOClass cl)
        {
            CLOList.Add(cl);
        }
        public void RemoveFromCLO(int id)
        {
            CLOList.RemoveAt(id);
        }
        public void AddIntoRubricList(RubricsClass cl)
        {
            rubList.Add(cl);
        }
        public void RemoveFromRubrics()
        {
            rubList.Clear();
        }
        public void AddIntoStudentnameList(string cl)
        {
           studentname.Add(cl);
        }
        public void AddIntoAssnameList(string cl)
        {
            ASSname.Add(cl);
        }
        public void AddIntoCLOnameList(string cl)
        {
            Cloname.Add(cl);
        }
        public void AddRubricLevelList(RubricLevelClass rl)
        {
            RLC.Add(rl);
        }
        public void RemoveFromRubricLevel()
        {
            RLC.Clear();
        }
        public void AddASSList(AssessmentClass rl)
        {
            ASSC.Add(rl);
        }
        public void RemoveFromASS()
        {
            ASSC.Clear();
        }
        public void AddASSComList(AssessmentComClass ACC)
        {
            ASSCom.Add(ACC);
        }
        public void RemoveFromASSCom()
        {
            ASSCom.Clear();
        }
        public void AddSTRList(StudentResultClass SR)
        {
            STR.Add(SR);
        }
        public void RemoveFromSTR()
        {
            STR.Clear();
        }
    }
}
