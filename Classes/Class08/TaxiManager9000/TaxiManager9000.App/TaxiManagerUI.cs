using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.App
{
    internal class TaxiManagerUI
    {
        private readonly IUIService _uiService;



        public void InitApp()
        {
            #region Login Menu

            try
            {
                ConsoleHelper.PrintTitle("\n\t*** Taxi Manager 9000 ***\n");
                
            }
            catch (Exception ex)
            {
                
            }
            #endregion
        }
    }
}
