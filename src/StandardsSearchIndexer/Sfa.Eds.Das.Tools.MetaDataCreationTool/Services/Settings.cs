namespace Sfa.Eds.Das.Tools.MetaDataCreationTool.Services
{
    using System.IO;
    using Sfa.Eds.Das.Tools.MetaDataCreationTool.Services.Interfaces;

    public class Settings : BaseSettings, ISettings
    {
        public string WorkingFolder => Path.Combine(Path.GetTempPath(), "WorkingSpace");

        public string GovLearningUrl => GetSetting();

        public string CsvFileName => GetSetting();

        public string VstsGitFolderPath => GetSetting();

        public string EnvironmentName => GetSetting();

        public string VstsGitGetFilesUrl => $"{VstsGitBaseUrl}/items?scopePath={VstsGitFolderPath}&recursionLevel=Full&api-version=2.0";
        public string VstsGitGetFilesUrlFormat => VstsGitBaseUrl + "/items?scopePath={0}&recursionLevel=Full&api-version=2.0";

        public string VstsGitAllCommitsUrl => $"{VstsGitBaseUrl}/commits?api-version=1.0&$top=1";

        public string VstsGitPushUrl => $"{VstsGitBaseUrl}/pushes?api-version=2.0-preview";

        public string GitUsername => GetSetting();
        public string GitPassword => GetSetting();
        public string GitBranch => GetSetting();

        // Private settings
        private string VstsGitBaseUrl => GetSetting();
    }
}