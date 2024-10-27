namespace CoreLib
{
    /// <summary>
    /// Core library of the project.
    /// </summary>
    public class MainCore
    {
        #region Fields and Properties

        private readonly string _baseApiUrl = "https://api.data.gov.my/";

        private static readonly MainCore _instance = new MainCore();

        /// <summary>
        /// 
        /// </summary>
        public static string UrlSource_MainSite
        {
            get
            {
                return "https://data.gov.my/";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string UrlSource_ApiDoc
        {
            get
            {
                return "https://developer.data.gov.my/";
            }
        }

        #endregion

        #region Constructors

        private MainCore()
        {

        }

        /// <summary>
        /// Get singleton instance of MainCore.
        /// </summary>
        /// <returns></returns>
        public static MainCore Instance() { return _instance; }

        #endregion

        #region Methods



        #endregion
    }
}
