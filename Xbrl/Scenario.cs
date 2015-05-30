namespace Xoxo
{
	using System;
	using System.Xml.Serialization;
	using System.Collections.ObjectModel;

	[Serializable]
	[XmlRoot(ElementName = "scenario", Namespace = "http://www.xbrl.org/2003/instance")]
	public class Scenario : IEquatable<Scenario>
	{
		[XmlElement("explicitMember", Namespace = "http://xbrl.org/2006/xbrldi")]
		public ExplicitMemberCollection ExplicitMembers { get; set; }

		[XmlElement("typedMember", Namespace = "http://xbrl.org/2006/xbrldi")]
		public TypedMemberCollection TypedMembers { get; set; }

		public Scenario()
		{
			this.ExplicitMembers = new ExplicitMemberCollection();
			this.TypedMembers = new TypedMemberCollection();
		}


		#region IEquatable implementation

		public bool Equals(Scenario other)
		{
			return this.ExplicitMembers.Equals(other.ExplicitMembers)
			&& this.TypedMembers.Equals(other.TypedMembers);
		}

		#endregion
	}


}