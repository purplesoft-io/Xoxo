namespace Xoxo
{
    using System.Collections.ObjectModel;
    using System;

    public class FilingIndicatorCollection : Collection<FilingIndicator> , IEquatable<FilingIndicatorCollection>
    {

        public FilingIndicatorCollection(Xbrl instance)
        {
        }

        public FilingIndicator Add(Context context, string value)
        {
            var filingIndicator = new FilingIndicator(context, value);
            base.Add(filingIndicator);
            return filingIndicator;
        }

        #region IEquatable implementation

        public bool Equals(FilingIndicatorCollection other)
        {
            var result = true;

            if (this.Count != other.Count)
            {
                result = false;
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (!this[i].Equals(other[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        #endregion
    }

}