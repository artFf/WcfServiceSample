using System;

namespace ConvertingTextLibrary.ViewInerfaces
{
    /// <summary>
    /// Interface for win form
    /// </summary>
    public interface IConvertingTextClient
    {
        #region Actions

        /// <summary>
        /// Occurs when [button close converting text form].
        /// </summary>
        event Action ButtonCloseConvertingTextForm;

        /// <summary>
        /// Occurs when [button to upper text click].
        /// </summary>
        event Action ButtonToUpperTextClick;

        /// <summary>
        /// Occurs when [button to lower text click].
        /// </summary>
        event Action ButtonToLowerTextClick;

        /// <summary>
        /// Occurs when [button to reverse text click].
        /// </summary>
        event Action ButtonToReverseTextClick;

        /// <summary>
        /// Occurs when [button to split text click].
        /// </summary>
        event Action ButtonToSplitTextClick;

        /// <summary>
        /// Occurs when [button clear].
        /// </summary>
        event Action ButtonClear;

        #endregion

        #region Methods

        /// <summary>
        /// Shows the result.
        /// </summary>
        /// <param name="text">The text.</param>
        void ShowResult(string text);

        /// <summary>
        /// Shows the splitted result.
        /// </summary>
        /// <param name="text">The text.</param>
        void ShowSplittedResult(string[] text);

        /// <summary>
        /// Exits this instance.
        /// </summary>
        void Exit();

        /// <summary>
        /// Clears this instance.
        /// </summary>
        void Clear();

        /// <summary>
        /// Gets the text from user.
        /// </summary>
        /// <returns>text from user</returns>
        string GetTextFromUser();

        #endregion
    }
}
