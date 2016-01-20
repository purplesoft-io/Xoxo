﻿//
//  FactTests.cs
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2016 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace Diwen.Xbrl.Tests
{
	using System.Xml;
	using System;
	using NUnit.Framework;
	using System.IO;

	[TestFixture]
	public class FactTests
	{
		[Test]
		public static void FactWithNullPropertiesToString()
		{
			var fact = new Fact();
			var foo = fact.ToString();
		}
	}
}