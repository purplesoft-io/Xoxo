namespace Xoxo
{
	using System;
	using System.Xml.Serialization;
	using System.Collections.ObjectModel;

	[Serializable]
	public class Entity : IEquatable<Entity>
	{
		[XmlElement("identifier", Namespace = "http://www.xbrl.org/2003/instance")]
		public Identifier Identifier { get; set; }

		public Entity()
		{
			
		}

		public Entity(string identifierScheme, string identifierValue) : this()
		{
			this.Identifier = new Identifier(identifierScheme, identifierValue);
		}

		#region IEquatable implementation

		public bool Equals(Entity other)
		{
			return this.Identifier.Equals(other.Identifier);
		}

		#endregion
	}


}