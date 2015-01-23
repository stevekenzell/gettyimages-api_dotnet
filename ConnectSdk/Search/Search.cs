using System;

namespace GettyImages.Connect.Search
{
    public class Search
    {
        private readonly string _baseUrl;
        private readonly Credentials _credentials;

        private Search(Credentials credentials, string baseUrl)
        {
            _credentials = credentials;
            _baseUrl = baseUrl;
        }

        internal static Search GetInstance(Credentials credentials, string baseUrl)
        {
            return new Search(credentials, baseUrl);
        }

        public IBlendedImagesSearch Images()
        {
            return SearchImages.GetInstance(_credentials, _baseUrl);
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class DescriptionAttribute : Attribute
    {
        private readonly string _description;

        public DescriptionAttribute(string description)
        {
            _description = description;
        }

        public string Description
        {
            get { return _description; }
        }
    }
}