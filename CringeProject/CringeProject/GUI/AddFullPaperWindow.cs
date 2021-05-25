using System;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class AddFullPaperWindow : Form {
        private readonly Paper _paper;
        private readonly PaperManagementService _paperManagementService;

        public AddFullPaperWindow(Paper paper, PaperManagementService paperManagementService) {
            _paper = paper;
            _paperManagementService = paperManagementService;
            InitializeComponent();
        }

        private async void addPaperButton_Click(object sender, EventArgs e) {
            await _paperManagementService.UpdatePaperAsync(_paper.Id ,abstractRichTextBox.Text, descriptionRichTextBox.Text);
        }
    }
}
