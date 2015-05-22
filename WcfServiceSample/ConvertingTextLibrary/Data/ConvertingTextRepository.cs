namespace ConvertingTextLibrary.Data
{
    /// <summary>
    /// Class to communicate with the WCF service
    /// </summary>
    public class ConvertingTextRepository
    {
        /// <summary>
        /// Gets or sets the converting text client.
        /// </summary>
        /// <value>
        /// The converting text client.
        /// </value>
        private ServiceConvertingText.ConvertingTextClient ConvertingTextClient { get; set; }

        public ConvertingTextRepository()
        {
            ConvertingTextClient = new ServiceConvertingText.ConvertingTextClient();
        }

        /// <summary>
        /// Gets the upper text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>upper text</returns>
        public string GetUpperText(string text)
        {
            return ConvertingTextClient.GetTextInUpperCase(text);
        }

        /// <summary>
        /// Gets the lower text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>lower text</returns>
        public string GetLowerText(string text)
        {
            return ConvertingTextClient.GetTextInLowerCase(text);
        }

        /// <summary>
        /// Gets the revers text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>revers text</returns>
        public string GetReversText(string text)
        {
            return ConvertingTextClient.GetReverseText(text);
        }

        /// <summary>
        /// Gets the split test.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>split test</returns>
        public string[] GetSplitTest(string text)
        {
            return ConvertingTextClient.GetSplitText(text);
        }
    }
}
