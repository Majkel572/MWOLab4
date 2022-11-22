using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MWOLab4_AzurePipeline {
    public class BlinkBlinkBoy : PageModel{
        private readonly ILogger<BlinkBlinkBoy> logger;
        public string Version { get; set; }

        public BlinkBlinkBoy(ILogger<BlinkBlinkBoy> _logger) {
            this.logger = _logger;
            string versionFile = "versions.txt";
            string? versionText = null;
            if (System.IO.File.Exists(versionFile)) {
                versionText = System.IO.File.ReadAllText(versionFile);
            }
            if(versionText is null or "") {
                Version = "Lack of versions";
            } else {
                Version = versionText;
            }
        }
    }
}
