using System;
using System.Windows.Forms;
using ConvertingTextLibrary.ViewInerfaces;

namespace WindowsFormsApplication1
{
    public partial class ConvertingTextClient : Form, IConvertingTextClient
    {
        #region Actions

        public event Action ButtonCloseConvertingTextForm;
        public event Action ButtonToUpperTextClick;
        public event Action ButtonToLowerTextClick;
        public event Action ButtonToReverseTextClick;
        public event Action ButtonToSplitTextClick;
        public event Action ButtonClear;

        #endregion

        public ConvertingTextClient()
        {
            InitializeComponent();
            CreateActions();
        }

        #region Publics methods

        public void ShowResult(string text)
        {
            richTextBoxForResult.Clear();
            richTextBoxForResult.AppendText(text);
        }

        public void ShowSplittedResult(string[] text)
        {
            richTextBoxForResult.Clear();
            int elementNumber = 1;
            foreach (var t in text)
            {
                richTextBoxForResult.AppendText(String.Format("Element {0} - {1}\n", elementNumber, t));
                elementNumber++;
            }
        }

        public void Exit()
        {
            this.Close();
        }

        public void Clear()
        {
            this.textBoxForUser.Text = string.Empty;
            this.richTextBoxForResult.Clear();
        }

        public string GetTextFromUser()
        {
            string text = textBoxForUser.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(@"Please, input text!");
                return string.Empty;
            }
            return textBoxForUser.Text;
        }

        #endregion

        #region Privates methods

        /// <summary>
        /// Creates the actions.
        /// </summary>
        private void CreateActions()
        {
            this.btnToUpper.Click += btnToUpper_Click;
            this.btnToLower.Click += btnToLower_Click;
            this.btnToReverse.Click += btnToReverse_Click;
            this.btnToSplit.Click += btnToSplit_Click;
            this.btnExit.Click += btnExit_Click;
            this.btnClear.Click += btnClear_Click;
            this.textBoxForUser.MaxLength = 30;            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ButtonClear != null)
            {
                ButtonClear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ButtonCloseConvertingTextForm != null)
            {
                this.ButtonCloseConvertingTextForm();
            }
        }

        private void btnToSplit_Click(object sender, EventArgs e)
        {
            if (ButtonToSplitTextClick != null)
            {
                this.ButtonToSplitTextClick();
            }
        }

        private void btnToReverse_Click(object sender, EventArgs e)
        {
            if (ButtonToReverseTextClick != null)
            {
                this.ButtonToReverseTextClick();
            }
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            if (ButtonToLowerTextClick != null)
            {
                this.ButtonToLowerTextClick();
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            if (ButtonToUpperTextClick != null)
            {
                this.ButtonToUpperTextClick();
            }
        }

        #endregion

    }
}
