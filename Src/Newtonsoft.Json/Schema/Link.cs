using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
    /// <summary>
    /// In Memory representation of a JSON Schema Link
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Creates a new <seealso cref="Link"/>
        /// </summary>
        public Link()
        {
            MediaType = JsonSchemaConstants.JsonMediaType;
        }

        /// <summary>
        ///  Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the relative link
        /// </summary>
        public string Rel { get; set; }

        /// <summary>
        /// Gets or sets the Href of the link
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the Method of the link
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the Media Type
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets the Target Schema
        /// </summary>
        public JObject TargetSchema { get; set; }

        /// <summary>
        /// Gets or sets the schema of the link
        /// </summary>
        public JsonSchema Schema { get; set; }
    }
}