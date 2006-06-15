﻿/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
 *   which can be found in the file CPL.TXT at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;
namespace clojure.lang
	{
	interface IObj
		{
		Object putAttr(Object key, Object val);

		Object getAttr(Object key);

		bool hasAttr(Object key);

		IPersistentMap attrs();

		void removeAttr(Object key);
		}
	}