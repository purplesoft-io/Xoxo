namespace Diwen.Xbrl
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;

	public class ContextCollection : KeyedCollection<string, Context>, IEquatable<IList<Context>>
	{
		private static IFormatProvider ic = CultureInfo.InvariantCulture;

		private Instance Instance;

		public string IdFormat { get; set; }

		public ContextCollection()
		{
			this.IdFormat = "A{0}";
		}

		public ContextCollection(Instance instance)
			: this()
		{
			this.Instance = instance;
		}

		public new Context Add(Context context)
		{
			if(context == null)
			{
				throw new ArgumentNullException("context");
			}

			if(context.Entity == null)
			{
				context.Entity = Instance.Entity;
			}

			if(context.Period == null)
			{
				context.Period = Instance.Period;
			}

			if(string.IsNullOrEmpty(context.Id))
			{
				var exists = false;
				foreach(var oldContext in this)
				{
					if(context.Equals(oldContext))
					{
						exists = true;
						context = oldContext;
						break;
					}
				}

				if(!exists)
				{
					context.Id = NextId();
					base.Add(context);
				}
			}
			else
			{
				base.Add(context);
			}

			return context;
		}

		public string NextId()
		{
			var counter = this.Count;
			string id;
			do
			{
				id = string.Format(ic, this.IdFormat, counter++);
			}
			while (this.Contains(id));

			return id;
		}

		public void AddRange(IEnumerable<Context> values)
		{
			if(values != null)
			{
				foreach(var item in values)
				{
					this.Add(item);
				}
			}
		}

		protected override string GetKeyForItem(Context item)
		{
			string key = null;
			if(item != null)
			{
				key = item.Id;
			}
			return key;
		}

		#region IEquatable implementation

		public bool Equals(IList<Context> other)
		{
			return this.ContentCompare(other);
		}

		#endregion
	}
}