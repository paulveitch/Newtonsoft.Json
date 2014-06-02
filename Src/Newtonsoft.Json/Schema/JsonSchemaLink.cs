using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
    /// <summary>
    /// In Memory representation of a JSON Schema JsonSchemaLink
    /// </summary>
    public class JsonSchemaLink : IEquatable<JsonSchemaLink>
    {
        /// <summary>
        /// Creates a new <seealso cref="JsonSchemaLink"/>
        /// </summary>
        public JsonSchemaLink()
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

        /// <summary>
        /// Determines whether the specified <see cref="T:Newtonsoft.Json.Schema.JsonSchemaLink"/> is equal to the current <see cref="T:Newtonsoft.Json.Schema.JsonSchemaLink"/>.
        /// </summary>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((JsonSchemaLink) obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:Newtonsoft.Json.Schema.JsonSchemaLink"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Rel != null ? Rel.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Href != null ? Href.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Method != null ? Method.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MediaType != null ? MediaType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (TargetSchema != null ? TargetSchema.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Schema != null ? Schema.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary>
        /// Checks if two Links are equal
        /// </summary>
        /// <param name="left">The first JsonSchemaLink to check</param>
        /// <param name="right">The second JsonSchemaLink to check</param>
        /// <returns>True if the Links are equal, false otherwise</returns>
        public static bool operator ==(JsonSchemaLink left, JsonSchemaLink right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Checks if two Links are not equal
        /// </summary>
        /// <param name="left">The first JsonSchemaLink to check</param>
        /// <param name="right">The second JsonSchemaLink to check</param>
        /// <returns>True if the Links are not equal, false otherwise</returns>
        public static bool operator !=(JsonSchemaLink left, JsonSchemaLink right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Indicates whether the current JsonSchemaLink is equal to another JsonSchemaLink.
        /// </summary>
        /// <returns>
        /// true if the current JsonSchemaLink is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An JsonSchemaLink to compare with this JsonSchemaLink.</param>
        public bool Equals(JsonSchemaLink other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Title, other.Title) && string.Equals(Rel, other.Rel) && string.Equals(Href, other.Href) && string.Equals(Method, other.Method) && string.Equals(MediaType, other.MediaType) && Equals(TargetSchema, other.TargetSchema) && Equals(Schema, other.Schema);
        }

        private sealed class LinkEqualityComparer : IEqualityComparer<JsonSchemaLink>
        {
            public bool Equals(JsonSchemaLink x, JsonSchemaLink y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return string.Equals(x.Title, y.Title) && string.Equals(x.Rel, y.Rel) && string.Equals(x.Href, y.Href) && string.Equals(x.Method, y.Method) && string.Equals(x.MediaType, y.MediaType) && Equals(x.TargetSchema, y.TargetSchema) && Equals(x.Schema, y.Schema);
            }

            public int GetHashCode(JsonSchemaLink obj)
            {
                unchecked
                {
                    var hashCode = (obj.Title != null ? obj.Title.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Rel != null ? obj.Rel.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Href != null ? obj.Href.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Method != null ? obj.Method.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.MediaType != null ? obj.MediaType.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.TargetSchema != null ? obj.TargetSchema.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Schema != null ? obj.Schema.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }

        private static readonly IEqualityComparer<JsonSchemaLink> LinkComparerInstance = new LinkEqualityComparer();

        public static IEqualityComparer<JsonSchemaLink> LinkComparer
        {
            get { return LinkComparerInstance; }
        }
    }
}