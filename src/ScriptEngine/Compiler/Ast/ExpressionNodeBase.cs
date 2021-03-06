/**************************************************************************** 
 * Copyright 2012 David Lurton
 * This Source Code Form is subject to the terms of the Mozilla Public 
 * License, v. 2.0. If a copy of the MPL was not distributed with this file, 
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 ****************************************************************************/

namespace Happy.ScriptEngine.Compiler.Ast
{
	/// <summary>
	/// This class doesn't do anything except provide some additional type-saftey when working with the AST.
	/// </summary>
	abstract class ExpressionNodeBase : StatementNodeBase
	{
		protected ExpressionNodeBase(HappySourceLocation location)
			: base(location)
		{
		}

		protected ExpressionNodeBase(HappySourceLocation startsAt, HappySourceLocation endsAt) : base(startsAt, endsAt)
		{
		}
	}
}

