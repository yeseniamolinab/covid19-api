namespace covid19_api.Common.Constants
{
    /// <summary>
    /// Constants for the controller top route layer
    /// </summary>
    public static class ApiConstants
    {
        /// <summary>
        /// The default controller
        /// </summary>
        public const string DefaultController = "[controller]";

    }

    /// <summary>
    /// Constants for the covid api
    /// </summary>
    public static class RouteConstants
    {
        /// <summary>
        /// The by prediction
        /// </summary>
        public const string ByPrediction = "prediction";

        /// <summary>
        /// The by status
        /// </summary>
        public const string ByStatus = "status";
    }

    /// <summary>
    /// Constants for route parameters
    /// </summary>
    public static class RouteParamsConstants
    {
        /// <summary>
        /// The country code
        /// </summary>
        public const string Country = "{country}";
    }
}