using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTestTask
{
    [ServiceContract]
    public interface IConvertingText
    {
        /// <summary>
        /// Gets the text in upper case.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>text in upper case</returns>
        [OperationContract]
        string GetTextInUpperCase(string text);

        /// <summary>
        /// Gets the text in lower case.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>text in lower case</returns>
        [OperationContract]
        string GetTextInLowerCase(string text);

        /// <summary>
        /// Gets the reverse text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>reverse text</returns>
        [OperationContract]
        string GetReverseText(string text);

        /// <summary>
        /// Gets the split text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>split text</returns>
        [OperationContract]
        string[] GetSplitText(string text);
    }
}
