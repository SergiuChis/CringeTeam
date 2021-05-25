using System;
using System.Windows.Forms;
using CringeProject.Entities;
using CringeProject.Services;

namespace CringeProject.GUI {
    public partial class SubmitAbstractWindow : Form {
        private readonly User _user;
        private readonly Participation _participation;
        private readonly PaperManagementService _service;

        public SubmitAbstractWindow(User user, Participation participation, PaperManagementService service) {
            _user = user;
            _service = service;
            _participation = participation;
            InitializeComponent();
        }

        private async void submitAbstractButton_Click(object sender, EventArgs e) {
            await _service.AddPaperAsync(_user, _participation.SectionId, titleTextBox.Text, abstractRichTextBox.Text, "");
        }
    }
}
