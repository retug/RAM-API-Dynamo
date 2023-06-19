using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAMDATAACCESSLib;
using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Geometry;


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
        public static List<string> GET_STORY_NAMES(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int Story_Count = My_stories.GetCount();
            List<string> ListLine = new List<string>();
            for (int i = 0; i < Story_Count; i = i + 1)
            {
                string My_Story_Names = My_stories.GetAt(i).strLabel;
                ListLine.Add(My_Story_Names);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }
        public static List<int> GET_STORY_IDS(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int Story_Count = My_stories.GetCount();
            List<int> ListLine = new List<int>();
            for (int i = 0; i < Story_Count; i = i + 1)
            {
                int My_Story_Id = My_stories.GetAt(i).lUID;
                ListLine.Add(My_Story_Id);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }
        public static List<int> GET_RAM_BM_Number(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IBeams My_Beams = My_Story.GetBeams();
            int Beam_Count = My_Beams.GetCount();
            List<int> ListLine = new List<int>();
            //create loop herenthru all count
            //start..end..step
            for (int i = 0; i < Beam_Count; i = i + 1)
            {
                int My_Beam_ID = My_Story.GetBeams().GetAt(i).lLabel;
                ListLine.Add(My_Beam_ID);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }
        public static List<int> GET_RAM_BM_id(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IBeams My_Beams = My_Story.GetBeams();
            int Beam_Count = My_Beams.GetCount();
            List<int> ListLine = new List<int>();
            //create loop herenthru all count
            //start..end..step
            for (int i = 0; i < Beam_Count; i = i + 1)
            {
                int My_Beam_ID = My_Story.GetBeams().GetAt(i).lUID;
                ListLine.Add(My_Beam_ID);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }
        public static List<string> GET_RAM_BM_SIZE(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IBeams My_Beams = My_Story.GetBeams();
            int Beam_Count = My_Beams.GetCount();
            List<string> ListLine = new List<string>();
            //create loop herenthru all count
            //start..end..step
            for (int i = 0; i < Beam_Count; i = i + 1)
            {
                string My_Beam_Size = My_Story.GetBeams().GetAt(i).strSectionLabel;
                ListLine.Add(My_Beam_Size);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }

        public static List<EFRAMETYPE> GET_RAM_COL_IS_GRAV_OR_LATERAL(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IColumns My_Columns = My_Story.GetColumns();
            int Column_Count = My_Columns.GetCount();

            List<EFRAMETYPE> ListLine = new List<EFRAMETYPE>();
            //create loop herenthru all count
            //start..end..step
            for (int i = 0; i < Column_Count; i = i + 1)
            {
                EFRAMETYPE My_Column_EFrameType = My_Story.GetColumns().GetAt(i).eFramingType;
                ListLine.Add(My_Column_EFrameType);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            //return list 
            return ListLine;
        }

        public static List<double> GET_RAM_BM_LENGTH(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IBeams My_Beams = My_Story.GetBeams();
            int Beam_Count = My_Beams.GetCount();
            SCoordinate P1 = new SCoordinate();
            SCoordinate P2 = new SCoordinate();
            List<double> ListLine = new List<double>();
            //create loop herenthru all count
            //start..end..step
            for (int i = 0; i < Beam_Count; i = i + 1)
            {
                My_Story.GetBeams().GetAt(i).GetCoordinates(EBeamCoordLoc.eBeamEnds, ref P1, ref P2);
                double P1x = P1.dXLoc;
                double P1y = P1.dYLoc;
                double P1z = P1.dZLoc;
                double P2x = P2.dXLoc;
                double P2y = P2.dYLoc;
                double P2z = P2.dZLoc;
                Autodesk.DesignScript.Geometry.Point PD1 =
                        Autodesk.DesignScript.Geometry.Point.ByCoordinates(P1x, P1y, P1z);
                Autodesk.DesignScript.Geometry.Point PD2 =
                        Autodesk.DesignScript.Geometry.Point.ByCoordinates(P2x, P2y, P2z);
                Autodesk.DesignScript.Geometry.Line Dline =
                        Autodesk.DesignScript.Geometry.Line.ByStartPointEndPoint(PD1, PD2);
                double LengthBeam = Dline.Length;
                ListLine.Add(LengthBeam);
            }
            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }

    }
    public class RAM_RESULTS
    {
        private RAM_RESULTS()
        {
        }


        public static int GET_NUM_LOAD_CASES(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            RAMDATAACCESSLib.IForces2 IForces2 = (RAMDATAACCESSLib.IForces2)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IForces2_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            EAnalysisResultType My_EAnalysisResultType = EAnalysisResultType.DefaultResultType;
            int plNumAnalysisCases = 0;

            //these methods work when accessing IFORCES2 so accessing IFORCES2 correctly?
            Type MyIForces2_Type = IForces2.GetType();
            int MyIforces2_Hashcode = IForces2.GetHashCode();
            IForces2.GetNumAnalysisCases(My_EAnalysisResultType, ref plNumAnalysisCases);

            //CLOSE           
            IDBI.CloseDatabase();
            return plNumAnalysisCases;
        }

        public static int GET_NUM_LOAD_CASES_RAM_FRAME(string FileName)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            RAMDATAACCESSLib.IForces2 IForces2 = (RAMDATAACCESSLib.IForces2)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IForces2_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            // Adding RAMFrameResultType outputs load cases from RAM Frame
            EAnalysisResultType My_EAnalysisResultType = EAnalysisResultType.RAMFrameResultType;
            int plNumAnalysisCasesFrame = 0;
            //these methods work when accessing IFORCES2 so accessing IFORCES2 correctly?
            Type MyIForces2_Type = IForces2.GetType();
            int MyIforces2_Hashcode = IForces2.GetHashCode();
            
            IForces2.GetNumAnalysisCases(My_EAnalysisResultType, ref plNumAnalysisCasesFrame);
            

            //CLOSE           
            IDBI.CloseDatabase();
            return plNumAnalysisCasesFrame;
        }

        public static List<int> TEST_LOAD_CASE_ID(string FileName)
        {
            //ALL OF THIS IS CUSTOM CODE BY YOURS TRULY
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);

            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            // Adding RAMFrameResultType outputs load cases from RAM Frame
            EAnalysisResultType My_EAnalysisResultType = EAnalysisResultType.RAMFrameResultType;
            ILoadCases MyLoadCases = IModel.GetLoadCases(My_EAnalysisResultType);
            int ILoadCasesCount = MyLoadCases.GetCount();
            List<int> ListLine = new List<int>();
            for (int i = 0; i < ILoadCasesCount; i = i + 1)
            {
                ILoadCase Specific_case = MyLoadCases.GetAt(i);
                int Load_case_ID = Specific_case.lUID;
                ListLine.Add(Load_case_ID);
            }



            //CLOSE           
            IDBI.CloseDatabase();
            return ListLine;
        }




        [MultiReturn(new[] { "pdDead", "pdPosLLRed", "pdPosLLNonRed", "pdPosLLStorage", "pdPosLLRoof", "pdNegLLRed",
                "pdNegLLNonRed","pdNegLLStorage","pdNegLLRoof"})]
        public static Dictionary<string, object> GET_GRV_COL_FORCES(string FileName, int ColumnID)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            RAMDATAACCESSLib.IForces1 IForces1 = (RAMDATAACCESSLib.IForces1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IForces_INT);
            Dictionary<string, object> OutPutPorts = new Dictionary<string, object>();
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            double pdDead = 0;
            double pdPosLLRed = 0;
            double pdPosLLNonRed = 0;
            double pdPosLLStorage = 0;
            double pdPosLLRoof = 0;
            double pdNegLLRed = 0;
            double pdNegLLNonRed = 0;
            double pdNegLLStorage = 0;
            double pdNegLLRoof = 0;
            IForces1.GetGrvColForcesForLCase(ColumnID, ref pdDead, ref pdPosLLRed,
                ref pdPosLLNonRed, ref pdPosLLStorage, ref pdPosLLRoof, ref pdNegLLRed,
                ref pdNegLLNonRed, ref pdNegLLStorage, ref pdNegLLRoof);
            IFloorTypes My_floortypes = IModel.GetFloorTypes();
            int My_floortype_count = My_floortypes.GetCount();
            //CLOSE           
            IDBI.CloseDatabase();
            OutPutPorts.Add("pdDead", pdDead); OutPutPorts.Add("pdPosLLRed", pdPosLLRed);
            OutPutPorts.Add("pdPosLLNonRed", pdPosLLNonRed); OutPutPorts.Add("pdPosLLStorage", pdPosLLStorage);
            OutPutPorts.Add("pdPosLLRoof", pdPosLLRoof); OutPutPorts.Add("pdNegLLRed", pdNegLLRed);
            OutPutPorts.Add("pdNegLLNonRed", pdNegLLNonRed); OutPutPorts.Add("pdNegLLStorage", pdNegLLStorage);
            OutPutPorts.Add("pdNegLLRoof", pdNegLLRoof);
            return OutPutPorts;
        }

        [MultiReturn(new[] { "Camber", "TotalNumStuds", "StrengthRatio", "DelectionRatio" })]
        public static Dictionary<string, object> GET_RAM_BM_STUD_CAMBER_MRatio(string FileName, int StoryID, int GravityBeamID)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            Dictionary<string, object> OutPutPorts = new Dictionary<string, object>();
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();

            IStory My_Story_BY_id = My_stories.Get(StoryID);

            IBeam My_Beam = My_Story_BY_id.GetBeams().Get(GravityBeamID);

            int SizeofArray = 0;
            object ITEM = 1;
            double Camber = My_Beam.dCamber;

            DAArray My_Array_of_Studs = My_Beam.GetSteelDesignResult().GetNumStudsInSegments();
            My_Array_of_Studs.GetSize(ref SizeofArray);

            double My_Moment_DemandCapRatio = My_Beam.GetSteelDesignResult().dDesignCapacityInteraction;
            double My_Deflection_DemandCapRatio = My_Beam.GetSteelDesignResult().dCriticalDeflectionInteraction;
            // ahg added
            

            List<int> ListLine = new List<int>();
            //loop thru those studs in a segment and get them in a list then cast them from object to int to .sum it up....
            for (int i = 0; i < SizeofArray; i = i + 1)
            {
                My_Array_of_Studs.GetAt(i, ref ITEM);
                ListLine.Add((int)ITEM);
            }
            int TotalofStuds = ListLine.Sum();

            OutPutPorts.Add("Camber", Camber);
            OutPutPorts.Add("TotalNumStuds", TotalofStuds);
            //Round up results
            OutPutPorts.Add("StrengthRatio", Math.Round(My_Moment_DemandCapRatio, 2));
            OutPutPorts.Add("DelectionRatio", Math.Round(My_Deflection_DemandCapRatio, 2));

            //CLOSE           
            IDBI.CloseDatabase();
            return OutPutPorts;
        }
       

        [MultiReturn(new[] { "pdDeadMoment", "pdDeadShear", "pdCDMoment", "pdCDShear", "pdCLMoment", "pdCLShear",
                "pdPosLiveMoment","pdPosLiveShear","pdNegLiveMoment", "pdNegLiveShear"})]
        public static Dictionary<string, object> GET_GRV_BEAM_FORCES(string FileName, int BeamID, double BeamLocation)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT); //casting this to an object
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            RAMDATAACCESSLib.IForces1 IForces1 = (RAMDATAACCESSLib.IForces1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IForces_INT);
            Dictionary<string, object> OutPutPorts = new Dictionary<string, object>();
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            double pdDeadMoment = 0;
            double pdDeadShear= 0;
            double pdCDMoment = 0;
            double pdCDShear = 0;
            double pdCLMoment = 0;
            double pdCLShear = 0;
            double pdPosLiveMoment = 0;
            double pdPosLiveShear = 0;
            double pdNegLiveMoment = 0;
            double pdNegLiveShear = 0;
            IForces1.GetGravBeamForcesLeftAt(BeamID, BeamLocation, ref pdDeadMoment, ref pdDeadShear,
                ref pdCDMoment, ref pdCDShear, ref pdCLMoment, ref pdCLShear,
                ref pdPosLiveMoment, ref pdPosLiveShear, ref pdNegLiveMoment, ref pdNegLiveShear);
            //CLOSE           
            IDBI.CloseDatabase();
            OutPutPorts.Add("pdDeadMoment", pdDeadMoment); OutPutPorts.Add("pdDeadShear", pdDeadShear);
            OutPutPorts.Add("pdCDMoment", pdCDMoment); OutPutPorts.Add("pdCDShear", pdCDShear);
            OutPutPorts.Add("pdCLMoment", pdCLMoment); OutPutPorts.Add("pdCLShear", pdCLShear);
            OutPutPorts.Add("pdPosLiveMoment", pdPosLiveMoment); OutPutPorts.Add("pdPosLiveShear", pdPosLiveShear);
            OutPutPorts.Add("pdNegLiveMoment", pdNegLiveMoment); OutPutPorts.Add("pdNegLiveShear", pdNegLiveShear);
            return OutPutPorts;
        }
    }
    public class RAM_DIAPHRAM_RESULTS
    {
        private RAM_DIAPHRAM_RESULTS()
        {
        }


        public static int GET_DIAPHRAGM_COUNT(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IDiaphragms My_Diaphragm = My_Story.GetDiaphragms();
            int Diaphragm_Count = My_Diaphragm.GetCount();

        
            IDBI.CloseDatabase();
            return Diaphragm_Count;
        }
        public static List<int> GET_DIAPHRAGM_ID(string FileName, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");
            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IDiaphragms My_Diaphragm = My_Story.GetDiaphragms();
            int Diaphragm_Count = My_Diaphragm.GetCount();

            List<int> ListLine = new List<int>();
            for (int i = 0; i < Diaphragm_Count; i = i + 1)
            {
                int My_Diaphragm_ID = My_Story.GetDiaphragms().GetAt(i).lUID;
                ListLine.Add(My_Diaphragm_ID);
            }
            //CLOSE          

            IDBI.CloseDatabase();
            return ListLine;
        }
        //all written by yours truly
        [MultiReturn(new[] { "pdShearX", "pdShearY"})]
        public static Dictionary<string, object> GET_DIAPHRAGM_SHEARS(string FileName, int LoadCaseID, int DiaphragmNumber, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            Dictionary<string, object> OutPutPorts = new Dictionary<string, object>();
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IDiaphragms My_Diaphragm = My_Story.GetDiaphragms();
            //selects the specific diaphragm given the diaphragm number
            IDiaphragm My_Selected_Diaphragm = My_Story.GetDiaphragms().GetAt(DiaphragmNumber);

            double pdShearX = 0;
            double pdShearY = 0;

            //odd that this does not match the REF from GET_GRV_BEAM_FORCES
            //int x = My_Selected_Diaphragm.lUID;
            My_Selected_Diaphragm.GetShearsForLoadCase(LoadCaseID, out pdShearX, out pdShearY);
            //CLOSE           
            IDBI.CloseDatabase();
            OutPutPorts.Add("pdShearX", pdShearX); 
            OutPutPorts.Add("pdShearY", pdShearY);
            
            IDBI.CloseDatabase();
            return OutPutPorts;
            //return (pdShearX, pdShearY);
            //return x;
        }

        [MultiReturn(new[] { "pdDispX", "pdDispY" })]
        public static Dictionary<string, object> GET_DIAPHRAGM_DISPLACEMENTS(string FileName, int LoadCaseID, int DiaphragmNumber, int In_Story_Count)
        {
            RamDataAccess1 RAMDataAccess = new RAMDATAACCESSLib.RamDataAccess1();
            RAMDATAACCESSLib.IDBIO1 IDBI = (RAMDATAACCESSLib.IDBIO1)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
            RAMDATAACCESSLib.IModel IModel = (RAMDATAACCESSLib.IModel)
                RAMDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT);
            Dictionary<string, object> OutPutPorts = new Dictionary<string, object>();
            //OPEN
            IDBI.LoadDataBase2(FileName, "1");

            IStories My_stories = IModel.GetStories();
            int My_story_count = My_stories.GetCount();
            IStory My_Story = My_stories.GetAt(In_Story_Count);
            IDiaphragms My_Diaphragm = My_Story.GetDiaphragms();
            //selects the specific diaphragm given the diaphragm number
            IDiaphragm My_Selected_Diaphragm = My_Story.GetDiaphragms().GetAt(DiaphragmNumber);

            double pdDispX = 0;
            double pdDispY = 0;
            double pdThetaZ = 0;

            //odd that this does not match the REF from GET_GRV_BEAM_FORCES
            //int x = My_Selected_Diaphragm.lUID;
           
            My_Selected_Diaphragm.GetDisplacementsForLoadCase(LoadCaseID, out pdDispX, out pdDispY, out pdThetaZ);
            //CLOSE           
            IDBI.CloseDatabase();
            OutPutPorts.Add("pdDispX", pdDispX);
            OutPutPorts.Add("pdDispY", pdDispY);
            OutPutPorts.Add("pdThetaZ", pdThetaZ);

            IDBI.CloseDatabase();
            return OutPutPorts;
            //return (pdShearX, pdShearY);
            //return x;
        }
    }
    }
