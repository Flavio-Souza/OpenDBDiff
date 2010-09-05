using System;
using System.Collections.Generic;
using System.Text;

namespace DBDiff.Schema.Sybase.Options
{
    public class AseOptionDefault
    {
        private string defaultIntegerValue = "0";
        private string defaultRealValue = "0.0";
        private string defaultTextValue = "''";
        private string defaultDateValue = "getdate()";
        private string defaultVariantValue = "''";
        private string defaultNTextValue = "N''";
        private string defaultBlobValue = "0x";
        private string defaultUniqueValue = "NEWID()";
        private Boolean useDefaultValueIfExists = true;

        /// <summary>
        /// Gets or sets a value indicating whether use default value if exists.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if use default value if exists; otherwise, <c>false</c>.
        /// </value>
        public Boolean UseDefaultValueIfExists
        {
            get { return useDefaultValueIfExists; }
            set { useDefaultValueIfExists = value; }
        }

        /// <summary>
        /// Gets or sets the default unique (uniqueidentifier) values.
        /// </summary>
        /// <value>The default unique value.</value>
        public string DefaultUniqueValue
        {
            get { return defaultUniqueValue; }
            set { defaultUniqueValue = value; }
        }

        /// <summary>
        /// Gets or sets the default BLOB (varbinary,image, bynary) values.
        /// </summary>
        /// <value>The default BLOB value.</value>
        public string DefaultBlobValue
        {
            get { return defaultBlobValue; }
            set { defaultBlobValue = value; }
        }

        /// <summary>
        /// Gets or sets the default Unicode text (nvarchar,nchar,ntext) values.
        /// </summary>
        /// <value>The default N text value.</value>
        public string DefaultNTextValue
        {
            get { return defaultNTextValue; }
            set { defaultNTextValue = value; }
        }

        /// <summary>
        /// Gets or sets the default sql_variant values.
        /// </summary>
        /// <value>The default variant value.</value>
        public string DefaultVariantValue
        {
            get { return defaultVariantValue; }
            set { defaultVariantValue = value; }
        }

        /// <summary>
        /// Gets or sets the default date (datetime,smalldatetime) values.
        /// </summary>
        /// <value>The default date value.</value>
        public string DefaultDateValue
        {
            get { return defaultDateValue; }
            set { defaultDateValue = value; }
        }

        /// <summary>
        /// Gets or sets the default text (varchar,char,text) values.
        /// </summary>
        /// <value>The default text value.</value>
        public string DefaultTextValue
        {
            get { return defaultTextValue; }
            set { defaultTextValue = value; }
        }

        /// <summary>
        /// Gets or sets the default real (decimal,money,numeric,float) value.
        /// </summary>
        /// <value>The default real value.</value>
        public string DefaultRealValue
        {
            get { return defaultRealValue; }
            set { defaultRealValue = value; }
        }

        /// <summary>
        /// Gets or sets the default integer (int, smallint, bigint, tinyint, bit) value.
        /// </summary>
        /// <value>The default integer value.</value>
        public string DefaultIntegerValue
        {
            get { return defaultIntegerValue; }
            set { defaultIntegerValue = value; }
        }


    }
}