namespace AdbFileManager {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
			SettingsManager.LoadSettings(); //nastaveni se musi na�ist u� tu aby jsme v�d�li zda je ��d�n dark mode
			if(SettingsManager.settings.DarkMode){
				DarkModeStartup.Initialize();
			}
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
			ApplicationConfiguration.Initialize();

			Application.Run(new Form1());
        }
    }
}