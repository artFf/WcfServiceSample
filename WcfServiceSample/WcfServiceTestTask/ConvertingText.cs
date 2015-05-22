using System.Linq;

namespace WcfServiceTestTask
{
    /// <summary>
    /// Class implementeds interface IConvertingText
    /// </summary>
    public class ConvertingText : IConvertingText
    {
        /// <summary>
        /// Gets the text in upper case.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// text in upper case
        /// </returns>
        public string GetTextInUpperCase(string text)
        {
            return text.ToUpper();
        }

        /// <summary>
        /// Gets the text in lower case.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// text in lower case
        /// </returns>
        public string GetTextInLowerCase(string text)
        {
            return text.ToLower();
        }

        /// <summary>
        /// Gets the reverse text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// reverse text
        /// </returns>
        public string GetReverseText(string text)
        {
            return new string(text.Reverse().ToArray());
        }

        /// <summary>
        /// Gets the split text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// split text
        /// </returns>
        public string[] GetSplitText(string text)
        {
            return text.Split(' ');
        }
    }
}
