using ConvertingTextLibrary.Data;
using ConvertingTextLibrary.Models;
using ConvertingTextLibrary.ViewInerfaces;

namespace ConvertingTextLibrary.Presenters
{
    public class ConvertingTextPresenter
    {
        #region Privates fields

        private readonly IConvertingTextClient _convertingTextClientView;
        private readonly ConvertingTextRepository _convertingTextRepository;
        private ConvertingString _convertingString;

        #endregion

        public ConvertingTextPresenter(IConvertingTextClient convertingTextClient,
            ConvertingTextRepository convertingTextRepository)
        {
            this._convertingTextClientView = convertingTextClient;
            this._convertingTextRepository = convertingTextRepository;
            this._convertingString = new ConvertingString();

            this._convertingTextClientView.ButtonToUpperTextClick += _convertingTextClient_ButtonToUpperTextClick;
            this._convertingTextClientView.ButtonToLowerTextClick +=_convertingTextClientView_ButtonToLowerTextClick;
            this._convertingTextClientView.ButtonToReverseTextClick +=_convertingTextClientView_ButtonToReverseTextClick;
            this._convertingTextClientView.ButtonToSplitTextClick +=_convertingTextClientView_ButtonToSplitTextClick;
            this._convertingTextClientView.ButtonCloseConvertingTextForm +=ConvertingTextClientViewButtonCloseConvertingTextForm;
            this._convertingTextClientView.ButtonClear +=_convertingTextClientView_ButtonClear;
        }

        #region Privates methods

        private void _convertingTextClientView_ButtonClear()
        {
            this._convertingTextClientView.Clear();
        }

        private void ConvertingTextClientViewButtonCloseConvertingTextForm()
        {
            this._convertingTextClientView.Exit();
        }

        private void _convertingTextClientView_ButtonToReverseTextClick()
        {
            _convertingString.Text = this._convertingTextClientView.GetTextFromUser();
            var result = this._convertingTextRepository.GetReversText(_convertingString.Text);
            this._convertingTextClientView.ShowResult(result);
        }

        private void _convertingTextClientView_ButtonToSplitTextClick()
        {
            _convertingString.Text = this._convertingTextClientView.GetTextFromUser();
            var result = this._convertingTextRepository.GetSplitTest(_convertingString.Text);
            this._convertingTextClientView.ShowSplittedResult(result);
        }

        private void _convertingTextClientView_ButtonToLowerTextClick()
        {
            _convertingString.Text = this._convertingTextClientView.GetTextFromUser();
            var result = this._convertingTextRepository.GetLowerText(_convertingString.Text);
            this._convertingTextClientView.ShowResult(result);
        }

        private void _convertingTextClient_ButtonToUpperTextClick()
        {
            _convertingString.Text = this._convertingTextClientView.GetTextFromUser();
            var result = this._convertingTextRepository.GetUpperText(_convertingString.Text);
            this._convertingTextClientView.ShowResult(result);
        }

        #endregion


    }
}
