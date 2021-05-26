using System;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class AddFullPaperWindow : Form {
        private readonly Participation _participation;
        private readonly Paper _paper;
        private readonly PaperManagementService _paperManagementService;

        public AddFullPaperWindow(Participation participation, Paper paper, PaperManagementService paperManagementService) {
            _participation = participation;
            _paper = paper;
            _paperManagementService = paperManagementService;
            InitializeComponent();
        }

        private async void addPaperButton_Click(object sender, EventArgs e) {
            await _paperManagementService.UpdatePaperAsync(_participation, _paper.Id ,abstractRichTextBox.Text, descriptionRichTextBox.Text);
        }
    }
}
