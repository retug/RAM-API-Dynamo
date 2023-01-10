using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAMDATAACCESSLib;


namespace RAM_API
{
    public class GETSIMPLEINFO
    {
        private GETSIMPLEINFO()
        {
        }

        public static int marcelloAgeNodeNoInput(int fudgefactor = 1)
        {
            int marcelloAge = 5-fudgefactor;
            return marcelloAge;

        }
    }
    public class RAM_GEOMETRY
    {
        private RAM_GEOMETRY()
        {
        }
        public static int GET_STORY_COUNT(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();

            //CLOSE           
            IDBI.CloseDatabase();
            return My_story_count;
        }
    }
}
