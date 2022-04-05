using MelonLoader;

namespace CorneliusCornbread.SDK2_Safety
{
    public class SDK2_Safety : MelonMod
    {
        public const string ModCategoryId = "CC_SDK2_Safety";

        public static MelonLogger.Instance Logger { get; private set; }

        public override void OnApplicationStart()
        {
            Logger = LoggerInstance;
            
            Logger.Msg("---SDK2 Safety Init---");
        }
    }
}