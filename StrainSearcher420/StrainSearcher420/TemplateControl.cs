using System.Drawing;
using System.Windows.Forms;

namespace StrainSearcher420
{
    public partial class TemplateControl : UserControl
    {
        public TemplateControl()
        {
            InitializeComponent();
        }

        public string StrainName 
        {
            get { return strainTemplateName.Text; }
            set { strainTemplateName.Text = value; }
        }

        public string Effects
        {
            get { return effectTextTemplate.Text; }
            set { effectTextTemplate.Text = value; }
        }

        public string Negatives
        {
            get { return negativeTextTemplate.Text; }
            set { negativeTextTemplate.Text = value; }
        }

        public string Taste
        {
            get { return tasteTextTemplate.Text; }
            set { tasteTextTemplate.Text = value; }
        }

        public string THC
        {
            get { return thcTemplateText.Text; }
            set { thcTemplateText.Text = value; }
        }

        public string CBD
        {
            get { return cbdTemplateText.Text; }
            set { cbdTemplateText.Text = value; }
        }

        public string Rating
        {
            get { return ratingTemplateText.Text; }
            set { ratingTemplateText.Text = value; }
        }

        public Image Image
        {
            get { return strainImageTemplate.Image; }
            set { strainImageTemplate.Image = value; }
        }

    }
}
