using System;
using System.Collections.Generic;

namespace rpg_object_world
{
	public class RPGObject
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Dictionary<string, RPGObject> objects;

		public RPGObject()
		{
			Name = "";
			Description = "";
			objects = new Dictionary<string, RPGObject>();
		}
		public RPGObject(string aName, string aDescription)
		{
			Name = aName;
			Description = aDescription;
			objects = new Dictionary<string, RPGObject>();
		}
		public RPGObject addObject(string name, string description)
		{
			RPGObject anObject = new RPGObject(name, description);
			objects.Add(name, anObject);
			return anObject;
		}
		public override string ToString()
		{
			return string.Format("[Name={0}, Description={1}]", Name, Description);
		}
	}
}
