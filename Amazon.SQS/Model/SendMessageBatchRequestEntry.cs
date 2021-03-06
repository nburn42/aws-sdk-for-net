/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-10-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;


namespace Amazon.SQS.Model
{
    /// <summary>
    /// Contains the details of a single SQS message along with a <c>Id</c>.
    /// </summary>
    public class SendMessageBatchRequestEntry
    {
        private string idField;
        private string messageBodyField;
        private int? delaySecondsField;

        /// <summary>
        /// Gets and sets the Id property.  An identifier for the message in this batch. This is used to communicate
        /// the result. Note that the the <c>Id</c>s of a batch request need to
        /// be unique within the request.
        /// </summary>
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">An identifier for the message in this batch.</param>
        /// <returns>this instance</returns>
        public SendMessageBatchRequestEntry WithId(string id)
        {
            this.idField = id;
            return this;
        }

        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

        /// <summary>
        /// Gets and sets the MessageBody property.
        /// The message to send. The maximum allowed message size is 8 KB.
        /// The following list shows the characters (in Unicode) allowed in your message, according to the W3C XML specification
        /// (for more information, go to http://www.w3.org/TR/REC-xml/#charsets). If you send any characters not included in the
        /// list, your request will be rejected.
        ///
        /// #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
        /// </summary>
        [XmlElementAttribute(ElementName = "MessageBody")]
        public string MessageBody
        {
            get { return this.messageBodyField; }
            set { this.messageBodyField = value; }
        }

        /// <summary>
        /// Sets the MessageBody property
        /// </summary>
        /// <param name="messageBody">The message to send. The maximum allowed message size is 8 KB.
        /// The following list shows the characters (in Unicode) allowed in your message, according to the W3C XML specification
        /// (for more information, go to http://www.w3.org/TR/REC-xml/#charsets). If you send any characters not included in the
        /// list, your request will be rejected.
        ///
        /// #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]</param>
        /// <returns>this instance</returns>
        public SendMessageBatchRequestEntry WithMessageBody(string messageBody)
        {
            this.messageBodyField = messageBody;
            return this;
        }

        /// <summary>
        /// Checks if MessageBody property is set
        /// </summary>
        /// <returns>true if MessageBody property is set</returns>
        public bool IsSetMessageBody()
        {
            return this.messageBodyField != null;
        }

        /// <summary>
        /// Gets and sets the DelaySeconds property.
        /// The number of seconds to delay the message from being available for processing.
        /// </summary>
        public int DelaySeconds
        {
            get { return this.delaySecondsField.GetValueOrDefault(); }
            set { this.delaySecondsField = value; }
        }

        /// <summary>
        /// Sets the DelaySeconds property
        /// </summary>
        /// <param name="delaySeconds">The number of seconds to delay the message from being available for processing.</param>
        /// <returns>this instance</returns>
        public SendMessageBatchRequestEntry WithDelaySeconds(int delaySeconds)
        {
            this.delaySecondsField = delaySeconds;
            return this;
        }

        /// <summary>
        /// Checks if DelaySeconds property is set
        /// </summary>
        /// <returns>true if DelaySeconds property is set</returns>
        public bool IsSetDelaySeconds()
        {
            return this.delaySecondsField.HasValue;
        }
    }
}
